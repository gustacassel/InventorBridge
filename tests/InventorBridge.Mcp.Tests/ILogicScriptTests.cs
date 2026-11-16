using InventorBridge.Mcp.ILogic;
using Xunit;

namespace InventorBridge.Mcp.Tests;

/// <summary>
/// iLogic does not tell the caller that a rule failed, so ilogic_script adds a last statement that records the
/// end was reached. It must not move the agent's lines, so iLogic's error line numbers still match.
/// </summary>
public sealed class ILogicScriptTests
{
    private const string Marker = "RuleArguments.Arguments.Value(\"InventorBridgeFinished\") = True";

    [Fact]
    public void PlainStatementsGetTheMarkerAtTheEnd()
    {
        var lines = ILogicRules.WithFinishMarker("Dim n As Integer = 2\nRuleArguments.Arguments.Value(\"Result\") = n").Split("\r\n");

        Assert.Equal(["Dim n As Integer = 2", "RuleArguments.Arguments.Value(\"Result\") = n", Marker], lines);
    }

    [Fact]
    public void SubMainGetsTheMarkerBeforeItsEndSub()
    {
        const string code = "Sub Main()\r\n    Helper()\r\nEnd Sub\r\n\r\nSub Helper()\r\nEnd Sub";

        var lines = ILogicRules.WithFinishMarker(code).Split("\r\n");

        Assert.Equal(["Sub Main()", "    Helper()", Marker, "End Sub", "", "Sub Helper()", "End Sub"], lines);
    }

    [Fact]
    public void SubMainWithoutEndSubIsRejected()
    {
        Assert.Throws<ArgumentException>(() => ILogicRules.WithFinishMarker("Sub Main()\n    x = 1"));
    }
}
