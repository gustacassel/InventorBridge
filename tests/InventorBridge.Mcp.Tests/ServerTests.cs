using Xunit;

namespace InventorBridge.Mcp.Tests;

/// <summary>
/// Starts the real server over stdio, as Claude Code does, and checks the tools it declares.
/// Only tools that do not need Inventor are called.
/// </summary>
public sealed class ServerTests
{
    private static readonly string[] ExpectedTools =
    [
        "inventor_status", "inventor_start", "run_csharp", "script_result", "inspect",
        "topology", "screenshot", "api_lookup", "guide", "bom", "export", "check", "undo_last",
        "ilogic_list", "ilogic_set", "ilogic_run", "ilogic_script", "vault_info", "vault_search", "vault_change", "log_note",
    ];

    [Fact]
    public async Task TheServerDeclaresEveryToolWithAllFourHints()
    {
        await using var client = await TestServer.StartAsync();

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
    public async Task RunCSharpTakesAnOptionalUndoableFlag()
    {
        await using var client = await TestServer.StartAsync();

        var tools = await client.ListToolsAsync();
        var schema = tools.Single(tool => tool.Name == "run_csharp").ProtocolTool.InputSchema;

        var undoable = schema.GetProperty("properties").GetProperty("undoable");
        Assert.Equal("boolean", undoable.GetProperty("type").GetString());
        Assert.DoesNotContain("undoable", schema.GetProperty("required").EnumerateArray().Select(item => item.GetString()));
    }

    [Fact]
    public async Task TheInstructionsPointToTheCompanyGuides()
    {
        var folder = Path.Combine(Path.GetTempPath(), $"inventorbridge-server-guides-{Guid.NewGuid():N}");
        Directory.CreateDirectory(folder);
        File.WriteAllText(Path.Combine(folder, "acme-standards.md"), "# ACME standards\n\n> File names at ACME.\n");

        try
        {
            await using var withGuides = await TestServer.StartAsync(folder);
            await using var without = await TestServer.StartAsync();

            Assert.Contains("This organization has its own guides: acme-standards.", withGuides.ServerInstructions);
            Assert.DoesNotContain("own guides", without.ServerInstructions);
        }
        finally
        {
            Directory.Delete(folder, recursive: true);
        }
    }

    [Fact]
    public async Task GuideAndApiLookupWorkWithoutInventor()
    {
        await using var client = await TestServer.StartAsync();

        var guide = await client.CallToolAsync("guide", new Dictionary<string, object?> { ["name"] = "workflow" });
        var lookup = await client.CallToolAsync("api_lookup", new Dictionary<string, object?> { ["query"] = "ExtrudeFeatures.Add", ["version"] = 2024 });

        Assert.NotEqual(true, guide.IsError);
        Assert.StartsWith("# Workflow", TestServer.TextOf(guide));
        Assert.NotEqual(true, lookup.IsError);
        Assert.Contains("ExtrudeFeature Add(ExtrudeDefinition Definition);", TestServer.TextOf(lookup));
    }

    [Fact]
    public async Task WithALogFolderEveryCallAndNoteIsRecorded()
    {
        var folder = Path.Combine(Path.GetTempPath(), $"inventorbridge-log-{Guid.NewGuid():N}");
        try
        {
            await using (var logged = await TestServer.StartAsync(logFolder: folder))
            {
                Assert.Contains("This session is logged", logged.ServerInstructions);
                await logged.CallToolAsync("guide", new Dictionary<string, object?> { ["name"] = "workflow" });
                await logged.CallToolAsync("log_note", new Dictionary<string, object?> { ["kind"] = "feedback", ["note"] = "It worked.", ["task"] = "test" });
            }

            var lines = File.ReadAllLines(Directory.GetFiles(folder, "*-server.jsonl").Single());
            Assert.Equal(3, lines.Length);
            Assert.Contains("\"tool\":\"guide\"", lines[0]);
            Assert.Contains("\"type\":\"note\"", lines[1]);
            Assert.Contains("It worked.", lines[1]);
            Assert.Contains("\"tool\":\"log_note\"", lines[2]);

            await using var notLogged = await TestServer.StartAsync();
            var note = await notLogged.CallToolAsync("log_note", new Dictionary<string, object?> { ["kind"] = "feedback", ["note"] = "x" });
            Assert.Contains("nothing was recorded", TestServer.TextOf(note));
            Assert.DoesNotContain("logged", notLogged.ServerInstructions);
        }
        finally
        {
            if (Directory.Exists(folder))
            {
                Directory.Delete(folder, recursive: true);
            }
        }
    }

    [Fact]
    public async Task ABadArgumentIsAnErrorResult()
    {
        await using var client = await TestServer.StartAsync();

        var result = await client.CallToolAsync("topology", new Dictionary<string, object?> { ["faces"] = "spheres" });

        Assert.True(result.IsError);
        Assert.Contains("Use all, cylinders or none", TestServer.TextOf(result));
    }
}
