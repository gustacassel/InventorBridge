using Inventor;
using InventorBridge.Mcp.ILogic;
using InventorBridge.Mcp.Reading;

namespace InventorBridge.Mcp.Vault;

/// <summary>
/// Changes files in Autodesk Vault through the user's own Vault connection in Inventor: check out, check in
/// (adding files the vault does not have yet), undo a check-out, get the latest version, change the lifecycle
/// state. Like <see cref="VaultReader"/>, the work runs in an iLogic rule, inside Inventor's process.
/// </summary>
/// <remarks>
/// A check-in sends the file's references as read from Inventor, so the vault keeps an assembly's or a drawing's
/// dependencies; references the vault does not have must be checked in first (withReferences does it, children
/// first). Attachments the vault already has are kept. The vault's BOM data is not sent, as the Vault add-in's own
/// check-in does. Files the vault rewrites (a download, an undone check-out, a state change, which writes a new
/// version) are reopened in Inventor when they were open, so Inventor does not keep showing the old copy.
/// </remarks>
public static class VaultWriter
{
    public static readonly string[] Actions = ["checkout", "checkin", "undo_checkout", "get_latest", "set_state"];

    public static object Change(Application application, string action, IReadOnlyList<string>? paths, string? documentName,
        bool withReferences, string? comment, string? state, string? lifecycle)
    {
        if (!Actions.Contains(action))
        {
            throw new ArgumentException($"Unknown action '{action}'. Use {string.Join(", ", Actions)}.");
        }

        if (action == "checkin" && string.IsNullOrWhiteSpace(comment))
        {
            throw new ArgumentException("A check-in needs a comment saying what changed.");
        }

        if (action == "set_state" && string.IsNullOrWhiteSpace(state))
        {
            throw new ArgumentException("Give the lifecycle state to move to, such as 'Released', as Vault names it.");
        }

        var opened = new List<Document>();
        try
        {
            var files = FilesToChange(application, action, paths, documentName, withReferences, opened);
            CheckInventorCopies(application, action, files);

            var entries = files.Select(file => $"{file.Path}\t{string.Join("|", file.References)}");
            var arguments = new Dictionary<string, object?>
            {
                ["Action"] = action,
                ["Files"] = string.Join("\n", entries),
                ["Comment"] = comment ?? "",
                ["State"] = state ?? "",
                ["Lifecycle"] = lifecycle ?? "",
            };

            var code = RuleTemplate.Replace("{FOLDER}", VaultReader.AddInFolder(application));
            var stamps = files.ToDictionary(file => file.Path, file => LastWrite(file.Path), StringComparer.OrdinalIgnoreCase);
            var run = ILogicRules.Execute(application, null, code, $"vault {action}", arguments, undoable: false);
            var lines = (run.Values.GetValueOrDefault("Result") as string ?? "").Split('\n', StringSplitOptions.RemoveEmptyEntries);

            if (lines.Length > 0 && lines[0] == "NOT_CONNECTED")
            {
                throw new InvalidOperationException(
                    "Inventor is not logged in to a vault. Ask the user to log in from Inventor's Vault tab, then call again.");
            }

            var results = new List<object>();
            object? connection = null;
            foreach (var cells in lines.Select(line => line.Split('\t')))
            {
                if (cells[0] == "CONNECTION")
                {
                    connection = new { server = cells[1], vault = cells[2], user = cells[3] };
                    continue;
                }

                // RESULT, local path, outcome, version, state, message
                var path = cells[1];
                var rewritten = stamps.TryGetValue(path, out var before) && LastWrite(path) != before;
                results.Add(new
                {
                    file = path,
                    outcome = cells[2],
                    version = int.TryParse(cells[3], out var version) ? version : (int?)null,
                    state = cells[4].Length == 0 ? null : cells[4],
                    message = cells[5].Length == 0 ? null : cells[5],
                    inventor = rewritten ? Reopen(application, path) : null,
                });
            }

            RefreshVaultBrowser(application);
            return new
            {
                connection,
                action,
                files = results,
                elapsedSeconds = run.ElapsedSeconds,
                note = Note(action),
            };
        }
        finally
        {
            foreach (var document in opened)
            {
                document.Close(true);
            }
        }
    }

