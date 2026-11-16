using System.Text.Json;
using ModelContextProtocol.Client;
using Xunit;

namespace InventorBridge.Mcp.Tests;

/// <summary>
/// A test that needs a running Inventor. Skipped unless INVENTORBRIDGE_INTEGRATION=1, so `dotnet test`
/// stays green on machines without Inventor.
/// </summary>
public sealed class InventorFactAttribute : FactAttribute
{
    public InventorFactAttribute()
    {
        if (Environment.GetEnvironmentVariable("INVENTORBRIDGE_INTEGRATION") != "1")
        {
            Skip = "needs a running Inventor: set INVENTORBRIDGE_INTEGRATION=1 to run it";
        }
    }
}

/// <summary>
/// One server and one empty folder for the whole class. The folder is INVENTORBRIDGE_TEST_FOLDER, or a new
/// folder under %TEMP%; keep it outside a Vault workspace, where add-ins open dialogs on save. At the end, the
/// documents from that folder are closed without saving and the folder is deleted. The user's documents are
/// never touched.
/// </summary>
public sealed class InventorSession : IAsyncLifetime
{
    public McpClient Client { get; private set; } = null!;

    public string Folder { get; } = Path.Combine(
        Environment.GetEnvironmentVariable("INVENTORBRIDGE_TEST_FOLDER") ?? Path.GetTempPath(),
        $"InventorBridgeIntegration-{Guid.NewGuid():N}");

    public async Task InitializeAsync()
    {
        if (Environment.GetEnvironmentVariable("INVENTORBRIDGE_INTEGRATION") != "1")
        {
            return;
        }

        Directory.CreateDirectory(Folder);
        Client = await TestServer.StartAsync();
    }

    public async Task DisposeAsync()
    {
        if (Client is null)
        {
            return;
        }

        await Client.CallToolAsync("run_csharp", new Dictionary<string, object?>
        {
            ["code"] = $$"""
                var folder = @"{{Folder}}\";
                foreach (Document document in App.Documents.Cast<Document>().ToList())
                {
                    if (document.FullFileName.StartsWith(folder, StringComparison.OrdinalIgnoreCase))
                    {
                        document.Close(true);
                    }
                }

                return "closed";
                """,
            ["description"] = "Close the integration test documents",
            ["undoable"] = false,
        });
        await Client.DisposeAsync();

        try
        {
            Directory.Delete(Folder, recursive: true);
        }
        catch (IOException)
        {
            // Inventor can hold a file a moment after closing it; the folder is under %TEMP%.
        }
    }
}

/// <summary>
/// The behaviors that only show on a real Inventor: transactions, rollback, undo, hole features and the
/// notes drawings read from them. Run with INVENTORBRIDGE_INTEGRATION=1 and Inventor open.
/// </summary>
public sealed class InventorIntegrationTests : IClassFixture<InventorSession>
{
    private readonly InventorSession session;

    public InventorIntegrationTests(InventorSession session)
    {
        this.session = session;
    }

    [InventorFact]
    public async Task StatusSeesARunningInventor()
    {
        var text = await CallAsync("inventor_status", []);

        using var status = JsonDocument.Parse(text);
        Assert.True(status.RootElement.GetProperty("running").GetBoolean());
        Assert.True(status.RootElement.GetProperty("ready").GetBoolean());
    }

    [InventorFact]
    public async Task AScriptBuildsAPartAndChecksTheExpectedVolume()
    {
        var text = await RunAsync(CreateBlock("Volume"), "Create a block", expect: new Dictionary<string, object> { ["volumeMm3"] = 50000, ["bodies"] = 1 });

        Assert.Contains("outcome: succeeded", text);
        Assert.Contains("created Volume.ipt", text);
        Assert.Contains("volumeMm3: expected 50000, measured 50000 (ok)", text);
    }

