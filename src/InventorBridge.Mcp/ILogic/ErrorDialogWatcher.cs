using InventorBridge.Mcp.Connection;

namespace InventorBridge.Mcp.ILogic;

/// <summary>
/// While a rule runs, closes the dialogs iLogic opens for it (a compilation error, or a runtime error the rule
/// did not catch) and keeps their text, so the user is not left with a dialog and the agent sees the error.
/// </summary>
/// <remarks>
/// iLogic names the rule in its dialog titles ("Error on Line 3 in rule: name, in document: ..."), so only the
/// dialogs of this rule are closed. The rule's COM call stays blocked while its dialog is open; this watcher
/// runs on its own thread and uses Win32 only, so it can close the dialog and let the call return.
/// </remarks>
internal sealed class ErrorDialogWatcher : IDisposable
{
    private static readonly TimeSpan Interval = TimeSpan.FromMilliseconds(50);

    private readonly int processId;
    private readonly string ruleName;
    private readonly List<string> texts = [];
    private readonly CancellationTokenSource stop = new();
    private readonly Task loop;

    public ErrorDialogWatcher(int processId, string ruleName)
    {
        this.processId = processId;
        this.ruleName = ruleName;
        loop = processId == 0 || ruleName.Length == 0 ? Task.CompletedTask : Task.Run(WatchAsync);
    }

    /// <summary>The text of the dialogs closed so far, title first.</summary>
    public IReadOnlyList<string> Texts
    {
        get
        {
            lock (texts)
            {
                return texts.ToList();
            }
        }
    }

    private async Task WatchAsync()
    {
        while (!stop.IsCancellationRequested)
        {
            Collect();
            try
            {
                await Task.Delay(Interval, stop.Token);
            }
            catch (TaskCanceledException)
            {
                break;
            }
        }
    }

    private void Collect()
    {
        var closed = InventorWindows.CloseWindowsTitled(processId, ruleName);
        if (closed.Count > 0)
        {
            lock (texts)
            {
                texts.AddRange(closed);
            }
        }
    }

    public void Dispose()
    {
        stop.Cancel();
        loop.Wait(TimeSpan.FromSeconds(1));

        // A dialog that opened as the rule ended.
        Collect();
        stop.Dispose();
    }
}
