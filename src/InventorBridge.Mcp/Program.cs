using InventorBridge.Mcp.Connection;
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
            "Tools to work with the Autodesk Inventor running on the user's computer. Start with inventor_status. " +
            "Make changes with run_csharp (C# against the Inventor API, in cm and radians), then check them with " +
            "inspect and screenshot. The user watches the same Inventor window, so explain what you are about to do.";

        private static async Task Main(string[] args)
        {
            var builder = Host.CreateApplicationBuilder(args);

            // stdout carries the MCP protocol, so every log line must go to stderr.
            builder.Logging.AddConsole(options => options.LogToStandardErrorThreshold = LogLevel.Trace);

            builder.Services.AddSingleton<StaDispatcher>();
            builder.Services.AddSingleton<InventorSession>();
            builder.Services.AddSingleton<ScriptRunner>();

            builder.Services
                .AddMcpServer(options =>
                {
                    options.ServerInfo = new Implementation { Name = "InventorBridge", Version = ServerVersion };
                    options.ServerInstructions = Instructions;
                })
                .WithStdioServerTransport()
                .WithTools<InventorTools>();

            await builder.Build().RunAsync();
        }
    }
}
