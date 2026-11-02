using System.Globalization;
using System.Text;

namespace InventorBridge.Mcp.Scripting
{
    public enum ScriptOutcome
    {
        Succeeded,
        CompilationFailed,
        RuntimeFailed,
        ExpectationFailed,
    }

    /// <summary>The result of one run_csharp call, formatted as text for the agent.</summary>
    public sealed class ScriptResult
    {
        public required ScriptOutcome Outcome { get; init; }

        /// <summary>What happened to the transaction: committed, rolled back, or not used.</summary>
        public required string TransactionNote { get; init; }

        public TimeSpan Elapsed { get; init; }

        /// <summary>Lines written by the script with Log().</summary>
        public string Output { get; init; } = "";

        /// <summary>The script's return value as text, or null if it returned nothing.</summary>
        public string? ReturnValue { get; init; }

        /// <summary>Compilation errors or the exception, when the script failed.</summary>
        public string? Error { get; init; }

        /// <summary>What the script changed in the open documents (created, saved, features added...).</summary>
        public IReadOnlyList<string> Changes { get; init; } = [];

        /// <summary>The result of the "expect" check, one line per value; empty when nothing was expected.</summary>
        public IReadOnlyList<string> ExpectationLines { get; init; } = [];

        public bool IsError => Outcome != ScriptOutcome.Succeeded;

        public string ToText()
        {
            var text = new StringBuilder();
            text.AppendLine($"outcome: {FormatOutcome(Outcome)}");
            text.AppendLine($"transaction: {TransactionNote}");
            text.AppendLine(string.Create(CultureInfo.InvariantCulture, $"elapsed: {Elapsed.TotalSeconds:0.00} s"));

            if (Output.Length > 0)
            {
                text.AppendLine("output:");
                text.AppendLine(Output.TrimEnd());
            }

            if (ReturnValue is not null)
            {
                text.AppendLine($"return value: {ReturnValue}");
            }

            if (Outcome != ScriptOutcome.CompilationFailed)
            {
                text.AppendLine(Changes.Count == 0 ? "changes: none detected in the open documents" : "changes:");
                foreach (var change in Changes)
                {
                    text.AppendLine("  " + change);
                }
            }

            if (ExpectationLines.Count > 0)
            {
                text.AppendLine("expect:");
                foreach (var line in ExpectationLines)
                {
                    text.AppendLine("  " + line);
                }
            }

            if (Error is not null)
            {
                text.AppendLine("error:");
                text.AppendLine(Error.TrimEnd());
            }

            return text.ToString();
        }

        private static string FormatOutcome(ScriptOutcome outcome)
        {
            switch (outcome)
            {
                case ScriptOutcome.Succeeded: return "succeeded";
                case ScriptOutcome.CompilationFailed: return "compilation failed (nothing was run)";
                case ScriptOutcome.ExpectationFailed: return "ran, but the result does not match \"expect\" (the changes were kept)";
                default: return "failed while running";
            }
        }
    }
}
