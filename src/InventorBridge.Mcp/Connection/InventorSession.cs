using System.Runtime.InteropServices;
using InventorApplication = Inventor.Application;

namespace InventorBridge.Mcp.Connection
{
    /// <summary>Thrown when a tool needs Inventor and no instance is running.</summary>
    public sealed class InventorNotRunningException : Exception
    {
        public InventorNotRunningException()
            : base("Inventor is not running. Ask the user to open it, or call inventor_start.")
        {
        }
    }

    /// <summary>
    /// Holds the connection to the Inventor instance the user has open (or one started by inventor_start).
    /// </summary>
    /// <remarks>Only use it from the <see cref="StaDispatcher"/> thread.</remarks>
    public sealed class InventorSession
    {
        private const string ProgId = "Inventor.Application";
        private static readonly TimeSpan ReadyPollInterval = TimeSpan.FromSeconds(1);

        private InventorApplication? application;

        /// <summary>The running Inventor, reconnecting if the previous one was closed.</summary>
        /// <exception cref="InventorNotRunningException">No Inventor is running.</exception>
        public InventorApplication GetApplication()
        {
            return TryGetApplication() ?? throw new InventorNotRunningException();
        }

        /// <summary>The running Inventor, or null if none is running.</summary>
        public InventorApplication? TryGetApplication()
        {
            if (application is not null && IsAlive(application))
            {
                return application;
            }

            application = AttachToRunningInstance();
            return application;
        }

        /// <summary>
        /// Returns the running Inventor or, if there is none, starts a visible one and waits until it is ready.
        /// </summary>
        /// <returns>The application and whether this call started it.</returns>
        public (InventorApplication Application, bool Started) Start(TimeSpan timeout)
        {
            var running = TryGetApplication();
            if (running is not null)
            {
                return (running, false);
            }

            var inventorType = Type.GetTypeFromProgID(ProgId)
                ?? throw new InvalidOperationException("Inventor is not installed on this computer (the Inventor.Application ProgID is not registered).");

            var started = (InventorApplication)Activator.CreateInstance(inventorType)!;
            started.Visible = true;
            WaitUntilReady(started, timeout);

            application = started;
            return (started, true);
        }

        private static InventorApplication? AttachToRunningInstance()
        {
            if (NativeMethods.CLSIDFromProgID(ProgId, out var classId) != 0)
            {
                return null;
            }

            var result = NativeMethods.GetActiveObject(ref classId, IntPtr.Zero, out var instance);
            if (result == NativeMethods.MkEUnavailable || instance is null)
            {
                return null;
            }

            Marshal.ThrowExceptionForHR(result);
            return (InventorApplication)instance;
        }

        /// <summary>False if Inventor was closed after we connected to it.</summary>
        private static bool IsAlive(InventorApplication candidate)
        {
            try
            {
                _ = candidate.Ready;
                return true;
            }
            catch (COMException)
            {
                return false;
            }
            catch (InvalidComObjectException)
            {
                return false;
            }
        }

        private static void WaitUntilReady(InventorApplication candidate, TimeSpan timeout)
        {
            var deadline = DateTime.UtcNow + timeout;

            while (!candidate.Ready)
            {
                if (DateTime.UtcNow > deadline)
                {
                    throw new TimeoutException($"Inventor started but was not ready after {timeout.TotalSeconds:0} seconds.");
                }

                Thread.Sleep(ReadyPollInterval);
            }
        }
    }
}
