using InventorBridge.Mcp.ILogic;
using Xunit;

namespace InventorBridge.Mcp.Tests;

/// <summary>
/// ilogic_script wraps the agent's code so a runtime error comes back in the arguments map instead of iLogic's
/// error dialog, and records that the end was reached. Line numbers in iLogic's messages must still match the
/// agent's code.
/// </summary>
public sealed class ILogicScriptTests
{
    [Fact]
    public void PlainStatementsGoInsideMainAfterTheirHeader()
    {
        var wrapped = RuleWrapper.Wrap("Imports System.IO\nDim n As Integer = 2\nRuleArguments.Arguments.Value(\"Result\") = n");
        var lines = wrapped.Code.Split("\r\n");

        Assert.Equal(["Imports System.IO", "Sub Main()", "Try", "Dim n As Integer = 2"], lines[..4]);
        Assert.Contains("Catch inventorBridgeException As Exception", lines);
        Assert.Equal("End Sub", lines[^1]);
        Assert.Equal("Erro na linha 2: x", wrapped.MapLines("Erro na linha 4: x"));
    }

    [Fact]
    public void SubMainIsRenamedAndCalledFromANewMain()
    {
        var wrapped = RuleWrapper.Wrap("' header\r\nSub Main()\r\n    Helper()\r\nEnd Sub\r\n\r\nSub Helper()\r\nEnd Sub");
        var lines = wrapped.Code.Split("\r\n");

        Assert.Equal("Sub Main()", lines[1]);
        Assert.Contains("        InventorBridgeUserMain()", lines);
        Assert.Contains("Sub InventorBridgeUserMain()", lines);
        Assert.Equal(2 + 8 + 5, lines.Length);

        // Line 3 of the agent's code ("Helper()") is line 11 of the rule file.
        Assert.Equal("    Helper()", lines[10]);
        Assert.Equal("Error on Line 3 in rule", wrapped.MapLines("Error on Line 11 in rule"));
    }

    [Fact]
    public void StackTraceLinesAreMatchedThroughTheGeneratedFile()
    {
        var wrapped = RuleWrapper.Wrap("Sub Main()\n    Dim a As Integer = 1\n    Helper()\nEnd Sub\nSub Helper()\n    Dim x As String = items(3)\nEnd Sub");

        // iLogic's generated .vb: its own header and class, the rule's lines without indentation.
        string[] generated =
        [
            "''**iLogic system code start**", "Imports Inventor", "''**iLogic system code end**", "",
            "Public Partial Class ThisRule ''**iLogic system**",
            "Sub Main()", "Try", "InventorBridgeUserMain()", "RuleArguments.Arguments.Value(\"InventorBridgeFinished\") = True",
            "Catch inventorBridgeException As Exception", "RuleArguments.Arguments.Value(\"InventorBridgeError\") = inventorBridgeException.ToString()",
            "End Try", "End Sub",
            "Sub InventorBridgeUserMain()", "Dim a As Integer = 1", "Helper()", "End Sub", "Sub Helper()", "Dim x As String = items(3)", "End Sub",
        ];
        const string trace = """
            System.ArgumentOutOfRangeException: out of range
               at ThisRule.Helper() in C:\Temp\iLogic Rules\x.vb:line 19
               at ThisRule.InventorBridgeUserMain() in C:\Temp\iLogic Rules\x.vb:line 16
               at ThisRule.Main() in C:\Temp\iLogic Rules\x.vb:line 8
            """;

        var mapped = wrapped.MapStackTrace(trace.Replace("\r\n", "\n"), generated);

        Assert.Equal(
            "System.ArgumentOutOfRangeException: out of range\n   at ThisRule.Helper() (line 6)\n   at ThisRule.Main() (line 3)",
            mapped);
    }

    [Fact]
    public void SubMainWithoutEndSubIsRejected()
    {
        Assert.Throws<ArgumentException>(() => RuleWrapper.Wrap("Sub Main()\n    x = 1"));
    }
}
