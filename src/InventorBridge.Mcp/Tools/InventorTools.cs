using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text.Json;
using InventorBridge.Mcp.Connection;
using InventorBridge.Mcp.Files;
using InventorBridge.Mcp.ILogic;
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

        // While a script runs, Inventor's windows are checked this often; one that stays open this long ends the wait.
        private static readonly TimeSpan WindowPollInterval = TimeSpan.FromSeconds(1);
        private static readonly TimeSpan DialogGrace = TimeSpan.FromSeconds(2);

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
            "vertex and find it again; Named(occurrence, ...) returns the proxy constraints need), " +
            "CreateDocument(type, path) (a new file copied from the default template, opened, part number set to the " +
            "file name; save it with Save()). Imported namespaces: " +
            "System, System.Collections.Generic, System.Linq, Inventor. System.IO is not imported because Inventor has " +
            "its own File and Path types: write System.IO.Path.Combine.\n" +
            "Rules: all lengths are in cm and angles in radians; do not use await; a value after a final 'return' is " +
            "sent back. Scripts run with the invariant culture, so numbers format with a dot; 'dynamic' works for " +
            "late-bound COM objects such as the iLogic add-in's Automation. Create files to keep with CreateDocument " +
            "under WorkspacePath and save them with Save(): a first SaveAs of a document made with App.Documents.Add " +
            "can open an add-in's dialog. Check names, signatures and enum values with api_lookup first.\n" +
            "The script runs in a transaction on the document that is active when it starts: on success it is one " +
            "undo step in Inventor, on an exception it is rolled back. Documents created by the script are not covered. " +
            "Pass undoable=false for scripts that only read, so they leave no empty undo step.\n" +
            "It runs with App.SilentOperation on, so Inventor answers its own dialogs (update an assembly on open, " +
            "file errors) with the default choice instead of waiting for the user. Add-in dialogs, such as Vault Data " +
            "Standard's on saving a new file, can still appear and hold the script.\n" +
            "The result lists what changed (documents created, opened, saved or closed, features, sketches, " +
            "occurrences and constraints added). Closing a document that another open document references only closes " +
            "its window; the result says so. Pass 'expect' to have the result checked (volume, size, bodies, occurrences, free " +
            "degrees of freedom of the active document): a mismatch comes back as an error, with the changes kept.\n" +
            "Compilation errors come back with line and column; fix them and call again. A script still running after " +
            "60 s keeps running: the call returns 'still running' and script_result gives its result later. If Inventor " +
            "opens a window while the script waits, the call returns sooner with that window's title.")]
        public async Task<CallToolResult> RunCSharpAsync(
            [Description("The C# script. Statements run top to bottom; 'return x;' at the end sends x back.")] string code,
            [Description("Short description of what the script does; it becomes the undo step name in Inventor.")] string description,
            [Description("Optional values to check on the active document after the script, such as {\"volumeMm3\": 12345, \"bodies\": 1}.")] ScriptExpectation? expect = null,
            [Description("False for a script that only reads: it runs without a transaction, so it leaves no empty undo step in Inventor, and an error rolls nothing back.")] bool undoable = true)
        {
            return await RunTrackedAsync(description, application =>
            {
                var result = scriptRunner.Run(application, code, description, StatusReader.WorkspacePath(application), expect, undoable);
                return result.IsError ? Error(result.ToText()) : Text(result.ToText());
            });
        }

        /// <summary>
        /// Runs work that can take long or hit a dialog (a script, an export, a check of a large assembly) the way
        /// run_csharp does: it is tracked, the call returns after 60 s or as soon as Inventor keeps a window open,
        /// and script_result picks up the result later.
        /// </summary>
        private async Task<CallToolResult> RunTrackedAsync(string description, Func<Inventor.Application, CallToolResult> work)
        {
            var running = scriptMonitor.DescribeRunning();
            if (running is not null)
            {
                return Error(BusyMessage(running));
            }

            var unreported = await TakeUnreportedResultAsync();

            var task = RunAsync(() =>
            {
                var application = session.GetApplication();
                scriptMonitor.InventorWindow = new IntPtr(application.MainFrameHWND);
                return work(application);
            });
            scriptMonitor.Track(task, description);

            var windows = await WaitForScriptAsync(task, ScriptWaitLimit);
            if (!task.IsCompleted)
            {
                return Text(StillRunningMessage(windows) +
                    " It keeps running; call script_result to wait for its result. The other Inventor tools " +
                    "answer \"busy\" until it finishes.");
            }

            scriptMonitor.Clear(task);
            var finished = await task;

            return unreported is null ? finished : Combine(unreported, finished);
        }

        [McpServerTool(Name = "script_result", Title = "Result of a long script",
            ReadOnly = true, Destructive = false, Idempotent = false, OpenWorld = false)]
        [Description(
            "Waits for the run_csharp script (or export, check or bom) that was still running when its call returned, " +
            "and returns its result. " +
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
            var windows = await WaitForScriptAsync(scriptTask, wait);
            if (!scriptTask.IsCompleted)
            {
                return Text(StillRunningMessage(windows) + " Call script_result again to keep waiting." +
                    (windows.Count > 0 ? "" :
                        " If it never ends (an endless loop, for example), ask the user to restart the InventorBridge " +
                        "MCP server (in Claude Code: /mcp); what the script already did in Inventor stays."));
            }

            scriptMonitor.Clear(scriptTask);
            return await scriptTask;
        }

        [McpServerTool(Name = "inspect", Title = "Inspect the active document",
            ReadOnly = true, Destructive = false, Idempotent = true, OpenWorld = false)]
        [Description(
            "Structured summary of the active document, to check work without a screenshot. Every document: iProperties " +
            "(part number, description, stock number, revision, custom ones), unsaved changes, whether it needs an " +
            "update and whether its file is read-only. Part: model state, features (type, suppressed, health) and the " +
            "ones with problems, parameters, solid bodies, bounding box (mm), volume (mm3), mass (kg), material, and " +
            "thickness and flat pattern size of sheet metal. Assembly: model state, design view, occurrence counts, " +
            "occurrences (file, subassembly, grounded, free translations and rotations left), constraints and the ones " +
            "with problems, parameters, bounding box, mass. Drawing: referenced models; per sheet the size, border, " +
            "title block, views (type, scale, model, style, center), parts lists, balloons, dimensions (and how many " +
            "are detached) and notes. 'truncated' lists what maxItems cut.")]
        public Task<CallToolResult> InspectAsync(
            [Description("Maximum number of items per list (features, occurrences...).")] int maxItems = DefaultMaxItems)
        {
            return RunAsync(() =>
            {
                var application = session.GetApplication();
                return Text(ToJson(DocumentInspector.Inspect(application, maxItems)));
            });
        }

        [McpServerTool(Name = "bom", Title = "Bill of materials",
            ReadOnly = true, Destructive = false, Idempotent = true, OpenWorld = false)]
        [Description(
            "Bill of materials of the active assembly, with quantities rolled up through the levels: 'rows' is the " +
            "tree (level, path of part numbers, quantity per parent, total for one assembly, BOM structure, file) and " +
            "'totals' adds up each part number across the whole assembly, the list of what to make or buy. Follows the " +
            "BOM rules: phantoms are replaced by their children, references are left out, purchased components are not " +
            "expanded. Reads the Model Data view, so the document is not changed. Part numbers and descriptions come " +
            "from the iProperties; a file without a part number shows its file name.")]
        public Task<CallToolResult> GetBomAsync(
            [Description("Deepest level to list in 'rows' (1 = only the assembly's direct components). Totals always cover every level.")] int? maxLevels = null,
            [Description("Maximum number of rows and of totals.")] int maxItems = 500)
        {
            return RunTrackedAsync("read the bill of materials",
                application => Text(ToJson(BomReader.Read(application, maxLevels, maxItems))));
        }

        [McpServerTool(Name = "export", Title = "Export to another format",
            ReadOnly = false, Destructive = true, Idempotent = true, OpenWorld = false)]
        [Description(
            "Exports an open document to a file; the extension of 'path' picks the format. Part or assembly: .stp/.step, " +
            ".igs/.iges, .stl, .sat. Sheet metal part: .dxf writes its flat pattern. Drawing: .pdf, .dwg, .dxf (with the " +
            "translator's default options; a drawing with several sheets can give one file per sheet, all listed). " +
            "The document itself is not changed or renamed. An existing file is only replaced with overwrite: true; ask " +
            "the user before passing it. Missing folders are created.")]
        public Task<CallToolResult> ExportAsync(
            [Description("Full path of the file to write, such as C:\\Exports\\Bracket.stp.")] string path,
            [Description("The document to export: its name or file as listed by inventor_status. Default: the active document.")] string? document = null,
            [Description("Replace the file if it exists. Only after the user agreed.")] bool overwrite = false,
            [Description("Flat pattern DXF only: options after the '?' of Inventor's DXF format string, such as 'AcadVersion=2010&OuterProfileLayer=OUTER'. Default: AcadVersion=2018.")] string? dxfOptions = null,
            [Description("Drawing DWG or DXF only: an export configuration (.ini) saved from Inventor's DWG/DXF export dialog, with the company's layers and version. Default: the one Inventor installs in Design Data\\DWG-DXF.")] string? configFile = null)
        {
            return RunTrackedAsync($"export to {path}",
                application => Text(DocumentExporter.Export(application, path, document, overwrite, dxfOptions, configFile)));
        }

        [McpServerTool(Name = "check", Title = "Check for problems",
            ReadOnly = true, Destructive = false, Idempotent = true, OpenWorld = false)]
        [Description(
            "Checks a document and every document it references for what is broken: missing files, documents that " +
            "need an update, features and assembly constraints with errors (in every part and subassembly), broken " +
            "flat patterns, and dimensions or balloons of a drawing that lost their geometry. Reads only. On a large " +
            "assembly it stops at the time limit and says how many documents it checked.")]
        public Task<CallToolResult> CheckAsync(
            [Description("The document to check: its name or file as listed by inventor_status. Default: the active document.")] string? document = null,
            [Description("Maximum number of problems listed.")] int maxItems = DefaultMaxItems,
            [Description("Seconds to spend before stopping (up to 300).")] int timeLimitSeconds = 45)
        {
            return RunTrackedAsync("check for problems", application =>
            {
                var target = OpenDocuments.Find(application, document);
                var limit = TimeSpan.FromSeconds(Math.Clamp(timeLimitSeconds, 1, MaxResultWaitSeconds));
                return Text(ToJson(IntegrityChecker.Check(application, target, maxItems, limit)));
            });
        }

        [McpServerTool(Name = "undo_last", Title = "Undo the last script",
            ReadOnly = false, Destructive = true, Idempotent = false, OpenWorld = false)]
        [Description(
            "Undoes the last run_csharp script, like Ctrl+Z in Inventor. Only when the last step in Inventor's undo " +
            "list is a script's: if the user did something by hand since, nothing is undone and the step is named. " +
            "Documents the script created or saved stay. Call it again to undo the script before.")]
        public Task<CallToolResult> UndoLastAsync()
        {
            return RunAsync(() =>
            {
                var application = session.GetApplication();
                return Text(ScriptUndo.UndoLast(application));
            });
        }

        [McpServerTool(Name = "ilogic_list", Title = "List iLogic rules",
            ReadOnly = true, Destructive = false, Idempotent = true, OpenWorld = false)]
        [Description(
            "Lists the iLogic rules stored in a document (name, active, and their text with withText: true) and the " +
            "external rule folders configured in iLogic.")]
        public Task<CallToolResult> ListILogicRulesAsync(
            [Description("The document: its name or file as listed by inventor_status. Default: the active document.")] string? document = null,
            [Description("Also return each rule's text.")] bool withText = false,
            [Description("Maximum number of rules listed.")] int maxItems = DefaultMaxItems)
        {
            return RunAsync(() =>
            {
                var application = session.GetApplication();
                return Text(ToJson(ILogicRules.List(application, document, withText, maxItems)));
            });
        }

        [McpServerTool(Name = "ilogic_set", Title = "Write an iLogic rule",
            ReadOnly = false, Destructive = true, Idempotent = true, OpenWorld = false)]
        [Description(
            "Adds an iLogic rule (VB.NET, iLogic syntax) to a document, or replaces the text of the rule with that name. " +
            "It does not run it and does not save the document. Replacing a rule the user wrote loses its old text: " +
            "read it with ilogic_list first and ask.")]
        public Task<CallToolResult> SetILogicRuleAsync(
            [Description("Rule name.")] string name,
            [Description("The rule's full text, in iLogic's VB.NET.")] string text,
            [Description("The document: its name or file as listed by inventor_status. Default: the active document.")] string? document = null)
        {
            return RunTrackedAsync($"write iLogic rule {name}", application => Text(ILogicRules.Set(application, document, name, text)));
        }

        [McpServerTool(Name = "ilogic_run", Title = "Run an iLogic rule",
            ReadOnly = false, Destructive = true, Idempotent = false, OpenWorld = true)]
        [Description(
            "Runs an iLogic rule inside Inventor: a rule stored in the document (name) or an external rule file " +
            "(externalFile). Like run_csharp it runs in a transaction (undo_last undoes it; an error rolls it back), " +
            "returns early with the title when the rule shows a message box, and script_result picks up a long run. " +
            "Rules run in Inventor's process, so loops over thousands of entities are much faster than in run_csharp. " +
            "Logger output goes to iLogic's log window, not here: return values through a parameter or iProperty.")]
        public Task<CallToolResult> RunILogicRuleAsync(
            [Description("Name of a rule stored in the document.")] string? name = null,
            [Description("Full path of an external rule file (.iLogicVb, .vb or .txt), instead of a name.")] string? externalFile = null,
            [Description("The document to run it on: its name or file as listed by inventor_status. Default: the active document.")] string? document = null)
        {
            return RunTrackedAsync($"iLogic rule {name ?? externalFile}",
                application => Text(ILogicRules.Run(application, document, name, externalFile)));
        }

        [McpServerTool(Name = "topology", Title = "Faces and edges",
            ReadOnly = true, Destructive = false, Idempotent = true, OpenWorld = false)]
        [Description(
            "Lists the faces and edges of the active part's bodies, or of one occurrence of the active assembly, so a " +
            "script can pick them: 1-based index, type, a point on it, normal of planes, axis and radius of cylinders, " +
            "center and axis of circular edges, all in mm. For an occurrence, coordinates are in the assembly and the " +
            "entities are proxies, ready for constraints. faces='cylinders' merges cylinders split into several faces " +
            "and gives the centers of their circular edges or arcs (the open ends of a tube, the ends of a hole or a " +
            "slot), and lists tori (bends) with the centers of their ends. Entities named with Name() show their name.")]
        public Task<CallToolResult> GetTopologyAsync(
            [Description("In an assembly: the occurrence to read, such as 'Tube:1', or a path into subassemblies, such as 'Frame:1/Bracket:2'.")] string? occurrence = null,
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
            "'current', the camera is turned to that view and zoomed to fit first, which also changes the user's view. " +
            "Work planes, axes, points and sketches are hidden for the capture unless hideHelpers is false. On a " +
            "drawing, zoomTo ('sheet', 'partsList', 'titleBlock' or a view's name) or regionMm zooms into the active " +
            "sheet to read details; the user's camera is put back afterwards.")]
        public Task<CallToolResult> ScreenshotAsync(
            [Description("Camera before capturing: current, iso, front, top or right.")] string view = "current",
            [Description("Zoom to fit before capturing (only used with view 'current').")] bool fit = false,
            [Description("Image width in pixels.")] int width = DefaultScreenshotWidth,
            [Description("Image height in pixels.")] int height = DefaultScreenshotHeight,
            [Description("Hide work planes, axes, points, coordinate systems and sketches during the capture.")] bool hideHelpers = true,
            [Description("Drawings: zoom to 'sheet', 'partsList', 'titleBlock' or a view's name, such as 'VIEW1', on the active sheet.")] string? zoomTo = null,
            [Description("Drawings: zoom to this region of the active sheet, [minX, minY, maxX, maxY] in mm from its lower left corner.")] double[]? regionMm = null)
        {
            if (!Enum.TryParse<CaptureOrientation>(view, ignoreCase: true, out var orientation))
            {
                return Task.FromResult(Error($"Unknown view '{view}'. Use current, iso, front, top or right."));
            }

            return RunAsync(() =>
            {
                var application = session.GetApplication();
                var png = ViewCapture.CapturePng(application, width, height, orientation, fit, hideHelpers, zoomTo, regionMm);

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

        /// <summary>
        /// Waits for the script up to the limit, returning early when Inventor keeps another window open (a dialog
        /// waiting for the user, most likely) for <see cref="DialogGrace"/>. Returns the titles of those windows.
        /// </summary>
        private async Task<IReadOnlyList<string>> WaitForScriptAsync(Task scriptTask, TimeSpan limit)
        {
            var deadline = DateTime.UtcNow + limit;
            DateTime? windowsSinceUtc = null;

            while (true)
            {
                var remaining = deadline - DateTime.UtcNow;
                if (remaining <= TimeSpan.Zero)
                {
                    return scriptTask.IsCompleted ? [] : InventorWindows.FindOtherWindowTitles(scriptMonitor.InventorWindow);
                }

                var step = remaining < WindowPollInterval ? remaining : WindowPollInterval;
                if (await Task.WhenAny(scriptTask, Task.Delay(step)) == scriptTask)
                {
                    return [];
                }

                var windows = InventorWindows.FindOtherWindowTitles(scriptMonitor.InventorWindow);
                if (windows.Count == 0)
                {
                    windowsSinceUtc = null;
                    continue;
                }

                windowsSinceUtc ??= DateTime.UtcNow;
                if (DateTime.UtcNow - windowsSinceUtc >= DialogGrace)
                {
                    return windows;
                }
            }
        }

        /// <summary>"still running: ..." and, when Inventor shows other windows, what to tell the user.</summary>
        private string StillRunningMessage(IReadOnlyList<string> windows)
        {
            var message = $"still running: {scriptMonitor.DescribeRunning() ?? "the script"}.";
            if (windows.Count > 0)
            {
                message += $" Inventor shows a window that is probably waiting for the user: {QuoteTitles(windows)}. " +
                    "Scripts run with SilentOperation, so it most likely comes from an add-in (such as Vault Data " +
                    "Standard's dialog on saving a new file). Tell the user to answer or cancel it in Inventor.";
            }

            return message;
        }

        private string BusyMessage(string running)
        {
            var windows = InventorWindows.FindOtherWindowTitles(scriptMonitor.InventorWindow);
            var dialog = windows.Count == 0 ? "" : $" Inventor shows {QuoteTitles(windows)}, which may be waiting for the user.";
            return $"Inventor is busy with a script ({running}).{dialog} Call script_result to wait for it.";
        }

        private static string QuoteTitles(IReadOnlyList<string> titles)
        {
            return string.Join(", ", titles.Select(title => $"\"{title}\""));
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
