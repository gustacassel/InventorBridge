using InventorBridge.Mcp.Scripting;
using Xunit;

namespace InventorBridge.Mcp.Tests;

/// <summary>Compilation needs no Inventor; running a script does, so only the compile path is tested here.</summary>
public sealed class ScriptRunnerTests
{
    private readonly ScriptRunner runner = new();

    [Fact]
    public void ValidInventorCodeCompiles()
    {
        const string code =
            """
                var part = (PartDocument)App.Documents.Add(DocumentTypeEnum.kPartDocumentObject, "", true);
                PlanarSketch sketch = part.ComponentDefinition.Sketches.Add(part.ComponentDefinition.WorkPlanes[3]);
                sketch.SketchCircles.AddByCenterRadius(Geometry.CreatePoint2d(0, 0), Mm(25));
                Log(Deg(90));
                return System.IO.Path.Combine(WorkspacePath ?? "", "Tube.ipt");
                """;

        Assert.Empty(runner.GetCompilationErrors(code));
    }

    [Fact]
    public void EveryLoopGetsACancellationCheckOnItsOwnLine()
    {
        const string code =
            """
                var names = new List<string>();
                foreach (ComponentOccurrence occurrence in ((AssemblyDocument)ActiveDocument).ComponentDefinition.Occurrences)
                {
                    names.Add(occurrence.Name);
                }
                for (var i = 0; i < 3; i++)
                    names.Add(i.ToString());
                var n = 0;
                while (n < 2) n++;
                do { n--; } while (n > 0);
                return names.Count;
                """;

        var rewritten = CancellationPoints.Add(code);

        Assert.Equal(4, rewritten.Split("InventorBridgeCheckCancel();").Length - 1);
        Assert.Equal(code.Split('\n').Length, rewritten.Split('\n').Length);
        Assert.Contains("InventorBridgeCheckCancel();", rewritten.Split('\n')[6]);
        Assert.Empty(runner.GetCompilationErrors(code));
    }

    [Fact]
    public void LineNumbersOfErrorsStayTheAgentsAfterTheChecks()
    {
        var errors = runner.GetCompilationErrors("for (var i = 0; i < 2; i++)\n{\n    var x = 1;\n}\nActiveDocument.NoSuchMember();");

        Assert.StartsWith("(5,", Assert.Single(errors));
    }

    [Fact]
    public void ErrorsComeWithLineColumnAndAnEnglishMessage()
    {
        var errors = runner.GetCompilationErrors("var x = 1;\nActiveDocument.NoSuchMember();");

        var error = Assert.Single(errors);
        Assert.StartsWith("(2,16): CS1061: ", error);
        Assert.Contains("does not contain a definition for 'NoSuchMember'", error);
    }

    [Fact]
    public void DynamicCompilesForLateBoundComObjects()
    {
        const string code =
            """
                dynamic automation = App.ApplicationAddIns.ItemById["{3BDD8D79-2179-4B11-8A5A-257B1C0263AC}"].Automation;
                return (string)automation.Rules(ActiveDocument)[1].Name;
                """;

        Assert.Empty(runner.GetCompilationErrors(code));
    }

    [Fact]
    public void PropertiesWithMixedAccessorTypesWorkThroughTheirAccessors()
    {
        // The reference shows Parameter.Units as get_Units() / set_Units(object): the property form does not compile.
        const string accessors = "Parameter p = null!; string units = p.get_Units(); p.set_Units(\"mm\"); return units;";
        const string property = "Parameter p = null!; return p.Units;";

        Assert.Empty(runner.GetCompilationErrors(accessors));
        Assert.Contains(runner.GetCompilationErrors(property), error => error.Contains("CS1545"));
    }

    [Fact]
    public void ACompilationErrorStopsBeforeInventorIsTouched()
    {
        // No Inventor here: a null application would throw if the runner used it.
        var result = runner.Run(null!, "int x = ;", "broken", workspacePath: null, expectation: null);

        Assert.Equal(ScriptOutcome.CompilationFailed, result.Outcome);
        Assert.True(result.IsError);
        Assert.Contains("transaction: not started", result.ToText());
    }

    [Fact]
    public void ScriptGlobalsConvertUnits()
    {
        var globals = new ScriptGlobals(null!, workspacePath: null);

        Assert.Equal(2.5, globals.Mm(25), 10);
        Assert.Equal(Math.PI / 2, globals.Deg(90), 10);
    }
}
