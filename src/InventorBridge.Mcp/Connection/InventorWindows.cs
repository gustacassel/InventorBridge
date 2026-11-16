using System.Text;

namespace InventorBridge.Mcp.Connection;

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

    /// <summary>
    /// Closes Inventor's visible windows whose title contains <paramref name="titlePart"/> and returns what each
    /// said: the longest of its title and its controls' texts (an iLogic error dialog keeps its whole message,
    /// title included, in an edit box).
    /// </summary>
    public static IReadOnlyList<string> CloseWindowsTitled(int processId, string titlePart)
    {
        var texts = new List<string>();
        NativeMethods.EnumWindows((window, _) =>
        {
            if (NativeMethods.IsWindowVisible(window)
                && NativeMethods.GetWindowThreadProcessId(window, out var owner) != 0
                && owner == processId)
            {
                var title = TextOf(window);
                if (title.Contains(titlePart, StringComparison.OrdinalIgnoreCase))
                {
                    var lines = new List<string> { title };
                    NativeMethods.EnumChildWindows(window, (child, _) =>
                    {
                        var text = TextOf(child).Trim();
                        if (text.Length > 0 && text != title && !lines.Contains(text))
                        {
                            lines.Add(text);
                        }

                        return true;
                    }, IntPtr.Zero);

                    NativeMethods.PostMessage(window, NativeMethods.WmClose, IntPtr.Zero, IntPtr.Zero);
                    texts.Add(lines.MaxBy(line => line.Length)!.Replace("\r\n", "\n").Trim());
                }
            }

            return true;
        }, IntPtr.Zero);

        return texts;
    }

    /// <summary>A window's text through WM_GETTEXT, which also reads edit boxes of other processes.</summary>
    private static string TextOf(IntPtr window)
    {
        var length = (int)NativeMethods.SendMessage(window, NativeMethods.WmGetTextLength, IntPtr.Zero, IntPtr.Zero);
        if (length <= 0)
        {
            return "";
        }

        var text = new StringBuilder(length + 1);
        NativeMethods.SendMessage(window, NativeMethods.WmGetText, length + 1, text);
        return text.ToString();
    }
}
