using Inventor;
using InventorBridge.Mcp.ILogic;
using InventorBridge.Mcp.Reading;

namespace InventorBridge.Mcp.Vault;

/// <summary>
/// Reads the vault state of files (version, revision, lifecycle state, category, checkout, local copy) through
/// the Vault connection the user's Inventor already has. Reads only.
/// </summary>
/// <remarks>
/// The Vault add-in keeps the logged-in connection inside Inventor's process, where this server cannot reach.
/// An iLogic rule runs there, so the server sends one (through <see cref="ILogicRules"/>) that takes the
/// connection from the add-in, as Autodesk's own samples and in-house add-ins do, asks the vault and returns
/// one line per file. No password is asked for or stored, and the vault sees the user's own account and rights.
/// The client's status for a file can be stale, so the size of the local file is compared with the vault's too.
/// </remarks>
public static class VaultReader
{
    private const string VaultAddInId = "{48B682BC-42E6-4953-84C5-3D253B52E77B}";

    public static object Read(Application application, IReadOnlyList<string>? paths, string? documentName, bool withReferences, int maxItems)
    {
        var folder = AddInFolder(application);
        var files = FilesToRead(application, paths, documentName, withReferences);
        var truncated = files.Count > maxItems ? $"{maxItems} of {files.Count} files read; pass a larger maxItems" : null;

        var code = RuleTemplate.Replace("{FOLDER}", folder);
        var arguments = new Dictionary<string, object?> { ["Paths"] = string.Join("\n", files.Take(maxItems)) };
        var run = ILogicRules.Execute(application, null, code, "read vault state", arguments, undoable: false);
        var lines = (run.Values.GetValueOrDefault("Result") as string ?? "").Split('\n', StringSplitOptions.RemoveEmptyEntries);

        if (lines.Length > 0 && lines[0] == "NOT_CONNECTED")
        {
            throw new InvalidOperationException(
                "Inventor is not logged in to a vault. Ask the user to log in from Inventor's Vault tab, then call again.");
        }

        object? connection = null;
        var results = new List<object>();
        foreach (var line in lines)
        {
            var cells = line.Split('\t');
            switch (cells[0])
            {
                case "CONNECTION":
                    connection = new { server = cells[1], vault = cells[2], user = cells[3], workingFolder = cells[4] };
                    break;
                case "OUTSIDE":
                    results.Add(new { file = cells[1], inVault = (bool?)null, note = "outside the vault's working folder" });
                    break;
                case "NOT_IN_VAULT":
                    results.Add(new { file = cells[1], vaultPath = cells[2], inVault = false });
                    break;
                case "FILE":
                    results.Add(Describe(cells));
                    break;
            }
        }

        return new
        {
            connection,
            files = results,
            truncated,
            elapsedSeconds = run.ElapsedSeconds,
            note = """
                Read through the user's own Vault connection in Inventor. vault_change checks out, checks in and
                changes states, when the user asks for it.
                """,
        };
    }

    private static object Describe(string[] cells)
    {
        // FILE, local, vault path, version, revision, state, category, checked out by, checkout state,
        // version state, local edits state, vault date, vault size, local size.
        var vaultSize = long.TryParse(cells[12], out var size) ? size : -1;
        var localSize = long.TryParse(cells[13], out var local) ? local : -1;
        string localCopy;
        if (localSize < 0)
        {
            localCopy = "missing: get it from the vault";
        }
        else if (cells[10] == "HasLocalEdits" || (vaultSize >= 0 && localSize != vaultSize))
        {
            localCopy = "differs from the vault's latest version (edited here, or the vault client has not noticed yet)";
        }
        else if (cells[9] != "MatchesLatestVaultVersion")
        {
            localCopy = "older than the vault's latest version: get the latest";
        }
        else
        {
            localCopy = "same as the vault's latest version";
        }

        return new
        {
            file = cells[1],
            vaultPath = cells[2],
            inVault = true,
            version = int.TryParse(cells[3], out var version) ? version : (int?)null,
            revision = cells[4],
            state = cells[5],
            category = cells[6],
            checkedOutBy = cells[7].Length == 0 ? null : cells[7],
            checkoutState = cells[8],
            localCopy,
            vaultModified = cells[11],
            vaultSizeBytes = vaultSize,
            localSizeBytes = localSize,
        };
    }

    /// <summary>The files to read: the given paths, or a document and, with references, everything it references.</summary>
    private static List<string> FilesToRead(Application application, IReadOnlyList<string>? paths, string? documentName, bool withReferences)
    {
        if (paths is { Count: > 0 })
        {
            return paths.Select(path => path.Trim()).Where(path => path.Length > 0).Distinct(StringComparer.OrdinalIgnoreCase).ToList();
        }

        var document = OpenDocuments.Find(application, documentName);
        var files = new List<string>();
        if (!string.IsNullOrEmpty(document.FullFileName))
        {
            files.Add(document.FullFileName);
        }

        if (withReferences)
        {
            foreach (Document referenced in document.AllReferencedDocuments)
            {
                if (!string.IsNullOrEmpty(referenced.FullFileName))
                {
                    files.Add(referenced.FullFileName);
                }
            }
        }

        return files.Distinct(StringComparer.OrdinalIgnoreCase).ToList();
    }

