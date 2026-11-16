using ModelContextProtocol.Client;
using ModelContextProtocol.Protocol;

namespace InventorBridge.Mcp.Tests;

/// <summary>Starts the built server over stdio, as Claude Code does.</summary>
internal static class TestServer
{
    public static async Task<McpClient> StartAsync(string? companyGuides = null, string? logFolder = null)
    {
        var serverPath = Path.Combine(AppContext.BaseDirectory, "InventorBridge.Mcp.dll");
        var transport = new StdioClientTransport(new StdioClientTransportOptions
        {
            Name = "InventorBridge",
            Command = "dotnet",
            Arguments = [serverPath],
            EnvironmentVariables = new Dictionary<string, string?> { ["INVENTORBRIDGE_GUIDES"] = companyGuides, ["INVENTORBRIDGE_LOG"] = logFolder },
        });

        return await McpClient.CreateAsync(transport);
    }

    public static string TextOf(CallToolResult result)
    {
        return string.Concat(result.Content.OfType<TextContentBlock>().Select(block => block.Text));
    }
}