    private static string Note(string action)
    {
        return action switch
        {
            "checkin" => """
                The vault's BOM data for the files was not updated (the Vault add-in's check-in does that); items and
                BOM views in Vault may need the user's check-in from Inventor.
                """,
            "set_state" => """
                A state change writes a new version in the vault; the local copy was updated to it. Some states make
                files read-only or restrict who can check them out.
                """,
            _ => "Done through the user's own Vault connection in Inventor, with their rights.",
        };
    }

    private sealed record VaultFile(string Path, IReadOnlyList<string> References);

    /// <summary>
    /// The files to change, children before their parents. For a check-in, each with the files it references as
    /// Inventor reads them: from the open document, or from the file opened invisibly for the call.
    /// </summary>
    private static List<VaultFile> FilesToChange(Application application, string action, IReadOnlyList<string>? paths,
        string? documentName, bool withReferences, List<Document> opened)
    {
        var roots = new List<Document>();
        var plainPaths = new List<string>();
        if (paths is { Count: > 0 })
        {
            foreach (var path in paths.Select(path => path.Trim()).Where(path => path.Length > 0).Distinct(StringComparer.OrdinalIgnoreCase))
            {
                if (action == "checkin" || withReferences)
                {
                    roots.Add(FindOrOpen(application, path, opened));
                }
                else
                {
                    plainPaths.Add(path);
                }
            }
        }
        else
        {
            roots.Add(OpenDocuments.Find(application, documentName));
        }

        var ordered = new List<VaultFile>();
        var seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        foreach (var root in roots)
        {
            Visit(root, withReferences, ordered, seen);
        }

        foreach (var path in plainPaths.Where(seen.Add))
        {
            ordered.Add(new VaultFile(path, []));
        }

        return ordered;
    }

    private static void Visit(Document document, bool withReferences, List<VaultFile> ordered, HashSet<string> seen)
    {
        if (string.IsNullOrEmpty(document.FullFileName) || seen.Contains(document.FullFileName))
        {
            return;
        }

        seen.Add(document.FullFileName);
        var references = new List<string>();
        foreach (FileDescriptor descriptor in document.File.ReferencedFileDescriptors)
        {
            if (descriptor.ReferenceMissing)
            {
                throw new InvalidOperationException(
                    $"{document.DisplayName} references {descriptor.FullFileName}, which Inventor cannot find. Resolve it first.");
            }

            references.Add(descriptor.FullFileName);
        }

        if (withReferences)
        {
            foreach (Document referenced in document.ReferencedDocuments)
            {
                Visit(referenced, withReferences, ordered, seen);
            }
        }

        ordered.Add(new VaultFile(document.FullFileName, references.Distinct(StringComparer.OrdinalIgnoreCase).ToList()));
    }

    private static Document FindOrOpen(Application application, string path, List<Document> opened)
    {
        foreach (Document candidate in application.Documents)
        {
            if (string.Equals(candidate.FullFileName, path, StringComparison.OrdinalIgnoreCase))
            {
                return candidate;
            }
        }

        if (!System.IO.File.Exists(path))
        {
            throw new InvalidOperationException($"{path} does not exist on this computer: get it from the vault first (get_latest).");
        }

        var document = application.Documents.Open(path, false);
        opened.Add(document);
        return document;
    }

    /// <summary>Refuses to check in unsaved changes, or to overwrite a local copy with unsaved changes in Inventor.</summary>
    private static void CheckInventorCopies(Application application, string action, List<VaultFile> files)
    {
        var dirty = new List<string>();
        foreach (Document document in application.Documents)
        {
            if (document.Dirty && files.Any(file => string.Equals(file.Path, document.FullFileName, StringComparison.OrdinalIgnoreCase)))
            {
                dirty.Add(document.DisplayName);
            }
        }

        if (dirty.Count == 0 || action == "set_state")
        {
            return;
        }

        var what = action == "checkin"
            ? "has unsaved changes in Inventor: save it first, so the check-in sends them"
            : "has unsaved changes in Inventor that this would overwrite: save or close it first";
        throw new InvalidOperationException($"{string.Join(", ", dirty)} {what}.");
    }

