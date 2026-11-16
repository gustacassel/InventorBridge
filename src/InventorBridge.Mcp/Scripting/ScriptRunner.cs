using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Inventor;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace InventorBridge.Mcp.Scripting;

/// <summary>
/// Compiles and runs C# scripts against the Inventor API.
/// </summary>
/// <remarks>
/// The script runs inside a transaction on the active document: on success it becomes one undo step
/// in Inventor; on an exception it is rolled back. Inventor transactions belong to one document, so
/// documents created by the script are not covered.
/// Must be called on the <see cref="Connection.StaDispatcher"/> thread, and scripts must not use await:
/// code after an await would resume on another thread, where the COM objects cannot be used.
/// </remarks>
public sealed class ScriptRunner
{
    internal const string TransactionPrefix = "InventorBridge: ";

    // System.IO is left out on purpose: Inventor also has File and Path types, which would be ambiguous.
    private static readonly string[] Imports = ["System", "System.Collections.Generic", "System.Linq", "Inventor"];

    private static readonly Regex ScriptLinePattern = new(@"Submission#\d+.*:line (\d+)", RegexOptions.Compiled);

    private readonly ScriptOptions options = ScriptOptions.Default
        .AddReferences(typeof(Application).Assembly, typeof(ScriptGlobals).Assembly,
            typeof(Microsoft.CSharp.RuntimeBinder.Binder).Assembly) // 'dynamic', for late-bound COM such as iLogic's automation
        .AddImports(Imports)
        .WithEmitDebugInformation(true);

    /// <param name="undoable">False runs the script without a transaction: no undo step, and no rollback on an error.</param>
    public ScriptResult Run(Application application, string code, string description, string? workspacePath,
        ScriptExpectation? expectation, bool undoable = true)
    {
        var stopwatch = Stopwatch.StartNew();

        var script = CreateScript(code);
        var errors = GetCompilationErrors(script);

        if (errors.Count > 0)
        {
            return new ScriptResult
            {
                Outcome = ScriptOutcome.CompilationFailed,
                TransactionNote = "not started",
                Elapsed = stopwatch.Elapsed,
                Error = string.Join(System.Environment.NewLine, errors),
            };
        }

        // Inventor's own dialogs (update an assembly on open, file errors...) would wait for the user and
        // hold the script. Silent operation answers them with the default choice; the script may still turn it off.
        // The invariant culture makes numbers come out with a dot whatever the Windows language, in the output,
        // in the return value and in expressions the script builds ("10.5 mm"), which Inventor accepts everywhere.
        var thread = Thread.CurrentThread;
        var (culture, uiCulture) = (thread.CurrentCulture, thread.CurrentUICulture);
        var wasSilent = application.SilentOperation;
        application.SilentOperation = true;
        thread.CurrentCulture = CultureInfo.InvariantCulture;
        thread.CurrentUICulture = CultureInfo.InvariantCulture;

        try
        {
            return RunSilently(application, script, description, workspacePath, expectation, undoable, stopwatch);
        }
        finally
        {
            thread.CurrentCulture = culture;
            thread.CurrentUICulture = uiCulture;
            RestoreSilentOperation(application, wasSilent);
        }
    }

    /// <summary>The script itself: snapshot, transaction, run, expectation and changes.</summary>
    private static ScriptResult RunSilently(Application application, Script<object> script, string description,
        string? workspacePath, ScriptExpectation? expectation, bool undoable, Stopwatch stopwatch)
    {
        var globals = new ScriptGlobals(application, workspacePath);
        var before = TakeSnapshot(application);
        var transaction = ScriptTransaction.Start(application, TransactionPrefix + description, undoable);

        try
        {
            var state = script.RunAsync(globals).GetAwaiter().GetResult();
            var transactionNote = transaction.Commit(application);

            var expectationLines = new List<string>();
            var expectationMet = expectation is null || expectation.IsEmpty
                || CheckExpectation(application, expectation, expectationLines);

            return new ScriptResult
            {
                Outcome = expectationMet ? ScriptOutcome.Succeeded : ScriptOutcome.ExpectationFailed,
                TransactionNote = transactionNote,
                Elapsed = stopwatch.Elapsed,
                Output = globals.Output,
                ReturnValue = FormatReturnValue(state.ReturnValue),
                Changes = DescribeChanges(application, before),
                ExpectationLines = expectationLines,
            };
        }
        catch (Exception exception)
        {
            var rollbackNote = transaction.RollBack(application);

            return new ScriptResult
            {
                Outcome = ScriptOutcome.RuntimeFailed,
                TransactionNote = rollbackNote,
                Elapsed = stopwatch.Elapsed,
                Output = globals.Output,
                Error = DescribeException(exception),
                Changes = DescribeChanges(application, before),
            };
        }
    }

