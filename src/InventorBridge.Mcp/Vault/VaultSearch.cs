using Inventor;
using InventorBridge.Mcp.ILogic;

namespace InventorBridge.Mcp.Vault;

/// <summary>
/// Finds files and folders in Autodesk Vault by name, optionally under one vault folder, through the user's own
/// Vault connection in Inventor. Reads only.
/// </summary>
/// <remarks>
/// Runs as an iLogic rule inside Inventor's process, like <see cref="VaultReader"/>. Each name is one search on the
/// vault's name property: an exact match, or with * and ? a pattern. Vault's own "contains" search is loose
/// ('*.iam' also finds files with 'iam' elsewhere in the name), so patterns are matched again here. Only the latest
/// version of each file is returned, with its vault path and where it lands in the working folder.
/// </remarks>
public static class VaultSearch
{
    public static object Find(Application application, IReadOnlyList<string>? names, IReadOnlyList<string>? folders,
        string? under, int maxPerName)
    {
        var fileNames = Clean(names);
        var folderNames = Clean(folders);
        if (fileNames.Count == 0 && folderNames.Count == 0)
        {
            throw new ArgumentException(
                "Give file names (names, such as '10031581.ipt' or '1003158*.ipt') or folder names (folders, such as 'Garantias' or '*COOPAN*').");
        }

        var vaultFolder = under?.Trim().Replace('\\', '/').TrimEnd('/');
        if (vaultFolder is { Length: > 0 } && !vaultFolder.StartsWith('$'))
        {
            throw new ArgumentException($"'{under}' is not a vault folder: give it as Vault names it, such as '$/Engenharia/Produto'.");
        }

        var arguments = new Dictionary<string, object?>
        {
            ["Names"] = string.Join("\n", fileNames),
            ["FolderNames"] = string.Join("\n", folderNames),
            ["Under"] = vaultFolder ?? "",
            ["Max"] = Math.Max(1, maxPerName),
        };
        var code = RuleTemplate.Replace("{FOLDER}", VaultReader.AddInFolder(application));
        var run = ILogicRules.Execute(application, null, code, "search vault", arguments, undoable: false);
        var lines = (run.Values.GetValueOrDefault("Result") as string ?? "").Split('\n', StringSplitOptions.RemoveEmptyEntries);

        if (lines.Length > 0 && lines[0] == "NOT_CONNECTED")
        {
            throw new InvalidOperationException(
                "Inventor is not logged in to a vault. Ask the user to log in from Inventor's Vault tab, then call again.");
        }

        if (lines.Length > 0 && lines[0].StartsWith("NO_FOLDER\t", StringComparison.Ordinal))
        {
            throw new InvalidOperationException($"The vault has no folder {lines[0][10..]}. Give a folder as Vault names it, such as '$/Engenharia/Produto'.");
        }

        object? connection = null;
        var files = new Dictionary<string, List<object>>(StringComparer.OrdinalIgnoreCase);
        var foundFolders = new Dictionary<string, List<object>>(StringComparer.OrdinalIgnoreCase);
        var more = new List<string>();
        foreach (var cells in lines.Select(line => line.Split('\t')))
        {
            switch (cells[0])
            {
                case "CONNECTION":
                    connection = new { server = cells[1], vault = cells[2], user = cells[3], workingFolder = cells[4] };
                    break;
                case "MORE":
                    more.Add($"{cells[1]} '{cells[2]}': more than {cells[3]} found; pass a larger maxPerName or a narrower name or folder");
                    break;
                case "FOLDER":
                    // FOLDER, searched name, vault path, local path, local folder exists.
                    Add(foundFolders, cells[1], new { vaultPath = cells[2], localPath = cells[3], localFolderExists = cells[4] == "1" });
                    break;
                case "FILE":
                    // FILE, searched name, vault path, local path, version, revision, state, category, checked out by,
                    // vault date, vault size, local size.
                    Add(files, cells[1], new
                    {
                        vaultPath = cells[2],
                        localPath = cells[3],
                        version = int.TryParse(cells[4], out var version) ? version : (int?)null,
                        revision = cells[5],
                        state = cells[6],
                        category = cells[7],
                        checkedOutBy = cells[8].Length == 0 ? null : cells[8],
                        vaultModified = cells[9],
                        vaultSizeBytes = long.TryParse(cells[10], out var size) ? size : -1,
                        localCopy = cells[11] == "-1" ? "not in the working folder" : $"present, {cells[11]} bytes",
                    });
                    break;
            }
        }

        return new
        {
            connection,
            under = vaultFolder is { Length: > 0 } ? vaultFolder : "$ (whole vault)",
            files = fileNames.Count == 0 ? null : fileNames.Select(name => new { name, matches = files.GetValueOrDefault(name) ?? [] }),
            filesNotFound = fileNames.Count == 0 ? null : fileNames.Where(name => !files.ContainsKey(name)).ToList(),
            folders = folderNames.Count == 0 ? null : folderNames.Select(name => new { name, matches = foundFolders.GetValueOrDefault(name) ?? [] }),
            foldersNotFound = folderNames.Count == 0 ? null : folderNames.Where(name => !foundFolders.ContainsKey(name)).ToList(),
            truncated = more.Count > 0 ? more : null,
            elapsedSeconds = run.ElapsedSeconds,
            note = """
                Latest versions only, read through the user's own Vault connection. A file name found more than once
                means the vault holds same-named files in different folders. vault_info reads a file's full state;
                vault_change get_latest downloads it.
                """,
        };
    }

