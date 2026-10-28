using System.Runtime.InteropServices;

namespace InventorBridge.Mcp.Connection
{
    /// <summary>The COM IMessageFilter interface.</summary>
    [ComImport]
    [Guid("00000016-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IOleMessageFilter
    {
        [PreserveSig]
        int HandleInComingCall(int callType, IntPtr taskCaller, int tickCount, IntPtr interfaceInfo);

        [PreserveSig]
        int RetryRejectedCall(IntPtr taskCallee, int tickCount, int rejectType);

        [PreserveSig]
        int MessagePending(IntPtr taskCallee, int tickCount, int pendingType);
    }

    /// <summary>
    /// Retries calls that Inventor rejects while it is busy (RPC_E_CALL_REJECTED), for example while a
    /// dialog is open or a long command is running, instead of failing them right away.
    /// </summary>
    /// <remarks>Must be registered on the STA thread that makes the COM calls.</remarks>
    internal sealed class RetryMessageFilter : IOleMessageFilter
    {
        private const int ServerCallIsHandled = 0;
        private const int ServerCallRetryLater = 2;
        private const int PendingMessageWaitDefaultProcess = 2;
        private const int CancelCall = -1;

        private const int RetryDelayMilliseconds = 250;
        private const int GiveUpAfterMilliseconds = 60_000;

        public static void Register()
        {
            NativeMethods.CoRegisterMessageFilter(new RetryMessageFilter(), out _);
        }

        public static void Revoke()
        {
            NativeMethods.CoRegisterMessageFilter(null, out _);
        }

        public int HandleInComingCall(int callType, IntPtr taskCaller, int tickCount, IntPtr interfaceInfo)
        {
            return ServerCallIsHandled;
        }

        public int RetryRejectedCall(IntPtr taskCallee, int tickCount, int rejectType)
        {
            if (rejectType == ServerCallRetryLater && tickCount < GiveUpAfterMilliseconds)
            {
                return RetryDelayMilliseconds;
            }

            return CancelCall;
        }

        public int MessagePending(IntPtr taskCallee, int tickCount, int pendingType)
        {
            return PendingMessageWaitDefaultProcess;
        }
    }
}