    [InventorFact]
    public async Task AFailedScriptIsRolledBack()
    {
        await RunAsync(CreateBlock("Rollback"), "Create a block");

        var text = await RunAsync("""
            var part = (PartDocument)ActiveDocument;
            var definition = part.ComponentDefinition;
            PlanarSketch sketch = definition.Sketches.Add(definition.WorkPlanes[3]);
            sketch.SketchCircles.AddByCenterRadius(Geometry.CreatePoint2d(Mm(50), Mm(25)), Mm(10));
            definition.Features.ExtrudeFeatures.AddByDistanceExtent(sketch.Profiles.AddForSolid(), Mm(30),
                PartFeatureExtentDirectionEnum.kPositiveExtentDirection, PartFeatureOperationEnum.kJoinOperation);
            throw new InvalidOperationException("stop here");
            """, "Add a boss, then fail");

        Assert.Contains("rolled back", text);
        Assert.Contains("stop here", text);
        Assert.Equal("1 features, 1 sketches", await CountFeaturesAsync());
    }

    [InventorFact]
    public async Task UndoLastUndoesTheLastScript()
    {
        await RunAsync(CreateBlock("Undo"), "Create a block");
        await RunAsync("""
            var definition = ((PartDocument)ActiveDocument).ComponentDefinition;
            EdgeCollection edges = Objects.CreateEdgeCollection();
            edges.Add(definition.SurfaceBodies[1].Edges[1]);
            definition.Features.ChamferFeatures.AddUsingDistance(edges, Mm(2));
            return definition.Features.Count;
            """, "Chamfer one edge");
        Assert.Equal("2 features, 1 sketches", await CountFeaturesAsync());

        var text = await CallAsync("undo_last", []);

        Assert.Contains("undid \"Chamfer one edge\"", text);
        Assert.Equal("1 features, 1 sketches", await CountFeaturesAsync());
    }

    [InventorFact]
    public async Task ADrawingWritesHoleNotesFromHoleFeatures()
    {
        await RunAsync(CreateBlock("Holes"), "Create a block");
        await RunAsync("""
            var definition = ((PartDocument)ActiveDocument).ComponentDefinition;
            Face top = definition.SurfaceBodies[1].Faces.Cast<Face>().First(face =>
                face.SurfaceType == SurfaceTypeEnum.kPlaneSurface && Math.Abs(face.PointOnFace.Z - Mm(10)) < 1e-6);
            PlanarSketch sketch = definition.Sketches.Add(top);
            ObjectCollection centers = Objects.CreateObjectCollection();
            centers.Add(sketch.SketchPoints.Add(sketch.ModelToSketchSpace(Geometry.CreatePoint(Mm(20), Mm(25), Mm(10))), true));
            centers.Add(sketch.SketchPoints.Add(sketch.ModelToSketchSpace(Geometry.CreatePoint(Mm(80), Mm(25), Mm(10))), true));
            HoleFeatures holes = definition.Features.HoleFeatures;
            HoleFeature hole = holes.AddDrilledByThroughAllExtent(holes.CreateSketchPlacementDefinition(centers), Mm(11),
                PartFeatureExtentDirectionEnum.kPositiveExtentDirection);
            ActiveDocument.Save();
            return hole.HealthStatus;
            """, "Two through holes");

        var text = await RunAsync($$"""
            var model = (_Document)ActiveDocument;
            var drawing = (DrawingDocument)CreateDocument(DocumentTypeEnum.kDrawingDocumentObject, @"{{session.Folder}}\Holes.idw");
            Sheet sheet = drawing.ActiveSheet;
            DrawingView view = sheet.DrawingViews.AddBaseView(model, Geometry.CreatePoint2d(sheet.Width / 2, sheet.Height / 2), 1.0,
                ViewOrientationTypeEnum.kFrontViewOrientation, DrawingViewStyleEnum.kHiddenLineRemovedDrawingViewStyle);
            DrawingCurve circle = view.get_DrawingCurves(Type.Missing).Cast<DrawingCurve>()
                .First(curve => curve.CurveType == CurveTypeEnum.kCircleCurve);
            HoleThreadNote note = sheet.DrawingNotes.HoleThreadNotes.Add(
                Geometry.CreatePoint2d(circle.CenterPoint.X + Mm(20), circle.CenterPoint.Y + Mm(20)), circle);
            string format = note.FormattedHoleThreadNote;
            note.UseDefaultFormat = false;
            note.FormattedQuantityNote = "(<Quantity/>x)";
            int end = format.LastIndexOf("</StyleOverride>");
            note.FormattedHoleThreadNote = end < 0 ? $"{format} <QuantityNote/>" : format.Insert(end, " <QuantityNote/>");
            return $"note: {note.Text.Text}";
            """, "Drawing with a hole note");

        // The words come from the template's style: "Ø11 THRU (2x)", "Ø11.00 DE PASSAGEM (2x)" on a Portuguese one.
        Assert.Matches(@"note: n11\b.* \(2x\)", text);
    }

