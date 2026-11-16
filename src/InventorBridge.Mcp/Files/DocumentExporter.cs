using System.Diagnostics;
using Inventor;
using InventorBridge.Mcp.Reading;

namespace InventorBridge.Mcp.Files;

/// <summary>
/// Exports an open document to another format. The file extension picks the format: Inventor's
/// <c>SaveAs(path, SaveCopyAs: true)</c> chooses the translator from it and leaves the document as it was.
/// A sheet metal part exported to DXF gives its flat pattern.
/// </summary>
/// <remarks>
/// Saving a copy in another format does not go through add-ins that intercept saving new Inventor files (such
/// as Vault Data Standard), and runs with SilentOperation on so Inventor's own dialogs do not hold it.
/// </remarks>
public static class DocumentExporter
{
    private static readonly string[] ModelFormats = [".stp", ".step", ".igs", ".iges", ".stl", ".sat"];
    private static readonly string[] DrawingFormats = [".pdf", ".dwg", ".dxf"];
    private const string FlatPatternFormat = ".dxf";
    private const string DefaultFlatPatternOptions = "AcadVersion=2018";

    public static string Export(Application application, string path, string? documentName, bool overwrite, string? dxfOptions,
        string? configFile = null)
    {
        if (string.IsNullOrWhiteSpace(path) || !System.IO.Path.IsPathRooted(path))
        {
            throw new ArgumentException("Give the full path of the file to write, such as C:\\Exports\\Bracket.stp; its extension picks the format.");
        }

        var document = OpenDocuments.Find(application, documentName);
        var extension = System.IO.Path.GetExtension(path).ToLowerInvariant();
        var kind = PickKind(document, extension);

        if (System.IO.File.Exists(path) && !overwrite)
        {
            throw new InvalidOperationException($"{path} already exists. Ask the user, then call again with overwrite: true to replace it.");
        }

        var folder = System.IO.Path.GetDirectoryName(path);
        if (!string.IsNullOrEmpty(folder))
        {
            System.IO.Directory.CreateDirectory(folder);
        }

        var startedUtc = DateTime.UtcNow.AddSeconds(-1);
        var stopwatch = Stopwatch.StartNew();
        var wasSilent = application.SilentOperation;
        application.SilentOperation = true;

        try
        {
            switch (kind)
            {
                case ExportKind.FlatPattern:
                    var sheetMetal = (SheetMetalComponentDefinition)((PartDocument)document).ComponentDefinition;
                    var options = string.IsNullOrWhiteSpace(dxfOptions) ? DefaultFlatPatternOptions : dxfOptions.TrimStart('?', '&');
                    sheetMetal.DataIO.WriteDataToFile($"FLAT PATTERN DXF?{options}", path);
                    break;
                case ExportKind.Translator:
                    SaveWithTranslator(application, document, path, extension == ".dwg" ? DwgTranslator : DxfTranslator,
                        ConfigurationFile(application, extension, configFile));
                    break;
                default:
                    document.SaveAs(path, true);
                    break;
            }
        }
        finally
        {
            application.SilentOperation = wasSilent;
        }

        var written = WrittenFiles(path, startedUtc);
        if (written.Count == 0)
        {
            throw new InvalidOperationException($"Inventor reported no error, but {path} was not written.");
        }

        var what = kind == ExportKind.FlatPattern ? $"the flat pattern of {document.DisplayName}" : document.DisplayName;
        var seconds = stopwatch.Elapsed.TotalSeconds.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
        var files = string.Join(", ", written.Select(file => $"{file.FullName} ({Math.Ceiling(file.Length / 1024.0):0} KB)"));
        return $"exported {what} as {extension.TrimStart('.').ToUpperInvariant()} in {seconds} s: {files}";
    }

    // Drawing DWG and DXF through SaveAs ask for options in a dialog, even with SilentOperation on; the translator
    // add-ins take them, with their defaults, in a call.
    private const string DwgTranslator = "{C24E3AC2-122E-11D5-8E91-0010B541CD80}";
    private const string DxfTranslator = "{C24E3AC4-122E-11D5-8E91-0010B541CD80}";

    private enum ExportKind
    {
        Copy,
        Translator,
        FlatPattern,
    }