    private static List<string> Clean(IReadOnlyList<string>? names) =>
        (names ?? []).Select(name => name.Trim()).Where(name => name.Length > 0).Distinct(StringComparer.OrdinalIgnoreCase).ToList();

    private static void Add(Dictionary<string, List<object>> found, string name, object match)
    {
        if (!found.TryGetValue(name, out var list))
        {
            found[name] = list = [];
        }

        list.Add(match);
    }

    private const string RuleTemplate = """
        AddReference "{FOLDER}\Connectivity.InventorAddin.EdmAddin.dll"
        AddReference "{FOLDER}\Autodesk.DataManagement.Client.Framework.Vault.dll"
        AddReference "{FOLDER}\Autodesk.DataManagement.Client.Framework.dll"
        AddReference "{FOLDER}\Autodesk.Connectivity.WebServices.dll"
        Imports VDF = Autodesk.DataManagement.Client.Framework
        Imports WS = Autodesk.Connectivity.WebServices
        Imports System.Text.RegularExpressions
        Sub Main()
            Dim conn As VDF.Vault.Currency.Connections.Connection = Connectivity.InventorAddin.EdmAddin.EdmSecurity.Instance.VaultConnection
            If conn Is Nothing Then
                RuleArguments.Arguments.Value("Result") = "NOT_CONNECTED"
                RuleArguments.Arguments.Value("InventorBridgeFinished") = True
                Exit Sub
            End If
            Dim docs As WS.DocumentService = conn.WebServiceManager.DocumentService
            Dim root As String = conn.WorkingFoldersManager.GetWorkingFolder("$").FullPath.TrimEnd("\"c)
            Dim lines As New List(Of String)
            lines.Add("CONNECTION" & vbTab & conn.Server & vbTab & conn.Vault & vbTab & conn.UserName & vbTab & root)

            Dim underIds() As Long = Nothing
            Dim underPath As String = CStr(RuleArguments.Arguments.Value("Under"))
            If underPath.Length > 0 Then
                Dim under As WS.Folder = Nothing
                Try
                    under = docs.GetFolderByPath(underPath)
                Catch
                End Try
                If under Is Nothing Then
                    RuleArguments.Arguments.Value("Result") = "NO_FOLDER" & vbTab & underPath
                    RuleArguments.Arguments.Value("InventorBridgeFinished") = True
                    Exit Sub
                End If
                underIds = New Long() {under.Id}
            End If

            Dim maxPerName As Integer = CInt(RuleArguments.Arguments.Value("Max"))
            Dim folderPaths As New Dictionary(Of Long, String)
            Dim users As New Dictionary(Of Long, String)

            Dim fileNameProp As Long = NameProperty(conn, "FILE", "ClientFileName")
            For Each name As String In Split(RuleArguments.Arguments.Value("Names"))
                Dim matcher As Regex = Wildcard(name)
                Dim files As New List(Of WS.File)
                Dim bookmark As String = Nothing
                Dim status As WS.SrchStatus = Nothing
                Dim more As Boolean = False
                Do
                    Dim page() As WS.File = docs.FindFilesBySearchConditions(New WS.SrchCond() {Condition(fileNameProp, name)}, Nothing, underIds, True, True, bookmark, status)
                    If page Is Nothing OrElse page.Length = 0 Then Exit Do
                    For Each f As WS.File In page
                        If matcher.IsMatch(f.Name) Then
                            If files.Count >= maxPerName Then more = True : Exit For
                            files.Add(f)
                        End If
                    Next
                Loop While Not more AndAlso Not String.IsNullOrEmpty(bookmark) AndAlso status IsNot Nothing AndAlso status.TotalHits > 0
                If more Then lines.Add("MORE" & vbTab & "file" & vbTab & name & vbTab & CStr(maxPerName))
                For Each f As WS.File In files
                    If Not folderPaths.ContainsKey(f.FolderId) Then folderPaths(f.FolderId) = docs.GetFolderById(f.FolderId).FullName
                    Dim vaultPath As String = folderPaths(f.FolderId) & "/" & f.Name
                    Dim localPath As String = root & vaultPath.Substring(1).Replace("/", "\")
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
                    lines.Add(String.Join(vbTab, New String() {"FILE", name, vaultPath, localPath, CStr(f.VerNum), If(f.FileRev Is Nothing, "", f.FileRev.Label), _
                        If(f.FileLfCyc Is Nothing, "", f.FileLfCyc.LfCycStateName), If(f.Cat Is Nothing, "", f.Cat.CatName), checkedOutBy, _
                        f.ModDate.ToString("yyyy-MM-dd HH:mm"), CStr(f.FileSize), localSize}))
                Next
            Next

            Dim folderNameProp As Long = NameProperty(conn, "FLDR", "Name")
            For Each name As String In Split(RuleArguments.Arguments.Value("FolderNames"))
                Dim matcher As Regex = Wildcard(name)
                Dim count As Integer = 0
                Dim bookmark As String = Nothing
                Dim status As WS.SrchStatus = Nothing
                Dim more As Boolean = False
                Do
                    Dim page() As WS.Folder = docs.FindFoldersBySearchConditions(New WS.SrchCond() {Condition(folderNameProp, name)}, Nothing, underIds, True, bookmark, status)
                    If page Is Nothing OrElse page.Length = 0 Then Exit Do
                    For Each fo As WS.Folder In page
                        If matcher.IsMatch(fo.Name) Then
                            If count >= maxPerName Then more = True : Exit For
                            count += 1
                            Dim localPath As String = root & fo.FullName.Substring(1).Replace("/", "\")
                            lines.Add(String.Join(vbTab, New String() {"FOLDER", name, fo.FullName, localPath, If(System.IO.Directory.Exists(localPath), "1", "0")}))
                        End If
                    Next
                Loop While Not more AndAlso Not String.IsNullOrEmpty(bookmark) AndAlso status IsNot Nothing AndAlso status.TotalHits > 0
                If more Then lines.Add("MORE" & vbTab & "folder" & vbTab & name & vbTab & CStr(maxPerName))
            Next
            RuleArguments.Arguments.Value("Result") = String.Join(vbLf, lines)
        End Sub

        Function Split(value As Object) As String()
            Return CStr(value).Split(New String() {vbLf}, StringSplitOptions.RemoveEmptyEntries)
        End Function

        Function NameProperty(conn As VDF.Vault.Currency.Connections.Connection, entityClass As String, sysName As String) As Long
            For Each def As WS.PropDef In conn.WebServiceManager.PropertyService.GetPropertyDefinitionsByEntityClassId(entityClass)
                If def.SysName = sysName Then Return def.Id
            Next
            Throw New System.Exception("The vault has no " & sysName & " property for " & entityClass)
        End Function

        ' Exact names use Vault's "is exactly" (3); patterns use "contains" (1) and are matched again by Wildcard.
        Function Condition(propId As Long, name As String) As WS.SrchCond
            Dim pattern As Boolean = name.Contains("*") OrElse name.Contains("?")
            Dim cond As New WS.SrchCond()
            cond.PropDefId = propId
            cond.PropTyp = WS.PropertySearchType.SingleProperty
            cond.SrchOper = If(pattern, 1, 3)
            cond.SrchTxt = name
            cond.SrchRule = WS.SearchRuleType.Must
            Return cond
        End Function

        Function Wildcard(name As String) As Regex
            Return New Regex("^" & Regex.Escape(name).Replace("\*", ".*").Replace("\?", ".") & "$", RegexOptions.IgnoreCase)
        End Function
        """;
}
