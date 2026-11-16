using System.Diagnostics;
using System.Runtime.InteropServices;
using Inventor;
using InventorBridge.Mcp.Reading;
using InventorBridge.Mcp.Scripting;

namespace InventorBridge.Mcp.ILogic;

/// <summary>
/// Lists, writes and runs iLogic rules through the automation interface of the iLogic add-in that ships with
/// Inventor, and runs iLogic code given as text. Rules run inside Inventor's process, but that does not make
/// them faster: measured on Inventor 2024, a cheap API call costs about 1.2 ms from a rule against 0.4 ms
/// across processes, and loops over thousands of occurrences took as long either way.
/// </summary>
/// <remarks>
/// The automation interface has no type library in the interop, so it is used late-bound. Running a rule goes
/// through a transaction like a run_csharp script: undo_last undoes it, an error rolls it back.
/// </remarks>
public static class ILogicRules
{
    private const string ILogicAddInId = "{3BDD8D79-2179-4B11-8A5A-257B1C0263AC}";

    public static object List(Application application, string? documentName, bool withText, int maxItems)
    {
        var document = OpenDocuments.Find(application, documentName);
        var automation = Automation(application);
        var rules = new List<object>();
        var total = 0;

        if (automation.Rules(document) is System.Collections.IEnumerable all)
        {
            foreach (dynamic rule in all)
            {
                total++;
                if (rules.Count >= maxItems)
                {
                    continue;
                }

                rules.Add(new
                {
                    name = (string)rule.Name,
                    active = (bool)rule.IsActive,
                    text = withText ? (string)rule.Text : null,
                });
            }
        }

        return new
        {
            document = document.DisplayName,
            rules,
            truncated = total > rules.Count ? $"{rules.Count} of {total} rules shown; pass a larger maxItems" : null,
            externalRuleFolders = ReadExternalFolders(automation),
        };
    }

