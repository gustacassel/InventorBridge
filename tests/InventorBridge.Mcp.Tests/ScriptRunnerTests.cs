using InventorBridge.Mcp.Scripting;
using Xunit;

namespace InventorBridge.Mcp.Tests
{
    /// <summary>Compilation needs no Inventor; running a script does, so only the compile path is tested here.</summary>
    public sealed class ScriptRunnerTests
    {
        private readonly ScriptRunner runner = new();

        [Fact]
        public void ValidInventorCodeCompiles()
        {
            const string code =
                "var part = (PartDocument)App.Documents.Add(DocumentTypeEnum.kPartDocumentObject, \"\", true);\n" +
                "PlanarSketch sketch = part.ComponentDefinition.Sketches.Add(part.ComponentDefinition.WorkPlanes[3]);\n" +
                "sketch.SketchCircles.AddByCenterRadius(Geometry.CreatePoint2d(0, 0), Mm(25));\n" +
                "Log(Deg(90));\n" +
                "return System.IO.Path.Combine(WorkspacePath ?? \"\", \"Tube.ipt\");";

            Assert.Empty(runner.GetCompilationErrors(code));
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
}
