using ModelContextProtocol.Client;
using ModelContextProtocol.Protocol;
using Xunit;

namespace InventorBridge.Mcp.Tests
{
    /// <summary>
    /// Starts the real server over stdio, as Claude Code does, and checks the tools it declares.
    /// Only tools that do not need Inventor are called.
    /// </summary>
    public sealed class ServerTests
    {
        private static readonly string[] ExpectedTools =
        [
            "inventor_status", "inventor_start", "run_csharp", "script_result", "inspect",
            "topology", "screenshot", "api_lookup", "guide",
        ];

        [Fact]
        public async Task TheServerDeclaresEveryToolWithAllFourHints()
        {
            await using var client = await StartServerAsync();

            var tools = await client.ListToolsAsync();

            Assert.Equal(ExpectedTools.Order(), tools.Select(tool => tool.Name).Order());
            foreach (var tool in tools)
            {
                var hints = tool.ProtocolTool.Annotations;
                Assert.True(hints is not null, $"{tool.Name} has no annotations");
                Assert.True(hints!.ReadOnlyHint is not null, $"{tool.Name}: readOnlyHint");
                Assert.True(hints.DestructiveHint is not null, $"{tool.Name}: destructiveHint");
                Assert.True(hints.IdempotentHint is not null, $"{tool.Name}: idempotentHint");
                Assert.True(hints.OpenWorldHint is not null, $"{tool.Name}: openWorldHint");
            }
        }

        [Fact]
        public async Task GuideAndApiLookupWorkWithoutInventor()
        {
            await using var client = await StartServerAsync();

            var guide = await client.CallToolAsync("guide", new Dictionary<string, object?> { ["name"] = "workflow" });
            var lookup = await client.CallToolAsync("api_lookup", new Dictionary<string, object?> { ["query"] = "ExtrudeFeatures.Add", ["version"] = 2024 });

            Assert.NotEqual(true, guide.IsError);
            Assert.StartsWith("# Workflow", TextOf(guide));
            Assert.NotEqual(true, lookup.IsError);
            Assert.Contains("ExtrudeFeature Add(ExtrudeDefinition Definition);", TextOf(lookup));
        }

        [Fact]
        public async Task ABadArgumentIsAnErrorResult()
        {
            await using var client = await StartServerAsync();

            var result = await client.CallToolAsync("topology", new Dictionary<string, object?> { ["faces"] = "spheres" });

            Assert.True(result.IsError);
            Assert.Contains("Use all, cylinders or none", TextOf(result));
        }

        private static async Task<McpClient> StartServerAsync()
        {
            var serverPath = Path.Combine(AppContext.BaseDirectory, "InventorBridge.Mcp.dll");
            var transport = new StdioClientTransport(new StdioClientTransportOptions
            {
                Name = "InventorBridge",
                Command = "dotnet",
                Arguments = [serverPath],
            });

            return await McpClient.CreateAsync(transport);
        }

        private static string TextOf(CallToolResult result)
        {
            return string.Concat(result.Content.OfType<TextContentBlock>().Select(block => block.Text));
        }
    }
}
