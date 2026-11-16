using System.Text;

namespace InventorBridge.Mcp.Connection
{
    /// <summary>
    /// The windows Inventor shows besides its main window, such as a dialog that waits for the user while a
    /// script is blocked in a COM call.
    /// </summary>
    /// <remarks>
    /// Uses only Win32 window functions, never COM, so it works from any thread while the STA thread is busy.
    /// Inventor keeps a few untitled helper windows; only windows with a title, or standard dialogs, are reported.
    /// </remarks>
    public static class InventorWindows
    {
        private const int MaxTitleLength = 256;

        /// <summary>Whether the window has the class of Windows' standard dialogs and message boxes ("#32770").</summary>
        private static bool IsStandardDialog(IntPtr window)
        {
            var className = new StringBuilder(MaxTitleLength);
            NativeMethods.GetClassName(window, className, MaxTitleLength);
            return className.ToString() == "#32770";
        }

        /// <summary>The id of the process that owns a window, or 0.</summary>
        public static int ProcessIdOf(IntPtr window)
        {
            return window != IntPtr.Zero && NativeMethods.GetWindowThreadProcessId(window, out var processId) != 0
                ? (int)processId
                : 0;
        }

        /// <summary>Titles of Inventor's visible top-level windows other than its main window.</summary>
        /// <param name="mainWindow">Inventor's main window (Application.MainFrameHWND); none found when zero.</param>
        public static IReadOnlyList<string> FindOtherWindowTitles(IntPtr mainWindow)
        {
            if (mainWindow == IntPtr.Zero || NativeMethods.GetWindowThreadProcessId(mainWindow, out var processId) == 0)
            {
                return [];
            }

            var titles = new List<string>();
            NativeMethods.EnumWindows((window, _) =>
            {
                if (window != mainWindow
                    && NativeMethods.IsWindowVisible(window)
                    && NativeMethods.GetWindowThreadProcessId(window, out var owner) != 0
                    && owner == processId)
                {
                    var title = new StringBuilder(MaxTitleLength);
                    NativeMethods.GetWindowText(window, title, MaxTitleLength);
                    if (title.Length > 0)
                    {
                        titles.Add(title.ToString());
                    }
                    else if (IsStandardDialog(window))
                    {
                        // A message box shown without a caption, by an iLogic rule for example.
                        titles.Add("(a dialog without a title)");
                    }
                }

                return true;
            }, IntPtr.Zero);

            return titles;
        }
    }
}
