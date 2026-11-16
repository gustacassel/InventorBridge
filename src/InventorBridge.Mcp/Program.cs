using InventorBridge.Mcp.Connection;
using InventorBridge.Mcp.Reference;
using InventorBridge.Mcp.Scripting;
using InventorBridge.Mcp.Tools;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ModelContextProtocol.Protocol;

namespace InventorBridge.Mcp
{
    /// <summary>
    /// MCP server (stdio) that lets an AI agent work with the Inventor running on this computer.
    /// Register it in Claude Code with: claude mcp add inventor -- {path to InventorBridge.Mcp.exe}
    /// </summary>
    internal static class Program
    {
        private const string ServerVersion = "0.1.0";

        private const string Instructions =
            "Tools to work with the Autodesk Inventor running on the user's computer. Read guide('workflow') once, then " +
            "start with inventor_status. On an existing model, run check before changing it. Before using a type, member " +
            "or enum value you are not sure about, look it up " +
            "with api_lookup instead of guessing. Make changes with run_csharp (C# against the Inventor API, in cm and " +
            "radians) in small steps, passing 'expect' when you know the numbers; pick faces and edges with topology; " +
            "check the result with inspect and screenshot. The user watches the same Inventor window, so explain what " +
            "you are about to do.";

        private static async Task Main(string[] args)
        {
            var builder = Host.CreateApplicationBuilder(args);

            // stdout carries the MCP protocol, so every log line must go to stderr.
            builder.Logging.AddConsole(options => options.LogToStandardErrorThreshold = LogLevel.Trace);

            builder.Services.AddSingleton<StaDispatcher>();
            builder.Services.AddSingleton<InventorSession>();
            builder.Services.AddSingleton<ScriptRunner>();
            builder.Services.AddSingleton<ScriptMonitor>();
            builder.Services.AddSingleton<ApiReference>();
            var guides = new GuideLibrary();
            builder.Services.AddSingleton(guides);

            builder.Services
                .AddMcpServer(options =>
                {
                    options.ServerInfo = new Implementation { Name = "InventorBridge", Version = ServerVersion };
                    options.ServerInstructions = Instructions + CompanyGuidesInstruction(guides);
                })
                .WithStdioServerTransport()
                .WithTools<InventorTools>();

            await builder.Build().RunAsync();
        }

        /// <summary>
        /// Points the agent to the organization's own guides, when INVENTORBRIDGE_GUIDES names any, because they hold
        /// the rules a general guide cannot know: file names, part numbers, templates, vault rules.
        /// </summary>
        private static string CompanyGuidesInstruction(GuideLibrary guides)
        {
            IReadOnlyList<string> names;
            try
            {
                names = guides.CompanyGuideNames;
            }
            catch (InvalidOperationException)
            {
                return "";
            }

            return names.Count == 0
                ? ""
                : " This organization has its own guides: " + string.Join(", ", names) + ". Read them with guide before " +
                  "creating, naming, saving or exporting files; where they differ from the general guides, they win.";
        }
    }
}