    [InventorFact]
    public async Task ILogicErrorsComeBackWithoutADialog()
    {
        await RunAsync(CreateBlock("ILogic"), "Create a block");

        var compile = await CallILogicAsync("Sub Main()\n    Dim a As Integer = 1\n    Dim b As Strin = \"x\"\nEnd Sub");
        var runtime = await CallILogicAsync("Dim n As Integer = 0\nDim y As Integer = 10 \\ n");
        var status = await CallAsync("inventor_status", []);

        // The words follow Inventor's language; the line numbers are the agent's.
        Assert.Matches(@"(?i)(line|linha) 3\b.*Strin", compile);
        Assert.Contains("DivideByZeroException", runtime);
        Assert.Contains("(line 2)", runtime);
        Assert.Contains("\"ready\": true", status);
    }

    private async Task<string> CallILogicAsync(string code)
    {
        var result = await session.Client.CallToolAsync("ilogic_script", new Dictionary<string, object?>
        {
            ["code"] = code,
            ["description"] = "integration test",
            ["undoable"] = false,
        });
        Assert.True(result.IsError, TestServer.TextOf(result));
        return TestServer.TextOf(result);
    }

    /// <summary>A 100 x 50 x 10 mm block, saved in the test folder and left active.</summary>
    private string CreateBlock(string name)
    {
        return $$"""
            var part = (PartDocument)CreateDocument(DocumentTypeEnum.kPartDocumentObject, @"{{session.Folder}}\{{name}}.ipt");
            var definition = part.ComponentDefinition;
            PlanarSketch sketch = definition.Sketches.Add(definition.WorkPlanes[3]);
            sketch.SketchLines.AddAsTwoPointRectangle(Geometry.CreatePoint2d(0, 0), Geometry.CreatePoint2d(Mm(100), Mm(50)));
            definition.Features.ExtrudeFeatures.AddByDistanceExtent(sketch.Profiles.AddForSolid(), Mm(10),
                PartFeatureExtentDirectionEnum.kPositiveExtentDirection, PartFeatureOperationEnum.kJoinOperation);
            part.Save();
            return part.FullFileName;
            """;
    }

    private async Task<string> CountFeaturesAsync()
    {
        return await RunAsync("""
            var definition = ((PartDocument)ActiveDocument).ComponentDefinition;
            return $"{definition.Features.Count} features, {definition.Sketches.Count} sketches";
            """, "Count features", undoable: false, returnValueOnly: true);
    }

    private async Task<string> RunAsync(string code, string description, Dictionary<string, object>? expect = null,
        bool undoable = true, bool returnValueOnly = false)
    {
        var arguments = new Dictionary<string, object?> { ["code"] = code, ["description"] = description, ["undoable"] = undoable };
        if (expect is not null)
        {
            arguments["expect"] = expect;
        }

        var text = await CallAsync("run_csharp", arguments, allowError: true);
        if (!returnValueOnly)
        {
            return text;
        }

        var line = text.Split('\n').Single(candidate => candidate.StartsWith("return value: "));
        return line["return value: ".Length..].Trim();
    }

    private async Task<string> CallAsync(string tool, Dictionary<string, object?> arguments, bool allowError = false)
    {
        var result = await session.Client.CallToolAsync(tool, arguments);
        var text = TestServer.TextOf(result);
        Assert.True(allowError || result.IsError != true, $"{tool} failed: {text}");
        return text;
    }
}