    /// <summary>The compilation errors of a script, formatted as in run_csharp results; empty when it compiles.</summary>
    /// <remarks>Does not need Inventor: the guides' examples are checked with it.</remarks>
    public IReadOnlyList<string> GetCompilationErrors(string code)
    {
        return GetCompilationErrors(CreateScript(code));
    }

    private Script<object> CreateScript(string code)
    {
        return CSharpScript.Create<object>(code, options, typeof(ScriptGlobals));
    }

    private static List<string> GetCompilationErrors(Script<object> script)
    {
        return script.Compile()
            .Where(diagnostic => diagnostic.Severity == DiagnosticSeverity.Error)
            .Select(FormatDiagnostic)
            .ToList();
    }

    private static DocumentSnapshot? TakeSnapshot(Application application)
    {
        try
        {
            return DocumentSnapshot.Take(application);
        }
        catch (COMException)
        {
            return null;
        }
    }

    private static List<string> DescribeChanges(Application application, DocumentSnapshot? before)
    {
        var after = TakeSnapshot(application);
        if (before is null || after is null)
        {
            return ["could not read the open documents to list the changes"];
        }

        try
        {
            return DocumentSnapshot.Compare(before, after, fullFileName => IsLoaded(application, fullFileName));
        }
        catch (COMException exception)
        {
            return [$"could not list the changes ({exception.Message})"];
        }
    }

    /// <summary>Whether a document with this file is still loaded, with or without a window.</summary>
    private static bool IsLoaded(Application application, string fullFileName)
    {
        try
        {
            _ = application.Documents.ItemByName[fullFileName];
            return true;
        }
        catch (COMException)
        {
            return false;
        }
        catch (ArgumentException)
        {
            return false;
        }
    }

    private static bool CheckExpectation(Application application, ScriptExpectation expectation, List<string> lines)
    {
        try
        {
            lines.AddRange(ExpectationChecker.Check(application, expectation, out var allMet));
            return allMet;
        }
        catch (COMException exception)
        {
            lines.Add($"could not measure the document ({exception.Message})");
            return false;
        }
    }

    /// <summary>"(line,column): CS0103: message", always in English whatever the Windows language.</summary>
    private static string FormatDiagnostic(Diagnostic diagnostic)
    {
        var position = diagnostic.Location.GetLineSpan().StartLinePosition;
        var message = diagnostic.GetMessage(CultureInfo.InvariantCulture);

        return $"({position.Line + 1},{position.Character + 1}): {diagnostic.Id}: {message}";
    }

    /// <summary>Gives Inventor back the user's setting; a closed or crashed Inventor has nothing to restore.</summary>
    private static void RestoreSilentOperation(Application application, bool wasSilent)
    {
        try
        {
            application.SilentOperation = wasSilent;
        }
        catch (COMException)
        {
        }
    }

    private static string? FormatReturnValue(object? value)
    {
        if (value is null)
        {
            return null;
        }

        if (Marshal.IsComObject(value))
        {
            return "an Inventor object (return one of its properties, such as .Name, to see a value)";
        }

        return value.ToString();
    }

    /// <summary>Exception type, HRESULT for COM errors, message and the script line where it happened.</summary>
    private static string DescribeException(Exception exception)
    {
        var root = Unwrap(exception);

        var description = root is COMException comException
            ? $"COMException 0x{comException.HResult:X8}: {comException.Message}"
            : $"{root.GetType().Name}: {root.Message}";

        var lineMatch = ScriptLinePattern.Match(root.StackTrace ?? "");
        if (lineMatch.Success)
        {
            description += $" (script line {lineMatch.Groups[1].Value})";
        }

        return description;
    }

    private static Exception Unwrap(Exception exception)
    {
        var current = exception;

        while (current is AggregateException or TargetInvocationException && current.InnerException is not null)
        {
            current = current.InnerException;
        }

        return current;
    }
}
