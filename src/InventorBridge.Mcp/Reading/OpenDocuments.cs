using Inventor;

namespace InventorBridge.Mcp.Reading;

/// <summary>Finds a loaded document the way the agent names it.</summary>
public static class OpenDocuments
{
    /// <summary>The active document, or the loaded document with this display name, file name or full path.</summary>
    public static Document Find(Application application, string? name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return application.ActiveDocument ?? throw new InvalidOperationException("No document is open.");
        }

        foreach (Document document in application.Documents)
        {
            var file = document.FullFileName ?? "";
            if (string.Equals(document.DisplayName, name, StringComparison.OrdinalIgnoreCase)
                || string.Equals(file, name, StringComparison.OrdinalIgnoreCase)
                || (file.Length > 0 && string.Equals(System.IO.Path.GetFileName(file), name, StringComparison.OrdinalIgnoreCase)))
            {
                return document;
            }
        }

        throw new InvalidOperationException(
            $"No loaded document is named \"{name}\". Use a name or file from inventor_status, or leave it empty for the active document.");
    }
}
