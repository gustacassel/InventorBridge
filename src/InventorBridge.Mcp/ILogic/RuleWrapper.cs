using System.Text.RegularExpressions;

namespace InventorBridge.Mcp.ILogic;

/// <summary>
/// iLogic code made ready to run without a dialog: a runtime error is caught and stored in the arguments map
/// instead of opening iLogic's error dialog, and a last statement records that the code reached its end.
/// </summary>
/// <remarks>
/// The lines the wrapper inserts sit in one block, so <see cref="MapLines"/> turns iLogic's line numbers back
/// into the agent's. With Sub Main, the agent's Main is renamed in place and a new Main that calls it goes
/// before it; plain statements get Sub Main and Try after their AddReference and Imports lines.
/// </remarks>
internal sealed partial record RuleWrapper(string Code, int InsertedAfter, int InsertedCount)
{
    public const string ErrorName = "InventorBridgeError";
    public const string FinishedName = "InventorBridgeFinished";
    private const string UserMain = "InventorBridgeUserMain";

    public static RuleWrapper Wrap(string code)
    {
        var lines = code.Replace("\r\n", "\n").Split('\n').ToList();
        var main = lines.FindIndex(line => MainLine().IsMatch(line));

        if (main >= 0)
        {
            if (lines.FindIndex(main + 1, line => EndSubLine().IsMatch(line)) < 0)
            {
                throw new ArgumentException("The code has Sub Main() but no End Sub after it.");
            }

            lines[main] = MainName().Replace(lines[main], UserMain, 1);
            string[] caller =
            [
                "Sub Main()",
                "    Try",
                $"        {UserMain}()",
                $"        RuleArguments.Arguments.Value(\"{FinishedName}\") = True",
                "    Catch inventorBridgeException As Exception",
                $"        RuleArguments.Arguments.Value(\"{ErrorName}\") = inventorBridgeException.ToString()",
                "    End Try",
                "End Sub",
            ];
            lines.InsertRange(main, caller);
            return new RuleWrapper(string.Join("\r\n", lines), main, caller.Length);
        }

        // Header lines stay before Sub Main: AddReference, Imports, Option, comments and blank lines.
        var header = 0;
        while (header < lines.Count && HeaderLine().IsMatch(lines[header]))
        {
            header++;
        }

        string[] opening = ["Sub Main()", "Try"];
        lines.InsertRange(header, opening);
        lines.AddRange(
        [
            $"RuleArguments.Arguments.Value(\"{FinishedName}\") = True",
            "Catch inventorBridgeException As Exception",
            $"RuleArguments.Arguments.Value(\"{ErrorName}\") = inventorBridgeException.ToString()",
            "End Try",
            "End Sub",
        ]);
        return new RuleWrapper(string.Join("\r\n", lines), header, opening.Length);
    }

    /// <summary>Line numbers in iLogic's dialogs, which count the lines of the rule file, in the agent's numbering.</summary>
    public string MapLines(string text)
    {
        return LineNumber().Replace(text, match => $"{match.Groups[1].Value}{ToAgentLine(int.Parse(match.Groups[2].Value))}");
    }

    /// <summary>
    /// A stack trace in the agent's numbering. Its line numbers count the lines of the .vb file iLogic generates
    /// from the rule (with its own header and class around the code, indentation removed), so each generated line
    /// is matched in order with the rule's lines by its text.
    /// </summary>
    public string MapStackTrace(string text, IReadOnlyList<string> generatedLines)
    {
        var ruleLines = Code.Split("\r\n").Select(line => line.Trim()).ToList();
        var ruleLineOf = new Dictionary<int, int>();
        var next = 0;
        for (var index = 0; index < generatedLines.Count; index++)
        {
            var line = generatedLines[index].Trim();
            if (line.Length == 0 || line.Contains("''**iLogic system", StringComparison.Ordinal))
            {
                continue;
            }

            var found = ruleLines.FindIndex(next, candidate => candidate == line);
            if (found >= 0)
            {
                ruleLineOf[index + 1] = found + 1;
                next = found + 1;
            }
        }

        const string WrapperFrame = "\u0001";
        var mapped = TraceLocation().Replace(text, match =>
        {
            var generated = int.Parse(match.Groups[1].Value);
            if (!ruleLineOf.TryGetValue(generated, out var ruleLine))
            {
                return match.Value;
            }

            var inWrapper = ruleLine > InsertedAfter && ruleLine <= InsertedAfter + InsertedCount;
            return inWrapper ? WrapperFrame : $" (line {ToAgentLine(ruleLine)})";
        });

        // The wrapper's own frame (the Main that calls the agent's) says nothing about the agent's code.
        var lines = mapped.Split('\n').Where(line => !line.Contains(WrapperFrame, StringComparison.Ordinal));
        return string.Join("\n", lines).Replace(UserMain, "Main", StringComparison.Ordinal);
    }

    /// <summary>A line of the rule file as a line of the agent's code; the wrapper's own lines keep their number.</summary>
    private int ToAgentLine(int ruleLine)
    {
        return ruleLine > InsertedAfter + InsertedCount ? ruleLine - InsertedCount : ruleLine;
    }

    [GeneratedRegex(@"^\s*(Public\s+)?Sub\s+Main\s*\(", RegexOptions.IgnoreCase)]
    private static partial Regex MainLine();

    [GeneratedRegex(@"\bMain(?=\s*\()", RegexOptions.IgnoreCase)]
    private static partial Regex MainName();

    [GeneratedRegex(@"^\s*End\s+Sub\b", RegexOptions.IgnoreCase)]
    private static partial Regex EndSubLine();

    [GeneratedRegex(@"^\s*($|'|AddReference\b|Imports\b|Option\b)", RegexOptions.IgnoreCase)]
    private static partial Regex HeaderLine();

    // " in C:\...\iLogic Rules\name.vb:line 14" or " na ...:linha 14" at the end of a stack trace frame.
    [GeneratedRegex(@"[ \t]+\S+[ \t]+[A-Za-z]:\\[^\r\n]*?\.vb:[ \t]*\S+[ \t]+(\d+)")]
    private static partial Regex TraceLocation();

    // "line 12", "linha 12", "Line 12:" in iLogic's dialogs, in English or Portuguese.
    [GeneratedRegex(@"(\b(?:line|linha|l[íi]nea|ligne|Zeile)\s+)(\d+)", RegexOptions.IgnoreCase)]
    private static partial Regex LineNumber();
}
