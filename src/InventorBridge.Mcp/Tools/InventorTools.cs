using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text.Json;
using InventorBridge.Mcp.Connection;
using InventorBridge.Mcp.Reading;
using InventorBridge.Mcp.Scripting;
using ModelContextProtocol.Protocol;
using ModelContextProtocol.Server;

namespace InventorBridge.Mcp.Tools
{
    /// <summary>
    /// The MCP tools. Each one hands its work to the <see cref="StaDispatcher"/> and turns the result
    /// (or a known error) into a tool result for the agent.
    /// </summary>
    [McpServerToolType]
    public sealed class InventorTools
    {
        private const int DefaultMaxItems = 100;
        private const int DefaultScreenshotWidth = 1280;
        private const int DefaultScreenshotHeight = 800;
        private static readonly TimeSpan StartTimeout = TimeSpan.FromMinutes(5);

        private static readonly JsonSerializerOptions JsonOptions = new() { WriteIndented = true };

        private readonly StaDispatcher dispatcher;
        private readonly InventorSession session;
        private readonly ScriptRunner scriptRunner;

        public InventorTools(StaDispatcher dispatcher, InventorSession session, ScriptRunner scriptRunner)
        {
            this.dispatcher = dispatcher;
            this.session = session;
            this.scriptRunner = scriptRunner;
        }

        [McpServerTool(Name = "inventor_status", Title = "Inventor status", ReadOnly = true, Idempotent = true)]
        [Description(
            "Call this first. Connects to the Inventor the user has open and returns its version, the active project " +
            "(workspace folder where new files must be saved, templates folder), the default part/assembly/drawing " +
            "templates and the open documents. Fails if Inventor is not running.")]
        public Task<CallToolResult> GetStatusAsync()
        {
            return RunAsync(() =>
            {
                var application = session.GetApplication();
                return Text(ToJson(StatusReader.Read(application, startedByThisCall: false)));
            });
        }

        [McpServerTool(Name = "inventor_start", Title = "Start Inventor", Destructive = false, Idempotent = true)]
        [Description(
            "Starts Inventor, visible, when it is not running, and waits until it is ready (this can take a few " +
            "minutes and uses an Inventor license). If Inventor is already running, just connects to it. Only call " +
            "it when the user asked for it or agreed. Returns the same information as inventor_status.")]
        public Task<CallToolResult> StartAsync()
        {
            return RunAsync(() =>
            {
                var (application, started) = session.Start(StartTimeout);
                return Text(ToJson(StatusReader.Read(application, started)));
            });
        }

        [McpServerTool(Name = "run_csharp", Title = "Run C# in Inventor", Destructive = true)]
        [Description(
            "Compiles and runs a C# script against the Inventor API (Autodesk.Inventor.Interop) in the running Inventor.\n" +
            "Globals: App (Inventor.Application), ActiveDocument (Document or null), Geometry (TransientGeometry: " +
            "points, vectors, matrices), Objects (TransientObjects: collections), WorkspacePath (project workspace " +
            "folder), Mm(x) and Deg(x) (convert millimeters and degrees to the API units: cm and radians), Log(x) " +
            "(writes to the output). Imported namespaces: System, System.Collections.Generic, System.Linq, Inventor. " +
            "System.IO is not imported because Inventor has its own File and Path types: write System.IO.Path.Combine.\n" +
            "Rules: all lengths are in cm and angles in radians; do not use await; a value after a final 'return' is " +
            "sent back. Save new files under WorkspacePath. Create documents with App.Documents.Add(type, template) " +
            "using the templates from inventor_status.\n" +
            "The script runs in a transaction on the document that is active when it starts: on success it is one " +
            "undo step in Inventor, on an exception it is rolled back. Documents created by the script are not covered.\n" +
            "Compilation errors come back with line and column; fix them and call again. API reference (one page per " +
            "object, with members per Inventor version): https://github.com/gustacassel/InventorBridge/tree/main/docs/reference")]
        public Task<CallToolResult> RunCSharpAsync(
            [Description("The C# script. Statements run top to bottom; 'return x;' at the end sends x back.")] string code,
            [Description("Short description of what the script does; it becomes the undo step name in Inventor.")] string description)
        {
            return RunAsync(() =>
            {
                var application = session.GetApplication();
                var result = scriptRunner.Run(application, code, description, StatusReader.WorkspacePath(application));
                return result.IsError ? Error(result.ToText()) : Text(result.ToText());
            });
        }

        [McpServerTool(Name = "inspect", Title = "Inspect the active document", ReadOnly = true, Idempotent = true)]
        [Description(
            "Structured summary of the active document, to check work without a screenshot. Part: features (type, " +
            "suppressed, health), parameters, solid bodies, bounding box (mm), volume (mm3). Assembly: occurrences " +
            "(file, grounded, free translations and rotations left), constraints (type, health), parameters, " +
            "bounding box. Drawing: sheets and views.")]
        public Task<CallToolResult> InspectAsync(
            [Description("Maximum number of items per list (features, occurrences...).")] int maxItems = DefaultMaxItems)
        {
            return RunAsync(() =>
            {
                var application = session.GetApplication();
                return Text(ToJson(DocumentInspector.Inspect(application, maxItems)));
            });
        }

        [McpServerTool(Name = "screenshot", Title = "Screenshot of the Inventor view", ReadOnly = false, Idempotent = true)]
        [Description(
            "Captures the active Inventor view as an image, so you can see what the user sees. With view other than " +
            "'current', the camera is turned to that view and zoomed to fit first, which also changes the user's view.")]
        public Task<CallToolResult> ScreenshotAsync(
            [Description("Camera before capturing: current, iso, front, top or right.")] string view = "current",
            [Description("Zoom to fit before capturing (only used with view 'current').")] bool fit = false,
            [Description("Image width in pixels.")] int width = DefaultScreenshotWidth,
            [Description("Image height in pixels.")] int height = DefaultScreenshotHeight)
        {
            if (!Enum.TryParse<CaptureOrientation>(view, ignoreCase: true, out var orientation))
            {
                return Task.FromResult(Error($"Unknown view '{view}'. Use current, iso, front, top or right."));
            }

            return RunAsync(() =>
            {
                var application = session.GetApplication();
                var png = ViewCapture.CapturePng(application, width, height, orientation, fit);

                return new CallToolResult
                {
                    Content = [ImageContentBlock.FromBytes(png, "image/png")],
                };
            });
        }

        /// <summary>Runs the work on the STA thread and turns expected failures into error results.</summary>
        private async Task<CallToolResult> RunAsync(Func<CallToolResult> work)
        {
            try
            {
                return await dispatcher.InvokeAsync(work);
            }
            catch (InventorNotRunningException exception)
            {
                return Error(exception.Message);
            }
            catch (COMException exception)
            {
                return Error($"Inventor returned an error (0x{exception.HResult:X8}): {exception.Message}");
            }
            catch (InvalidOperationException exception)
            {
                return Error(exception.Message);
            }
            catch (TimeoutException exception)
            {
                return Error(exception.Message);
            }
        }

        private static CallToolResult Text(string text)
        {
            return new CallToolResult { Content = [new TextContentBlock { Text = text }] };
        }

        private static CallToolResult Error(string text)
        {
            return new CallToolResult { Content = [new TextContentBlock { Text = text }], IsError = true };
        }

        private static string ToJson(object value)
        {
            return JsonSerializer.Serialize(value, JsonOptions);
        }
    }
}