    public static string Set(Application application, string? documentName, string name, string text)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Give the rule a name.");
        }

        var document = OpenDocuments.Find(application, documentName);
        var automation = Automation(application);
        dynamic? existing = automation.GetRule(document, name);
        var added = existing is null;

        // AddRule runs the new rule at once, whatever RulesEnabled says, while changing a rule's text with
        // rules disabled does not run it. So a new rule starts as a comment and gets its text afterwards.
        bool rulesEnabled = automation.RulesEnabled;
        automation.RulesEnabled = false;
        try
        {
            if (existing is null)
            {
                automation.AddRule(document, name, "' Added by InventorBridge; the text follows.");
                existing = automation.GetRule(document, name);
            }

            existing!.Text = text;
        }
        finally
        {
            automation.RulesEnabled = rulesEnabled;
        }

        var what = added ? $"added rule \"{name}\" to" : $"replaced the text of rule \"{name}\" in";
        return $"""
            {what} {document.DisplayName} without running it; run it with ilogic_run. Inventor marks the document
            changed: save it to keep the rule.
            """;
    }

    /// <summary>Runs an internal rule by name, or an external rule file, on a document.</summary>
    public static string Run(Application application, string? documentName, string? name, string? externalFile)
    {
        if (string.IsNullOrWhiteSpace(name) == string.IsNullOrWhiteSpace(externalFile))
        {
            throw new ArgumentException("Give either the name of a rule in the document or the path of an external rule file.");
        }

        if (externalFile is not null && !System.IO.File.Exists(externalFile))
        {
            throw new InvalidOperationException($"The external rule {externalFile} does not exist.");
        }

        var document = OpenDocuments.Find(application, documentName);
        var automation = Automation(application);
        var label = name is not null ? $"iLogic rule {name}" : $"iLogic external rule {System.IO.Path.GetFileName(externalFile)}";

        if (name is not null && automation.GetRule(document, name) is null)
        {
            throw new InvalidOperationException($"{document.DisplayName} has no rule named \"{name}\". Call ilogic_list to see its rules.");
        }

        if (!ReferenceEquals(application.ActiveDocument, document))
        {
            document.Activate();
        }

        var stopwatch = Stopwatch.StartNew();
        var transaction = ScriptTransaction.Start(application, ScriptRunner.TransactionPrefix + label, undoable: true);

        // iLogic's dialogs name the rule followed by a comma: "Error on Line 3 in rule: name, in document: ..."
        // for a runtime error, "Rule Compile Errors in name, in ..." for a compilation error.
        var ruleName = name ?? System.IO.Path.GetFileNameWithoutExtension(externalFile!);
        using (var watcher = new ErrorDialogWatcher(InventorProcessId(application), $" {ruleName}, "))
        {
            try
            {
                if (name is not null)
                {
                    automation.RunRule(document, name);
                }
                else
                {
                    automation.RunExternalRule(document, externalFile);
                }
            }
            catch (Exception exception) when (exception is COMException or Microsoft.CSharp.RuntimeBinder.RuntimeBinderException
                or System.Reflection.TargetInvocationException)
            {
                var note = transaction.RollBack(application);
                var message = (exception.InnerException ?? exception).Message;
                throw new InvalidOperationException($"{label} failed: {message}. Transaction: {note}");
            }

            // iLogic's generated copy of the rule; it writes a new one on every run.
            TryDelete(GeneratedFile(name is not null ? $"{document.DisplayName}.{name}" : ruleName));

            var dialogs = watcher.Texts;
            if (dialogs.Count > 0)
            {
                var note = transaction.RollBack(application);
                throw new InvalidOperationException(
                    $"""
                        {label} failed; iLogic reported (its dialog was closed):
                        {string.Join("\n\n", dialogs)}
                        Transaction: {note}.
                        """);
            }
        }

        var committed = transaction.Commit(application);
        var seconds = stopwatch.Elapsed.TotalSeconds.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
        return $"""
            ran {label} on {document.DisplayName} in {seconds} s. Transaction: {committed}.
            iLogic writes Logger output to its own log window, not here; return values through a parameter or an iProperty,
            and read them with inspect.
            """;
    }

    /// <summary>
    /// Runs rule text without storing it in a document: it is written to a temporary external rule file, run with
    /// the arguments, and the arguments map comes back, with whatever the rule set or added to it.
    /// </summary>
    /// <remarks>
    /// The rule reads arguments with RuleArguments.Arguments.Value("Name") and returns values by setting them
    /// (Value("Result") = ...) or adding them (RuleArguments.Arguments.Add("Count", n)). The map is a COM object
    /// of Inventor's, so what the rule writes into it is visible here after the run.
    /// </remarks>
    public static object RunScript(Application application, string? documentName, string code, string description,
        IReadOnlyDictionary<string, object?>? arguments, bool undoable)
    {
        var run = Execute(application, documentName, code, description, arguments, undoable);
        return new
        {
            outcome = "succeeded",
            document = run.Document,
            elapsedSeconds = run.ElapsedSeconds,
            transaction = run.Transaction,
            values = run.Values,
            note = """
                values holds the arguments map after the run: what was passed in, and what the rule set or added.
                Logger output goes to iLogic's log window, not here.
                """,
        };
    }

    /// <summary>What a finished run of iLogic code left: the arguments map, and the transaction's note.</summary>
    internal sealed record ScriptRun(string Document, double ElapsedSeconds, string Transaction, Dictionary<string, object?> Values);

    /// <summary>Runs iLogic code as a temporary external rule; throws when it did not reach its end.</summary>
    internal static ScriptRun Execute(Application application, string? documentName, string code, string description,
        IReadOnlyDictionary<string, object?>? arguments, bool undoable)
    {
        if (string.IsNullOrWhiteSpace(code))
        {
            throw new ArgumentException("Give the rule's text, in iLogic's VB.NET.");
        }

        var document = OpenDocuments.Find(application, documentName);
        var automation = Automation(application);
        if (!ReferenceEquals(application.ActiveDocument, document))
        {
            document.Activate();
        }

        var map = application.TransientObjects.CreateNameValueMap();
        foreach (var (name, value) in arguments ?? new Dictionary<string, object?>())
        {
            map.Add(name, ToComValue(value));
        }

        if (!(arguments?.ContainsKey(ResultName) ?? false))
        {
            map.Add(ResultName, "");
        }

        map.Add(RuleWrapper.FinishedName, false);
        map.Add(RuleWrapper.ErrorName, "");

        var folder = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "InventorBridge");
        System.IO.Directory.CreateDirectory(folder);
        RemoveLeftovers(folder);
        // iLogic names the file in its dialogs, so the name carries the description, and the watcher finds them by it.
        var ruleName = $"{FileNamePart(description)}-{Guid.NewGuid().ToString("N")[..6]}";
        var path = System.IO.Path.Combine(folder, $"{ruleName}.iLogicVb");
        var wrapped = RuleWrapper.Wrap(code);
        System.IO.File.WriteAllText(path, wrapped.Code);

        var label = $"iLogic script: {description}";
        var stopwatch = Stopwatch.StartNew();
        var transaction = ScriptTransaction.Start(application, ScriptRunner.TransactionPrefix + label, undoable);
        IReadOnlyList<string> dialogs;

        using (var watcher = new ErrorDialogWatcher(InventorProcessId(application), ruleName))
        {
            try
            {
                automation.RunExternalRuleWithArguments(document, path, map);
            }
            catch (Exception exception) when (exception is COMException or Microsoft.CSharp.RuntimeBinder.RuntimeBinderException
                or System.Reflection.TargetInvocationException)
            {
                var note = transaction.RollBack(application);
                var message = (exception.InnerException ?? exception).Message;
                throw new InvalidOperationException($"{label} failed: {message}. Transaction: {note}");
            }
            finally
            {
                TryDelete(path);
            }

            dialogs = watcher.Texts;
        }

        var values = new Dictionary<string, object?>();
        var finished = false;
        var error = "";
        for (var index = 1; index <= map.Count; index++)
        {
            var name = map.Name[index];
            if (name == RuleWrapper.FinishedName)
            {
                finished = map.Value[name] is true;
            }
            else if (name == RuleWrapper.ErrorName)
            {
                error = map.Value[name] as string ?? "";
            }
            else
            {
                values[name] = FromComValue(map.Value[name]);
            }
        }

        if (!finished)
        {
            var note = transaction.RollBack(application);
            var reason = error.Length > 0
                ? $"it threw:\n{wrapped.MapStackTrace(ShortStackTrace(error), GeneratedLines(ruleName))}"
                : dialogs.Count > 0
                    ? $"iLogic reported (its dialog was closed; lines numbered as in your code):\n{wrapped.MapLines(string.Join("\n\n", dialogs))}"
                    : "iLogic did not run it, most likely a compilation error that iLogic did not show; check the syntax and names.";
            TryDelete(GeneratedFile(ruleName));
            throw new ScriptNotFinishedException(
                $"""
                    {label} stopped before its end: {reason}
                    Transaction: {note}. Values set before it stopped: {System.Text.Json.JsonSerializer.Serialize(values)}
                    """);
        }

        TryDelete(GeneratedFile(ruleName));
        return new ScriptRun(document.DisplayName, Math.Round(stopwatch.Elapsed.TotalSeconds, 2), transaction.Commit(application), values);
    }

    /// <summary>
    /// The .vb file iLogic generates in %TEMP%\iLogic Rules each time it runs a rule, named after the rule file,
    /// or after the document and the rule for a rule stored in a document. Its stack traces number its lines.
    /// </summary>
    private static string GeneratedFile(string ruleName)
    {
        return System.IO.Path.Combine(System.IO.Path.GetTempPath(), "iLogic Rules", $"{ruleName}.vb");
    }

    /// <summary>
    /// Deletes the temporary rule files of earlier runs, and the files iLogic generated from them. A run cleans up
    /// after itself, but not when the server stopped while the run waited on a dialog. Runs are one at a time, so
    /// no other run is using these files.
    /// </summary>
    private static void RemoveLeftovers(string folder)
    {
        foreach (var path in System.IO.Directory.EnumerateFiles(folder, "*.iLogicVb"))
        {
            TryDelete(GeneratedFile(System.IO.Path.GetFileNameWithoutExtension(path)));
            TryDelete(path);
        }
    }

    /// <summary>The lines of the generated file, then the file is deleted; none when iLogic did not write it.</summary>
    private static IReadOnlyList<string> GeneratedLines(string ruleName)
    {
        var path = GeneratedFile(ruleName);
        try
        {
            var lines = System.IO.File.ReadAllLines(path);
            TryDelete(path);
            return lines;
        }
        catch (Exception exception) when (exception is System.IO.IOException or UnauthorizedAccessException)
        {
            return [];
        }
    }

    private const string ResultName = "Result";

    /// <summary>Thrown when iLogic code did not reach its end; the tool reports it as an error.</summary>
    public sealed class ScriptNotFinishedException(string message) : InvalidOperationException(message);

    /// <summary>An exception's text without the frames of iLogic's own machinery, which say nothing about the code.</summary>
    internal static string ShortStackTrace(string exception)
    {
        var lines = exception.Replace("\r\n", "\n").Split('\n')
            .Where(line => !line.TrimStart().StartsWith("at ", StringComparison.Ordinal) && !line.TrimStart().StartsWith("em ", StringComparison.Ordinal)
                || line.Contains("ThisRule", StringComparison.Ordinal) || line.Contains("LmiRuleScript", StringComparison.Ordinal));
        return string.Join("\n", lines).Trim();
    }

    private static int InventorProcessId(Application application)
    {
        try
        {
            return InventorBridge.Mcp.Connection.InventorWindows.ProcessIdOf(new IntPtr(application.MainFrameHWND));
        }
        catch (COMException)
        {
            return 0;
        }
    }

    private static string FileNamePart(string description)
    {
        var text = new string(description.Select(character => char.IsLetterOrDigit(character) ? character : '-').ToArray()).Trim('-');
        return text.Length == 0 ? "ilogic" : text[..Math.Min(text.Length, 40)];
    }

    /// <summary>JSON values from the tool call as plain values a NameValueMap accepts.</summary>
    private static object ToComValue(object? value)
    {
        return value switch
        {
            null => "",
            System.Text.Json.JsonElement { ValueKind: System.Text.Json.JsonValueKind.String } element => element.GetString() ?? "",
            System.Text.Json.JsonElement { ValueKind: System.Text.Json.JsonValueKind.Number } element => element.GetDouble(),
            System.Text.Json.JsonElement { ValueKind: System.Text.Json.JsonValueKind.True } => true,
            System.Text.Json.JsonElement { ValueKind: System.Text.Json.JsonValueKind.False } => false,
            System.Text.Json.JsonElement element => element.GetRawText(),
            _ => value,
        };
    }

    /// <summary>Values from the map as JSON-friendly values: numbers, booleans and strings as they are, the rest as text.</summary>
    private static object? FromComValue(object? value)
    {
        return value switch
        {
            null => null,
            string or bool or int or long or double or float or decimal or short => value,
            Array array => array.Cast<object?>().Select(FromComValue).ToList(),
            _ when Marshal.IsComObject(value) => "an Inventor object (put one of its properties in the map instead)",
            _ => value.ToString(),
        };
    }

    private static void TryDelete(string path)
    {
        try
        {
            System.IO.File.Delete(path);
        }
        catch (System.IO.IOException)
        {
        }
        catch (UnauthorizedAccessException)
        {
        }
    }

    private static dynamic Automation(Application application)
    {
        ApplicationAddIn addIn;
        try
        {
            addIn = application.ApplicationAddIns.ItemById[ILogicAddInId];
        }
        catch (ArgumentException)
        {
            throw new InvalidOperationException("The iLogic add-in is not installed in this Inventor.");
        }

        if (!addIn.Activated)
        {
            addIn.Activate();
        }

        return addIn.Automation ?? throw new InvalidOperationException("The iLogic add-in did not return its automation interface.");
    }

    private static string[]? ReadExternalFolders(dynamic automation)
    {
        try
        {
            return (string[])automation.FileOptions.ExternalRuleDirectories;
        }
        catch (Exception exception) when (exception is COMException or Microsoft.CSharp.RuntimeBinder.RuntimeBinderException or InvalidCastException)
        {
            return null;
        }
    }
}