    /// <summary>
    /// Runs the Vault add-in's Refresh command, so the Vault browser in Inventor shows the new states and check-outs:
    /// the add-in does not notice changes made through the connection.
    /// </summary>
    private static void RefreshVaultBrowser(Application application)
    {
        try
        {
            application.CommandManager.ControlDefinitions["VaultRefresh"].Execute2(true);
        }
        catch (Exception exception) when (exception is ArgumentException or System.Runtime.InteropServices.COMException)
        {
            // An older add-in without the command: the browser catches up on the user's next refresh.
        }
    }

    private static DateTime LastWrite(string path)
    {
        return System.IO.File.Exists(path) ? System.IO.File.GetLastWriteTimeUtc(path) : DateTime.MinValue;
    }

    /// <summary>Reopens a document whose file the vault rewrote, so Inventor shows the new copy.</summary>
    private static string? Reopen(Application application, string path)
    {
        Document? document = null;
        foreach (Document candidate in application.Documents)
        {
            if (string.Equals(candidate.FullFileName, path, StringComparison.OrdinalIgnoreCase))
            {
                document = candidate;
            }
        }

        // Not open, or loaded without a window (a reference, or opened for this call): nothing shows the old copy.
        if (document is null || document.Views.Count == 0)
        {
            return null;
        }

        foreach (Document other in application.Documents)
        {
            if (!ReferenceEquals(other, document) && other.ReferencedDocuments.Cast<Document>().Any(referenced => ReferenceEquals(referenced, document)))
            {
                return $"still loaded in Inventor as a reference of {other.DisplayName}: close and reopen that to see the new copy";
            }
        }

        var wasActive = ReferenceEquals(application.ActiveDocument, document);
        document.Close(true);
        var reopened = application.Documents.Open(path, true);
        if (wasActive)
        {
            reopened.Activate();
        }

        return "reopened in Inventor with the new copy";
    }