    /// <summary>The folder of the Vault add-in's assemblies, which the rule references.</summary>
    internal static string AddInFolder(Application application)
    {
        ApplicationAddIn addIn;
        try
        {
            addIn = application.ApplicationAddIns.ItemById[VaultAddInId];
        }
        catch (ArgumentException)
        {
            throw new InvalidOperationException("The Vault add-in is not installed in this Inventor.");
        }

        if (!addIn.Activated)
        {
            throw new InvalidOperationException("The Vault add-in is not loaded in Inventor: ask the user to load it (Tools > Add-Ins).");
        }

        var year = application.SoftwareVersion.Major + 1996;
        var plugins = System.Environment.GetFolderPath(System.Environment.SpecialFolder.CommonApplicationData);
        var folder = System.IO.Path.Combine(plugins, "Autodesk", "ApplicationPlugins", $"VaultInventor{year}.bundle", "Contents");
        if (!System.IO.File.Exists(System.IO.Path.Combine(folder, "Connectivity.InventorAddin.EdmAddin.dll")))
        {
            throw new InvalidOperationException($"The Vault add-in's assemblies were not found in {folder}.");
        }

        return folder;
    }

    private const string RuleTemplate = """
        AddReference "{FOLDER}\Connectivity.InventorAddin.EdmAddin.dll"
        AddReference "{FOLDER}\Autodesk.DataManagement.Client.Framework.Vault.dll"
        AddReference "{FOLDER}\Autodesk.DataManagement.Client.Framework.dll"
        AddReference "{FOLDER}\Autodesk.Connectivity.WebServices.dll"
        Imports VDF = Autodesk.DataManagement.Client.Framework
        Sub Main()
            Dim conn As VDF.Vault.Currency.Connections.Connection = Connectivity.InventorAddin.EdmAddin.EdmSecurity.Instance.VaultConnection
            If conn Is Nothing Then
                RuleArguments.Arguments.Value("Result") = "NOT_CONNECTED"
                RuleArguments.Arguments.Value("InventorBridgeFinished") = True
                Exit Sub
            End If
            Dim root As String = conn.WorkingFoldersManager.GetWorkingFolder("$").FullPath.TrimEnd("\"c)
            Dim statusDef As VDF.Vault.Currency.Properties.PropertyDefinition = conn.PropertyManager.GetPropertyDefinitionBySystemName(VDF.Vault.Currency.Properties.PropertyDefinitionIds.Client.VaultStatus)
            Dim users As New Dictionary(Of Long, String)
            Dim lines As New List(Of String)
            lines.Add("CONNECTION" & vbTab & conn.Server & vbTab & conn.Vault & vbTab & conn.UserName & vbTab & root)
            For Each localPath As String In CStr(RuleArguments.Arguments.Value("Paths")).Split(New String() {vbLf}, StringSplitOptions.RemoveEmptyEntries)
                localPath = localPath.Trim()
                If Not localPath.StartsWith(root & "\", StringComparison.OrdinalIgnoreCase) Then
                    lines.Add("OUTSIDE" & vbTab & localPath)
                    Continue For
                End If
                Dim vaultPath As String = "$" & localPath.Substring(root.Length).Replace("\", "/")
                Dim found() As Autodesk.Connectivity.WebServices.File = conn.WebServiceManager.DocumentService.FindLatestFilesByPaths(New String() {vaultPath})
                If found Is Nothing OrElse found.Length = 0 OrElse String.IsNullOrEmpty(found(0).Name) Then
                    lines.Add("NOT_IN_VAULT" & vbTab & localPath & vbTab & vaultPath)
                    Continue For
                End If
                Dim f As Autodesk.Connectivity.WebServices.File = found(0)
                Dim iteration As New VDF.Vault.Currency.Entities.FileIteration(conn, f)
                Dim status As VDF.Vault.Currency.Properties.EntityStatusImageInfo = conn.PropertyManager.GetPropertyValue(iteration, statusDef, Nothing)
                Dim checkedOutBy As String = ""
                If f.CheckedOut Then
                    If Not users.ContainsKey(f.CkOutUserId) Then
                        Try
                            users(f.CkOutUserId) = conn.WebServiceManager.AdminService.GetUserByUserId(f.CkOutUserId).Name
                        Catch
                            users(f.CkOutUserId) = "user " & f.CkOutUserId
                        End Try
                    End If
                    checkedOutBy = users(f.CkOutUserId) & " on " & f.CkOutMach
                End If
                Dim localSize As String = If(System.IO.File.Exists(localPath), CStr(New System.IO.FileInfo(localPath).Length), "-1")
                lines.Add(String.Join(vbTab, New String() {"FILE", localPath, vaultPath, CStr(f.VerNum), If(f.FileRev Is Nothing, "", f.FileRev.Label), _
                    If(f.FileLfCyc Is Nothing, "", f.FileLfCyc.LfCycStateName), If(f.Cat Is Nothing, "", f.Cat.CatName), checkedOutBy, _
                    status.Status.CheckoutState.ToString(), status.Status.VersionState.ToString(), status.Status.LocalEditsState.ToString(), _
                    f.ModDate.ToString("yyyy-MM-dd HH:mm"), CStr(f.FileSize), localSize}))
            Next
            RuleArguments.Arguments.Value("Result") = String.Join(vbLf, lines)
        End Sub
        """;
}
