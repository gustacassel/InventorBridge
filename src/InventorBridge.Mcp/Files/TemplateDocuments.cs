using Inventor;

namespace InventorBridge.Mcp.Files;

/// <summary>
/// Creates a new document file by copying a template and opening the copy, instead of Documents.Add followed
/// by SaveAs.
/// </summary>
/// <remarks>
/// Add-ins that intercept saving a new file (Vault Data Standard opens its "New file" dialog on every SaveAs of
/// a document that was never saved) leave a document that already has a file alone, so a script can save it
/// with Save() without a dialog. Like a file copied in Windows, the copy keeps the template's internal name;
/// Inventor handles several such files in one assembly.
/// </remarks>
public static class TemplateDocuments
{
    private const string DesignTracking = "{32853F0F-3444-11D1-9E93-0060B03C1CA6}";

    public static Document Create(Application application, DocumentTypeEnum type, string path, string? template, bool visible)
    {
        if (string.IsNullOrWhiteSpace(path) || !System.IO.Path.IsPathRooted(path))
        {
            throw new ArgumentException("CreateDocument needs the full path of the new file, such as System.IO.Path.Combine(WorkspacePath, \"Bracket.ipt\").");
        }

        if (System.IO.File.Exists(path))
        {
            throw new InvalidOperationException($"{path} already exists: ask the user before replacing it, or open it with App.Documents.Open.");
        }

        var source = string.IsNullOrWhiteSpace(template) ? application.FileManager.GetTemplateFile(type) : template;
        if (!System.IO.File.Exists(source))
        {
            throw new InvalidOperationException($"The template {source} does not exist.");
        }

        var extension = System.IO.Path.GetExtension(source);
        if (!string.Equals(extension, System.IO.Path.GetExtension(path), StringComparison.OrdinalIgnoreCase))
        {
            throw new ArgumentException($"The template is a {extension} file, so the new file must end in {extension}: {path}");
        }

        var folder = System.IO.Path.GetDirectoryName(path);
        if (!string.IsNullOrEmpty(folder))
        {
            System.IO.Directory.CreateDirectory(folder);
        }

        System.IO.File.Copy(source, path);
        // Templates kept in a vault are read-only on disk, and so would be the copy.
        System.IO.File.SetAttributes(path, System.IO.FileAttributes.Normal);

        var document = application.Documents.Open(path, visible);

        // The copy carries the template's part number; a new document's is its file name.
        var partNumber = document.PropertySets[DesignTracking]["Part Number"];
        partNumber.Value = System.IO.Path.GetFileNameWithoutExtension(path);

        return document;
    }
}
