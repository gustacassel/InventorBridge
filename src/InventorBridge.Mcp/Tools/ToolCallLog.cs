using System.Text.Json;
using ModelContextProtocol.Protocol;

namespace InventorBridge.Mcp.Tools;

/// <summary>
/// An optional record of every tool call and of the notes the agent writes with log_note, for pilots and
/// troubleshooting: one JSON line per event, in a file per day, in the folder INVENTORBRIDGE_LOG names.
/// </summary>
/// <remarks>
/// Off unless the variable is set where the server is registered. The log holds what the agent sent (scripts,
/// paths) and what came back, so it stays on the user's computer, in the folder they chose.
/// </remarks>
public sealed class ToolCallLog
{
    public const string FolderVariable = "INVENTORBRIDGE_LOG";
    private const int MaxTextLength = 20_000;

    private static readonly JsonSerializerOptions JsonOptions = new() { WriteIndented = false };
    private readonly object gate = new();
    private readonly string session = $"{DateTime.Now:yyyyMMdd-HHmmss}-{Environment.ProcessId}";

    public ToolCallLog()
        : this(System.Environment.GetEnvironmentVariable(FolderVariable))
    {
    }

    internal ToolCallLog(string? folder)
    {
        Folder = string.IsNullOrWhiteSpace(folder) ? null : System.Environment.ExpandEnvironmentVariables(folder.Trim().Trim('"'));
    }

    /// <summary>The folder of the log, or null when logging is off.</summary>
    public string? Folder { get; }

    public bool Enabled => Folder is not null;

    public void ToolCall(CallToolRequestParams? request, CallToolResult? result, TimeSpan elapsed, Exception? exception)
    {
        var texts = result?.Content.OfType<TextContentBlock>().Select(block => block.Text) ?? [];
        Write(new Dictionary<string, object?>
        {
            ["type"] = "tool",
            ["tool"] = request?.Name,
            ["arguments"] = request?.Arguments,
            ["isError"] = exception is not null || result?.IsError == true,
            ["result"] = Cut(exception?.ToString() ?? string.Join("\n", texts)),
            ["images"] = result?.Content.OfType<ImageContentBlock>().Count() ?? 0,
            ["seconds"] = Math.Round(elapsed.TotalSeconds, 2),
        });
    }

    public void Note(string kind, string note, string? task)
    {
        Write(new Dictionary<string, object?> { ["type"] = "note", ["kind"] = kind, ["task"] = task, ["note"] = note });
    }

    private void Write(Dictionary<string, object?> entry)
    {
        if (Folder is null)
        {
            return;
        }

        var line = new Dictionary<string, object?> { ["time"] = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff"), ["session"] = session };
        foreach (var (key, value) in entry)
        {
            line[key] = value;
        }

        try
        {
            lock (gate)
            {
                System.IO.Directory.CreateDirectory(Folder);
                var path = System.IO.Path.Combine(Folder, $"{DateTime.Now:yyyy-MM-dd}-server.jsonl");
                System.IO.File.AppendAllText(path, JsonSerializer.Serialize(line, JsonOptions) + "\n");
            }
        }
        catch (Exception exception) when (exception is System.IO.IOException or UnauthorizedAccessException)
        {
            // A log that cannot be written must not break the tool call; the server's stderr says why.
            Console.Error.WriteLine($"InventorBridge: could not write the log in {Folder}: {exception.Message}");
        }
    }

    private static string Cut(string text)
    {
        return text.Length <= MaxTextLength ? text : $"{text[..MaxTextLength]}... ({text.Length - MaxTextLength} more characters)";
    }
}
