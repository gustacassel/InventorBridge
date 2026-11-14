using Inventor;

namespace InventorBridge.Mcp.Scripting
{
    /// <summary>
    /// Undoes the last run_csharp script, as Ctrl+Z would in Inventor, but only when the last step in Inventor's
    /// undo list is one: a step the user made by hand is never undone from here.
    /// </summary>
    public static class ScriptUndo
    {
        public static string UndoLast(Application application)
        {
            var manager = application.TransactionManager;
            var orphanNote = ScriptTransaction.CloseOrphaned(application) ?? "";
            Transaction? last = null;
            foreach (Transaction transaction in manager.CommittedTransactions)
            {
                last = transaction;
            }

            if (last is null)
            {
                throw new InvalidOperationException("Inventor's undo list is empty: there is nothing to undo.");
            }

            var name = last.DisplayName;
            if (!name.StartsWith(ScriptRunner.TransactionPrefix, StringComparison.Ordinal))
            {
                throw new InvalidOperationException(
                    $"The last step in Inventor's undo list is \"{name}\", which is not a run_csharp script (the user's own " +
                    "work, or a script run with undoable=false). Nothing was undone; if the user wants that step undone, " +
                    "they can press Ctrl+Z in Inventor.");
            }

            // Undo works on the active document's steps: activate the one the script changed.
            var document = last.Document;
            if (document is not null && !ReferenceEquals(application.ActiveDocument, document)
                && application.ActiveDocument?.InternalName != document.InternalName)
            {
                document.Activate();
            }

            manager.UndoTransaction();

            var description = name[ScriptRunner.TransactionPrefix.Length..];
            return orphanNote + $"undid \"{description}\" on {document?.DisplayName ?? "the active document"}. " +
                "Documents the script created or saved are not affected; call undo_last again to undo the script before it.";
        }
    }
}