    private const string RuleTemplate = """
        AddReference "{FOLDER}\Connectivity.InventorAddin.EdmAddin.dll"
        AddReference "{FOLDER}\Autodesk.DataManagement.Client.Framework.Vault.dll"
        AddReference "{FOLDER}\Autodesk.DataManagement.Client.Framework.dll"
        AddReference "{FOLDER}\Autodesk.Connectivity.WebServices.dll"
        Imports VDF = Autodesk.DataManagement.Client.Framework
        Imports ACW = Autodesk.Connectivity.WebServices
        Sub Main()
            Dim conn As VDF.Vault.Currency.Connections.Connection = Connectivity.InventorAddin.EdmAddin.EdmSecurity.Instance.VaultConnection
            If conn Is Nothing Then
                RuleArguments.Arguments.Value("Result") = "NOT_CONNECTED"
                Exit Sub
            End If
            Dim root As String = conn.WorkingFoldersManager.GetWorkingFolder("$").FullPath.TrimEnd("\"c)
            Dim action As String = CStr(RuleArguments.Arguments.Value("Action"))
            Dim lines As New List(Of String)
            lines.Add("CONNECTION" & vbTab & conn.Server & vbTab & conn.Vault & vbTab & conn.UserName)
            For Each entry As String In CStr(RuleArguments.Arguments.Value("Files")).Split(New String() {vbLf}, StringSplitOptions.RemoveEmptyEntries)
                Dim cells() As String = entry.Split(vbTab)
                Dim localPath As String = cells(0)
                Dim refs() As String = If(cells.Length > 1 AndAlso cells(1).Length > 0, cells(1).Split("|"c), New String() {})
                Try
                    lines.Add(Handle(conn, root, action, localPath, refs))
                Catch ex As Exception
                    lines.Add(ResultLine(localPath, "failed", Nothing, ex.Message))
                End Try
            Next
            RuleArguments.Arguments.Value("Result") = String.Join(vbLf, lines)
        End Sub

        Function ResultLine(localPath As String, outcome As String, file As ACW.File, message As String) As String
            Dim version As String = "", state As String = ""
            If file IsNot Nothing Then
                version = CStr(file.VerNum)
                If file.FileLfCyc IsNot Nothing Then state = file.FileLfCyc.LfCycStateName
            End If
            Return String.Join(vbTab, New String() {"RESULT", localPath, outcome, version, state, If(message, "").Replace(vbCr, " ").Replace(vbLf, " ").Replace(vbTab, " ")})
        End Function

        Function VaultPathOf(root As String, localPath As String) As String
            Return "$" & localPath.Substring(root.Length).Replace("\", "/")
        End Function

        Function Latest(conn As VDF.Vault.Currency.Connections.Connection, vaultPath As String) As ACW.File
            Dim found() As ACW.File = conn.WebServiceManager.DocumentService.FindLatestFilesByPaths(New String() {vaultPath})
            If found Is Nothing OrElse found.Length = 0 OrElse String.IsNullOrEmpty(found(0).Name) Then Return Nothing
            Return found(0)
        End Function

        Function CheckedOutByOther(conn As VDF.Vault.Currency.Connections.Connection, file As ACW.File) As Boolean
            Return file.CheckedOut AndAlso file.CkOutUserId <> conn.UserID
        End Function

        Function Acquire(conn As VDF.Vault.Currency.Connections.Connection, file As ACW.File, options As VDF.Vault.Settings.AcquireFilesSettings.AcquisitionOption) As String
            Dim settings As New VDF.Vault.Settings.AcquireFilesSettings(conn, False)
            settings.AddFileToAcquire(New VDF.Vault.Currency.Entities.FileIteration(conn, file), options)
            Dim problems As New List(Of String)
            For Each result In conn.FileManager.AcquireFiles(settings).FileResults
                If result.Exception IsNot Nothing Then problems.Add(result.File.EntityName & ": " & result.Exception.Message)
                If result.Status.ToString() <> "Success" Then problems.Add(result.File.EntityName & ": " & result.Status.ToString())
            Next
            Return String.Join("; ", problems)
        End Function

        ' The file's references as dependencies, keeping the vault's reference ids where it had them, and its attachments.
        Function Associations(conn As VDF.Vault.Currency.Connections.Connection, root As String, file As ACW.File, refs() As String) As ACW.FileAssocParam()
            Dim ws = conn.WebServiceManager
            Dim result As New List(Of ACW.FileAssocParam)
            Dim existing As New List(Of ACW.FileAssocLite)
            If file IsNot Nothing Then
                Dim lites() As ACW.FileAssocLite = ws.DocumentService.GetFileAssociationLitesByIds(New Long() {file.Id}, ACW.FileAssocAlg.Actual, _
                    ACW.FileAssociationTypeEnum.None, False, ACW.FileAssociationTypeEnum.All, False, False, False, True)
                If lites IsNot Nothing Then existing.AddRange(lites.Where(Function(lite) lite.ParFileId = file.Id))
            End If
            For Each lite In existing.Where(Function(candidate) candidate.Typ = ACW.AssociationType.Attachment)
                result.Add(New ACW.FileAssocParam With {.CldFileId = lite.CldFileId, .RefId = lite.RefId, .Source = lite.Source, .Typ = lite.Typ, .ExpectedVaultPath = lite.ExpectedVaultPath})
            Next
            For Each reference As String In refs
                If Not reference.StartsWith(root & "\", StringComparison.OrdinalIgnoreCase) Then
                    Throw New Exception("it references " & reference & ", outside the vault's working folder; move it into the vault first")
                End If
                Dim childPath As String = VaultPathOf(root, reference)
                Dim child As ACW.File = Latest(conn, childPath)
                If child Is Nothing Then Throw New Exception("it references " & reference & ", which is not in the vault yet; check it in first (withReferences)")
                Dim previous As ACW.FileAssocLite = existing.FirstOrDefault(Function(candidate) candidate.Typ = ACW.AssociationType.Dependency AndAlso candidate.CldFileId <> 0 AndAlso _
                    ws.DocumentService.GetFileById(candidate.CldFileId).MasterId = child.MasterId)
                result.Add(New ACW.FileAssocParam With {.CldFileId = child.Id, .RefId = If(previous Is Nothing, Nothing, previous.RefId), _
                    .Source = If(previous Is Nothing, Nothing, previous.Source), .Typ = ACW.AssociationType.Dependency, .ExpectedVaultPath = childPath})
            Next
            Return result.ToArray()
        End Function

        Function FolderFor(conn As VDF.Vault.Currency.Connections.Connection, vaultFolderPath As String) As ACW.Folder
            Dim ws = conn.WebServiceManager
            Dim folder As ACW.Folder = ws.DocumentService.GetFolderRoot()
            If vaultFolderPath.Length <= 2 Then Return folder
            For Each name As String In vaultFolderPath.Substring(2).Split("/"c)
                Dim child As ACW.Folder = Nothing
                Dim children() As ACW.Folder = ws.DocumentService.GetFoldersByParentId(folder.Id, False)
                If children IsNot Nothing Then child = children.FirstOrDefault(Function(candidate) String.Equals(candidate.Name, name, StringComparison.OrdinalIgnoreCase))
                If child Is Nothing Then child = ws.DocumentService.AddFolder(name, folder.Id, False)
                folder = child
            Next
            Return folder
        End Function

        Function Handle(conn As VDF.Vault.Currency.Connections.Connection, root As String, action As String, localPath As String, refs() As String) As String
            If Not localPath.StartsWith(root & "\", StringComparison.OrdinalIgnoreCase) Then
                Return ResultLine(localPath, "skipped", Nothing, "outside the vault's working folder " & root)
            End If
            Dim ws = conn.WebServiceManager
            Dim vaultPath As String = VaultPathOf(root, localPath)
            Dim file As ACW.File = Latest(conn, vaultPath)
            Dim comment As String = CStr(RuleArguments.Arguments.Value("Comment"))
            Dim local As New VDF.Currency.FilePathAbsolute(localPath)
            Dim options = VDF.Vault.Settings.AcquireFilesSettings.AcquisitionOption.Download

            If file Is Nothing Then
                If action <> "checkin" Then Return ResultLine(localPath, "skipped", Nothing, "not in the vault")
                Dim folderPath As String = vaultPath.Substring(0, vaultPath.LastIndexOf("/"c))
                Dim parent As New VDF.Vault.Currency.Entities.Folder(conn, FolderFor(conn, folderPath))
                Dim added = conn.FileManager.AddFile(parent, comment, Associations(conn, root, Nothing, refs), Nothing, _
                    ACW.FileClassification.None, False, local)
                Return ResultLine(localPath, "added", ws.DocumentService.GetLatestFileByMasterId(added.EntityMasterId), "added to " & folderPath)
            End If

            If CheckedOutByOther(conn, file) Then
                Dim who As String = file.CkOutUserId.ToString()
                Try
                    who = ws.AdminService.GetUserByUserId(file.CkOutUserId).Name
                Catch
                End Try
                If action <> "get_latest" Then Return ResultLine(localPath, "skipped", file, "checked out by " & who & " on " & file.CkOutMach)
            End If

            Select Case action
                Case "checkout"
                    If file.CheckedOut Then Return ResultLine(localPath, "unchanged", file, "already checked out to you")
                    Dim problems As String = Acquire(conn, file, options Or VDF.Vault.Settings.AcquireFilesSettings.AcquisitionOption.Checkout)
                    Return ResultLine(localPath, If(problems.Length = 0, "checked out", "failed"), Latest(conn, vaultPath), problems)
                Case "checkin"
                    If Not file.CheckedOut Then Return ResultLine(localPath, "skipped", file, "not checked out: check it out, change it, save it, then check it in")
                    Dim iteration As New VDF.Vault.Currency.Entities.FileIteration(conn, file)
                    conn.FileManager.CheckinFile(iteration, comment, False, Associations(conn, root, file, refs), Nothing, False, Nothing, _
                        ACW.FileClassification.None, False, local)
                    Return ResultLine(localPath, "checked in", Latest(conn, vaultPath), "")
                Case "undo_checkout"
                    If Not file.CheckedOut Then Return ResultLine(localPath, "unchanged", file, "not checked out")
                    conn.FileManager.UndoCheckoutFile(New VDF.Vault.Currency.Entities.FileIteration(conn, file), local)
                    Return ResultLine(localPath, "check-out undone", Latest(conn, vaultPath), "the local copy is the vault's again")
                Case "get_latest"
                    If file.CheckedOut AndAlso Not CheckedOutByOther(conn, file) Then Return ResultLine(localPath, "skipped", file, "checked out to you: the local copy is your working copy")
                    Dim problems As String = Acquire(conn, file, options)
                    Return ResultLine(localPath, If(problems.Length = 0, "downloaded", "failed"), file, problems)
                Case "set_state"
                    If file.CheckedOut Then Return ResultLine(localPath, "skipped", file, "checked out: check it in or undo the check-out first")
                    Dim stateName As String = CStr(RuleArguments.Arguments.Value("State"))
                    Dim lifecycleName As String = CStr(RuleArguments.Arguments.Value("Lifecycle"))
                    Dim definitions() As ACW.LfCycDef = ws.LifeCycleService.GetAllLifeCycleDefinitions()
                    Dim definition As ACW.LfCycDef
                    If lifecycleName.Length > 0 Then
                        definition = definitions.FirstOrDefault(Function(candidate) String.Equals(candidate.DispName, lifecycleName, StringComparison.OrdinalIgnoreCase))
                        If definition Is Nothing Then Return ResultLine(localPath, "failed", file, "no lifecycle named " & lifecycleName & "; there are: " & String.Join(", ", definitions.Select(Function(candidate) candidate.DispName)))
                    ElseIf file.FileLfCyc Is Nothing OrElse file.FileLfCyc.LfCycDefId <= 0 Then
                        Return ResultLine(localPath, "failed", file, "the file has no lifecycle; pass lifecycle, one of: " & String.Join(", ", definitions.Select(Function(candidate) candidate.DispName)))
                    Else
                        definition = definitions.First(Function(candidate) candidate.Id = file.FileLfCyc.LfCycDefId)
                    End If
                    Dim target As ACW.LfCycState = definition.StateArray.FirstOrDefault(Function(candidate) String.Equals(candidate.DispName, stateName, StringComparison.OrdinalIgnoreCase))
                    If target Is Nothing Then Return ResultLine(localPath, "failed", file, definition.DispName & " has no state " & stateName & "; it has: " & String.Join(", ", definition.StateArray.Select(Function(candidate) candidate.DispName)))
                    If file.FileLfCyc IsNot Nothing AndAlso file.FileLfCyc.LfCycDefId = definition.Id Then
                        ws.DocumentServiceExtensions.UpdateFileLifeCycleStates(New Long() {file.MasterId}, New Long() {target.Id}, comment)
                    Else
                        ws.DocumentServiceExtensions.UpdateFileLifeCycleDefinitions(New Long() {file.MasterId}, New Long() {definition.Id}, New Long() {target.Id}, comment)
                    End If
                    Dim changed As ACW.File = Latest(conn, vaultPath)
                    Dim problems As String = Acquire(conn, changed, options)
                    Return ResultLine(localPath, If(problems.Length = 0, "state changed", "state changed, download failed"), changed, problems)
            End Select
            Return ResultLine(localPath, "failed", file, "unknown action " & action)
        End Function
        """;
}