    /// <summary>
    /// The configuration file for a drawing DWG or DXF export: the one given, or else the one Inventor installs in
    /// its Design Data folder (the DWG translator refuses to run without one).
    /// </summary>
    private static string? ConfigurationFile(Application application, string extension, string? configFile)
    {
        if (!string.IsNullOrWhiteSpace(configFile))
        {
            return System.IO.File.Exists(configFile)
                ? configFile
                : throw new InvalidOperationException($"The export configuration file {configFile} does not exist.");
        }

        var designData = application.DesignProjectManager.ActiveDesignProject.DesignDataPath;
        if (string.IsNullOrWhiteSpace(designData))
        {
            designData = application.FileOptions.DesignDataPath;
        }

        var installed = System.IO.Path.Combine(designData ?? "", "DWG-DXF", extension == ".dwg" ? "exportdwg.ini" : "exportdxf.ini");
        return System.IO.File.Exists(installed) ? WithoutTransmittal(installed) : null;
    }

    /// <summary>
    /// A copy of an export configuration that writes the DWG or DXF itself: the installed ones have
    /// "USE TRANSMITTAL=Yes", which packs the output into a zip file instead.
    /// </summary>
    private static string WithoutTransmittal(string configFile)
    {
        var lines = System.IO.File.ReadAllLines(configFile)
            .Select(line => line.StartsWith("USE TRANSMITTAL=", StringComparison.OrdinalIgnoreCase) ? "USE TRANSMITTAL=No" : line);
        var copy = System.IO.Path.Combine(System.IO.Path.GetTempPath(), $"InventorBridge-{System.IO.Path.GetFileName(configFile)}");
        System.IO.File.WriteAllLines(copy, lines);
        return copy;
    }

    private static void SaveWithTranslator(Application application, Document document, string path, string translatorId, string? configFile)
    {
        var translator = (TranslatorAddIn)application.ApplicationAddIns.ItemById[translatorId];
        var objects = application.TransientObjects;
        var context = objects.CreateTranslationContext();
        context.Type = IOMechanismEnum.kFileBrowseIOMechanism;
        var options = objects.CreateNameValueMap();
        // Fills in the translator's default options.
        _ = translator.HasSaveCopyAsOptions[document, context, options];
        if (configFile is not null)
        {
            options.Value["Export_Acad_IniFile"] = configFile;
        }

        var data = objects.CreateDataMedium();
        data.FileName = path;
        translator.SaveCopyAs(document, context, options, data);
    }

    /// <summary>
    /// The file at the path, or the files written next to it since the export began whose name starts the same
    /// (a drawing with several sheets can give one DWG or DXF per sheet).
    /// </summary>
    private static List<System.IO.FileInfo> WrittenFiles(string path, DateTime sinceUtc)
    {
        var folder = System.IO.Path.GetDirectoryName(path) ?? "";
        var stem = System.IO.Path.GetFileNameWithoutExtension(path);
        var extension = System.IO.Path.GetExtension(path);

        return new System.IO.DirectoryInfo(folder)
            .GetFiles($"{stem}*{extension}")
            .Where(file => file.LastWriteTimeUtc >= sinceUtc)
            .OrderBy(file => file.Name, StringComparer.OrdinalIgnoreCase)
            .ToList();
    }

    private static ExportKind PickKind(Document document, string extension)
    {
        switch (document)
        {
            case PartDocument part when extension == FlatPatternFormat:
                if (part.ComponentDefinition is not SheetMetalComponentDefinition sheetMetal)
                {
                    throw new InvalidOperationException($"{document.DisplayName} is not sheet metal: DXF export of a part writes its flat pattern.");
                }

                if (!sheetMetal.HasFlatPattern)
                {
                    throw new InvalidOperationException($"{document.DisplayName} has no flat pattern yet: create it with run_csharp (SheetMetalComponentDefinition.Unfold(), then FlatPattern.ExitEdit()).");
                }

                return ExportKind.FlatPattern;
            case PartDocument or AssemblyDocument when ModelFormats.Contains(extension):
                return ExportKind.Copy;
            case DrawingDocument when extension is ".dwg" or ".dxf":
                return ExportKind.Translator;
            case DrawingDocument when DrawingFormats.Contains(extension):
                return ExportKind.Copy;
            case DrawingDocument:
                throw new InvalidOperationException($"A drawing exports to {string.Join(", ", DrawingFormats)}, not {extension}.");
            case PartDocument or AssemblyDocument:
                throw new InvalidOperationException(
                    $"A part or assembly exports to {string.Join(", ", ModelFormats)} (and a sheet metal part to .dxf, its flat pattern), not {extension}.");
            default:
                throw new InvalidOperationException($"{document.DisplayName} cannot be exported.");
        }
    }
}
