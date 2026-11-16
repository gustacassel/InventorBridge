using System.Runtime.InteropServices;

namespace InventorBridge.Mcp.Connection;

/// <summary>Win32 COM functions that .NET 8 no longer wraps (Marshal.GetActiveObject was removed).</summary>
internal static class NativeMethods
{
    /// <summary>HRESULT returned by GetActiveObject when no instance is registered in the Running Object Table.</summary>
    internal const int MkEUnavailable = unchecked((int)0x800401E3);

    [DllImport("ole32.dll", CharSet = CharSet.Unicode)]
    internal static extern int CLSIDFromProgID(string progId, out Guid classId);

    [DllImport("oleaut32.dll")]
    internal static extern int GetActiveObject(ref Guid classId, IntPtr reserved, [MarshalAs(UnmanagedType.IUnknown)] out object? instance);

    [DllImport("ole32.dll")]
    internal static extern int CoRegisterMessageFilter(IOleMessageFilter? newFilter, out IOleMessageFilter? oldFilter);

    internal delegate bool EnumWindowsProc(IntPtr window, IntPtr parameter);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    internal static extern bool EnumWindows(EnumWindowsProc callback, IntPtr parameter);

    [DllImport("user32.dll")]
    internal static extern uint GetWindowThreadProcessId(IntPtr window, out uint processId);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    internal static extern bool IsWindowVisible(IntPtr window);

    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    internal static extern int GetWindowText(IntPtr window, System.Text.StringBuilder text, int maxCount);

    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    internal static extern int GetClassName(IntPtr window, System.Text.StringBuilder className, int maxCount);
}
