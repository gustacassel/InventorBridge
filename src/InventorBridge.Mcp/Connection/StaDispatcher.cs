using System.Collections.Concurrent;

namespace InventorBridge.Mcp.Connection
{
    /// <summary>
    /// Runs every Inventor call on one dedicated STA thread, one at a time.
    /// </summary>
    /// <remarks>
    /// COM objects obtained on an STA thread can only be used from that thread, and the message filter that
    /// retries rejected calls only works on an STA thread. The MCP server handles requests on thread pool
    /// threads, so the tools hand their work to this dispatcher and await the result.
    /// </remarks>
    public sealed class StaDispatcher : IDisposable
    {
        private readonly BlockingCollection<Action> workQueue = new();
        private readonly Thread thread;

        public StaDispatcher()
        {
            thread = new Thread(ProcessQueue)
            {
                IsBackground = true,
                Name = "Inventor COM (STA)",
            };
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        /// <summary>Queues <paramref name="work"/> to run on the STA thread and returns its result.</summary>
        public Task<T> InvokeAsync<T>(Func<T> work)
        {
            var completion = new TaskCompletionSource<T>(TaskCreationOptions.RunContinuationsAsynchronously);

            workQueue.Add(() =>
            {
                try
                {
                    completion.SetResult(work());
                }
                catch (Exception exception)
                {
                    completion.SetException(exception);
                }
            });

            return completion.Task;
        }

        public void Dispose()
        {
            workQueue.CompleteAdding();
        }

        private void ProcessQueue()
        {
            RetryMessageFilter.Register();

            foreach (var work in workQueue.GetConsumingEnumerable())
            {
                work();
            }

            RetryMessageFilter.Revoke();
        }
    }
}
