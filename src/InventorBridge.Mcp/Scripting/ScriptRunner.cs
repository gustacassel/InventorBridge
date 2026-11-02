using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Inventor;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace InventorBridge.Mcp.Scripting
{
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
        private const string TransactionPrefix = "InventorBridge: ";

        // System.IO is left out on purpose: Inventor also has File and Path types, which would be ambiguous.
        private static readonly string[] Imports = ["System", "System.Collections.Generic", "System.Linq", "Inventor"];

        private static readonly Regex ScriptLinePattern = new(@"Submission#\d+.*:line (\d+)", RegexOptions.Compiled);

        private readonly ScriptOptions options = ScriptOptions.Default
            .AddReferences(typeof(Application).Assembly, typeof(ScriptGlobals).Assembly)
            .AddImports(Imports)
            .WithEmitDebugInformation(true);

        public ScriptResult Run(Application application, string code, string description, string? workspacePath, ScriptExpectation? expectation)
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

            var globals = new ScriptGlobals(application, workspacePath);
            var before = TakeSnapshot(application);
            var document = application.ActiveDocument;
            var transaction = document is null
                ? null
                : application.TransactionManager.StartTransaction(document, TransactionPrefix + description);

            try
            {
                var state = script.RunAsync(globals).GetAwaiter().GetResult();
                transaction?.End();

                var expectationLines = new List<string>();
                var expectationMet = expectation is null || expectation.IsEmpty
                    || CheckExpectation(application, expectation, expectationLines);

                return new ScriptResult
                {
                    Outcome = expectationMet ? ScriptOutcome.Succeeded : ScriptOutcome.ExpectationFailed,
                    TransactionNote = DescribeCommittedTransaction(transaction, document),
                    Elapsed = stopwatch.Elapsed,
                    Output = globals.Output,
                    ReturnValue = FormatReturnValue(state.ReturnValue),
                    Changes = DescribeChanges(application, before),
                    ExpectationLines = expectationLines,
                };
            }
            catch (Exception exception)
            {
                var rollbackNote = RollBack(transaction, document);

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
                return DocumentSnapshot.Compare(before, after);
            }
            catch (COMException exception)
            {
                return [$"could not list the changes ({exception.Message})"];
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

        private static string DescribeCommittedTransaction(Transaction? transaction, Document? document)
        {
            if (transaction is null || document is null)
            {
                return "none: no document was open when the script started, so nothing can be undone as one step";
            }

            return $"committed on \"{document.DisplayName}\" (one Ctrl+Z in Inventor undoes it; documents created by the script are not covered)";
        }

        private static string RollBack(Transaction? transaction, Document? document)
        {
            if (transaction is null || document is null)
            {
                return "none: no document was open when the script started, so changes made before the error remain";
            }

            try
            {
                transaction.Abort();
                return $"rolled back: changes to \"{document.DisplayName}\" were undone (documents created or saved by the script remain)";
            }
            catch (COMException exception)
            {
                return $"rollback failed ({exception.Message}); check the document state";
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
}
