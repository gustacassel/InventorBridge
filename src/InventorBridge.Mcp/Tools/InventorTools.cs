using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text.Json;
using InventorBridge.Mcp.Connection;
using InventorBridge.Mcp.Reading;
using InventorBridge.Mcp.Reference;
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
        private const int DefaultResultWaitSeconds = 30;
        private const int MaxResultWaitSeconds = 300;
        private const int InventorMajorToYear = 1996;
        private static readonly TimeSpan StartTimeout = TimeSpan.FromMinutes(5);
        private static readonly TimeSpan ScriptWaitLimit = TimeSpan.FromSeconds(60);

        private static readonly JsonSerializerOptions JsonOptions = new() { WriteIndented = true };

        private readonly StaDispatcher dispatcher;
        private readonly InventorSession session;
        private readonly ScriptRunner scriptRunner;
        private readonly ScriptMonitor scriptMonitor;
        private readonly ApiReference apiReference;
        private readonly GuideLibrary guides;

        public InventorTools(StaDispatcher dispatcher, InventorSession session, ScriptRunner scriptRunner,
            ScriptMonitor scriptMonitor, ApiReference apiReference, GuideLibrary guides)
        {
            this.dispatcher = dispatcher;
            this.session = session;
            this.scriptRunner = scriptRunner;
            this.scriptMonitor = scriptMonitor;
            this.apiReference = apiReference;
            this.guides = guides;
        }

        [McpServerTool(Name = "inventor_status", Title = "Inventor status",
            ReadOnly = true, Destructive = false, Idempotent = true, OpenWorld = false)]
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

        [McpServerTool(Name = "inventor_start", Title = "Start Inventor",
            ReadOnly = false, Destructive = false, Idempotent = true, OpenWorld = false)]
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

        [McpServerTool(Name = "run_csharp", Title = "Run C# in Inventor",
            ReadOnly = false, Destructive = true, Idempotent = false, OpenWorld = true)]
        [Description(
            "Compiles and runs a C# script against the Inventor API (Autodesk.Inventor.Interop) in the running Inventor.\n" +
            "Globals: App (Inventor.Application), ActiveDocument (Document or null), Geometry (TransientGeometry: " +
            "points, vectors, matrices), Objects (TransientObjects: collections), WorkspacePath (project workspace " +
            "folder), Mm(x) and Deg(x) (convert millimeters and degrees to the API units: cm and radians), Log(x) " +
            "(writes to the output), Name(entity, name) and Named(document or occurrence, name) (name a face, edge or " +
            "vertex and find it again; Named(occurrence, ...) returns the proxy constraints need). Imported namespaces: " +
            "System, System.Collections.Generic, System.Linq, Inventor. System.IO is not imported because Inventor has " +
            "its own File and Path types: write System.IO.Path.Combine.\n" +
            "Rules: all lengths are in cm and angles in radians; do not use await; a value after a final 'return' is " +
            "sent back. Save new files under WorkspacePath. Create documents with App.Documents.Add(type, template) " +
            "using the templates from inventor_status. Check names, signatures and enum values with api_lookup first.\n" +
            "The script runs in a transaction on the document that is active when it starts: on success it is one " +
            "undo step in Inventor, on an exception it is rolled back. Documents created by the script are not covered.\n" +
            "The result lists what changed (documents created or saved, features, sketches, occurrences and " +
            "constraints added). Pass 'expect' to have the result checked (volume, size, bodies, occurrences, free " +
            "degrees of freedom of the active document): a mismatch comes back as an error, with the changes kept.\n" +
            "Compilation errors come back with line and column; fix them and call again. A script still running after " +
            "60 s keeps running: the call returns 'still running' and script_result gives its result later.")]
        public async Task<CallToolResult> RunCSharpAsync(
            [Description("The C# script. Statements run top to bottom; 'return x;' at the end sends x back.")] string code,
            [Description("Short description of what the script does; it becomes the undo step name in Inventor.")] string description,
            [Description("Optional values to check on the active document after the script, such as {\"volumeMm3\": 12345, \"bodies\": 1}.")] ScriptExpectation? expect = null)
        {
            var running = scriptMonitor.DescribeRunning();
            if (running is not null)
            {
                return Error(BusyMessage(running));
            }

            var unreported = await TakeUnreportedResultAsync();

            var scriptTask = RunAsync(() =>
            {
                var application = session.GetApplication();
                var result = scriptRunner.Run(application, code, description, StatusReader.WorkspacePath(application), expect);
                return result.IsError ? Error(result.ToText()) : Text(result.ToText());
            });
            scriptMonitor.Track(scriptTask, description);

            if (await Task.WhenAny(scriptTask, Task.Delay(ScriptWaitLimit)) != scriptTask)
            {
                return Text(
                    $"still running after {ScriptWaitLimit.TotalSeconds:0} s: \"{description}\". The script keeps running; " +
                    "call script_result to wait for its result. The other Inventor tools answer \"busy\" until it finishes.");
            }

            scriptMonitor.Clear(scriptTask);
            var finished = await scriptTask;

            return unreported is null ? finished : Combine(unreported, finished);
        }

        [McpServerTool(Name = "script_result", Title = "Result of a long script",
            ReadOnly = true, Destructive = false, Idempotent = false, OpenWorld = false)]
        [Description(
            "Waits for the run_csharp script that was still running when its call returned, and returns its result. " +
            "If it is still running when the wait ends, says so; call it again to keep waiting.")]
        public async Task<CallToolResult> GetScriptResultAsync(
            [Description("How long to wait for the script, in seconds (up to 300).")] int waitSeconds = DefaultResultWaitSeconds)
        {
            var scriptTask = scriptMonitor.Current();
            if (scriptTask is null)
            {
                return Text("No script is running, and every script result was already returned.");
            }

            var wait = TimeSpan.FromSeconds(Math.Clamp(waitSeconds, 0, MaxResultWaitSeconds));
            if (await Task.WhenAny(scriptTask, Task.Delay(wait)) != scriptTask)
            {
                return Text(
                    $"still running: {scriptMonitor.DescribeRunning()}. Call script_result again to keep waiting. If it " +
                    "never ends (an endless loop, for example), ask the user to restart the InventorBridge MCP server " +
                    "(in Claude Code: /mcp); what the script already did in Inventor stays.");
            }

            scriptMonitor.Clear(scriptTask);
            return await scriptTask;
        }

        [McpServerTool(Name = "inspect", Title = "Inspect the active document",
            ReadOnly = true, Destructive = false, Idempotent = true, OpenWorld = false)]
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

        [McpServerTool(Name = "topology", Title = "Faces and edges",
            ReadOnly = true, Destructive = false, Idempotent = true, OpenWorld = false)]
        [Description(
            "Lists the faces and edges of the active part's bodies, or of one occurrence of the active assembly, so a " +
            "script can pick them: 1-based index, type, a point on it, normal of planes, axis and radius of cylinders, " +
            "center and axis of circular edges, all in mm. For an occurrence, coordinates are in the assembly and the " +
            "entities are proxies, ready for constraints. faces='cylinders' merges cylinders split into several faces " +
            "and gives the centers of their circular edges (the open ends of a tube, for example). Entities named with " +
            "Name() show their name.")]
        public Task<CallToolResult> GetTopologyAsync(
            [Description("In an assembly: the occurrence to read, such as 'Tube:1'.")] string? occurrence = null,
            [Description("Only the body with this name (default: every body).")] string? body = null,
            [Description("Faces to list: all, cylinders (merged, with their ends) or none.")] string faces = "all",
            [Description("Edges to list: all, circles (circles and arcs only) or none.")] string edges = "all",
            [Description("Maximum number of faces and of edges per body.")] int maxItems = DefaultMaxItems)
        {
            if (!Enum.TryParse<FaceDetail>(faces, ignoreCase: true, out var faceDetail))
            {
                return Task.FromResult(Error($"Unknown faces value '{faces}'. Use all, cylinders or none."));
            }

            if (!Enum.TryParse<EdgeDetail>(edges, ignoreCase: true, out var edgeDetail))
            {
                return Task.FromResult(Error($"Unknown edges value '{edges}'. Use all, circles or none."));
            }

            return RunAsync(() =>
            {
                var application = session.GetApplication();
                return Text(ToJson(TopologyReader.Read(application, occurrence, body, faceDetail, edgeDetail, maxItems)));
            });
        }

        [McpServerTool(Name = "screenshot", Title = "Screenshot of the Inventor view",
            ReadOnly = false, Destructive = false, Idempotent = true, OpenWorld = false)]
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

        [McpServerTool(Name = "api_lookup", Title = "Look up the Inventor API",
            ReadOnly = true, Destructive = false, Idempotent = true, OpenWorld = false)]
        [Description(
            "Looks up the Inventor API reference (generated from the interop of Inventor 2024 to 2027), so you do not " +
            "have to guess names, signatures or enum values. Works without Inventor running.\n" +
            "Query forms: 'ExtrudeFeatures' returns the whole page of an object or enum (its interface in pseudo-C#, " +
            "a path to get it from Application, what returns it, what it inherits from); 'ExtrudeFeatures.Add' or " +
            "'ObjectTypeEnum.kExtrude' returns the members of that type whose name contains the text after the dot; " +
            "anything else ('Extrude', 'AddInsertConstraint') searches type and member names.\n" +
            "When Inventor is running, members that do not exist in its version are hidden.")]
        public async Task<CallToolResult> LookUpApiAsync(
            [Description("A type name, 'Type.part of a member name', or any part of a type or member name.")] string query,
            [Description("Inventor version to filter by, such as 2024. Default: the version of the running Inventor, or every version if none is running.")] int? version = null)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return Error("Give a type name (\"ExtrudeFeatures\"), \"Type.member\" or part of a name to search.");
            }

            var year = version ?? await GetRunningInventorYearAsync();

            try
            {
                return Text(apiReference.Lookup(query, year));
            }
            catch (InvalidOperationException exception)
            {
                return Error(exception.Message);
            }
        }

        [McpServerTool(Name = "guide", Title = "Guides",
            ReadOnly = true, Destructive = false, Idempotent = true, OpenWorld = false)]
        [Description(
            "Short guides on working with Inventor through these tools: the workflow, modeling parts, assemblies and " +
            "constraints, and API pitfalls. Call it without a name for the list. Read 'workflow' before the first change.")]
        public CallToolResult GetGuide(
            [Description("Guide name, such as 'workflow'. Leave empty for the list.")] string? name = null)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    return Text(guides.List());
                }

                return guides.Read(name) is string guide
                    ? Text(guide)
                    : Error($"There is no guide named \"{name}\".{System.Environment.NewLine}{guides.List()}");
            }
            catch (InvalidOperationException exception)
            {
                return Error(exception.Message);
            }
        }

        /// <summary>
        /// The year of the running Inventor (Major 28 is 2024), or null when none is running. While a script holds
        /// the STA thread, the year seen last is used instead of waiting.
        /// </summary>
        private async Task<int?> GetRunningInventorYearAsync()
        {
            if (scriptMonitor.DescribeRunning() is not null)
            {
                return session.LastKnownYear;
            }

            try
            {
                var year = await dispatcher.InvokeAsync<int?>(() =>
                {
                    var application = session.TryGetApplication();
                    return application is null ? null : application.SoftwareVersion.Major + InventorMajorToYear;
                });

                session.LastKnownYear = year ?? session.LastKnownYear;
                return year;
            }
            catch (COMException)
            {
                return null;
            }
        }

        /// <summary>
        /// The result of a script that finished after its call returned and was never picked up with script_result,
        /// so it is not lost when the agent runs the next script.
        /// </summary>
        private async Task<CallToolResult?> TakeUnreportedResultAsync()
        {
            var previous = scriptMonitor.Current();
            if (previous is null || !previous.IsCompleted)
            {
                return null;
            }

            scriptMonitor.Clear(previous);
            return await previous;
        }

        /// <summary>Runs the work on the STA thread and turns expected failures into error results.</summary>
        private async Task<CallToolResult> RunAsync(Func<CallToolResult> work)
        {
            var running = scriptMonitor.DescribeRunning();
            if (running is not null)
            {
                return Error(BusyMessage(running));
            }

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
            catch (ArgumentException exception)
            {
                return Error(exception.Message);
            }
            catch (TimeoutException exception)
            {
                return Error(exception.Message);
            }
        }

        private static string BusyMessage(string running)
        {
            return $"Inventor is busy with a script ({running}). Call script_result to wait for it.";
        }

        /// <summary>The previous script's unread result followed by the new one; an error if either is.</summary>
        private static CallToolResult Combine(CallToolResult previous, CallToolResult current)
        {
            var text = "Result of the previous script, which had not been read:" + System.Environment.NewLine
                + TextOf(previous) + System.Environment.NewLine
                + "Result of this script:" + System.Environment.NewLine
                + TextOf(current);

            return new CallToolResult
            {
                Content = [new TextContentBlock { Text = text }],
                IsError = previous.IsError == true || current.IsError == true,
            };
        }

        private static string TextOf(CallToolResult result)
        {
            return string.Join(System.Environment.NewLine, result.Content.OfType<TextContentBlock>().Select(block => block.Text));
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
