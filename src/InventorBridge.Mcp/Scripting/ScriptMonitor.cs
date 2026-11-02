using ModelContextProtocol.Protocol;

namespace InventorBridge.Mcp.Scripting
{
    /// <summary>
    /// Keeps track of the run_csharp script that is still running after the tool call returned.
    /// </summary>
    /// <remarks>
    /// A COM call cannot be safely interrupted, so a long script is not killed: run_csharp returns
    /// "still running" and the agent picks up the result later with script_result. Meanwhile the STA thread is
    /// busy, so the other Inventor tools answer "busy" instead of waiting in the queue.
    /// Only one script runs at a time, because every Inventor call goes through the one STA thread.
    /// </remarks>
    public sealed class ScriptMonitor
    {
        private readonly object gate = new();
        private Task<CallToolResult>? task;
        private string description = "";
        private DateTime startedUtc;

        /// <summary>Description of the running script and how long it has run, or null when none is running.</summary>
        public string? DescribeRunning()
        {
            lock (gate)
            {
                if (task is null || task.IsCompleted)
                {
                    return null;
                }

                return $"\"{description}\", running for {(DateTime.UtcNow - startedUtc).TotalSeconds:0} s";
            }
        }

        public void Track(Task<CallToolResult> scriptTask, string scriptDescription)
        {
            lock (gate)
            {
                task = scriptTask;
                description = scriptDescription;
                startedUtc = DateTime.UtcNow;
            }
        }

        /// <summary>The tracked script's task, or null when there is no unreported script.</summary>
        public Task<CallToolResult>? Current()
        {
            lock (gate)
            {
                return task;
            }
        }

        /// <summary>Forgets the script once its result was returned to the agent.</summary>
        public void Clear(Task<CallToolResult> reportedTask)
        {
            lock (gate)
            {
                if (ReferenceEquals(task, reportedTask))
                {
                    task = null;
                }
            }
        }
    }
}
