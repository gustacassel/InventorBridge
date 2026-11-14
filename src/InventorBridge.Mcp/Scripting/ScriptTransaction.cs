using System.Runtime.InteropServices;
using Inventor;

namespace InventorBridge.Mcp.Scripting
{
    /// <summary>
    /// The Inventor transaction a script runs in, on the document that was active when it started, and the note
    /// that tells the agent what became of it.
    /// </summary>
    /// <remarks>
    /// A script may close that document. Ending or aborting the transaction then fails, which is not an error of
    /// the script: the note says the document was closed instead of reporting a failed commit or rollback.
    /// </remarks>
    internal sealed class ScriptTransaction
    {
        private readonly Transaction? transaction;
        private readonly string? documentKey;
        private readonly string documentName;
        private readonly string documentFile;
        private readonly bool undoable;
        private readonly string orphanNote;

        private ScriptTransaction(Transaction? transaction, Document? document, bool undoable, string orphanNote)
        {
            this.transaction = transaction;
            this.undoable = undoable;
            this.orphanNote = orphanNote;
            documentKey = document?.InternalName;
            documentName = document?.DisplayName ?? "";
            documentFile = document?.FullFileName ?? "";
        }

        /// <summary>
        /// Starts a transaction on the active document, unless the script is not undoable or no document is open.
        /// First closes a transaction an earlier script left open (see <see cref="CloseOrphaned"/>).
        /// </summary>
        public static ScriptTransaction Start(Application application, string name, bool undoable)
        {
            var orphanNote = CloseOrphaned(application) ?? "";
            var document = application.ActiveDocument;
            if (!undoable || document is null)
            {
                return new ScriptTransaction(null, null, undoable, orphanNote);
            }

            var transaction = application.TransactionManager.StartTransaction(document, name);
            return new ScriptTransaction(transaction, document, undoable, orphanNote);
        }

        /// <summary>
        /// Ends a run_csharp transaction that is still open in Inventor, and says so; null when there is none.
        /// </summary>
        /// <remarks>
        /// Scripts run one at a time and always end or abort their transaction, so one still open when a new script
        /// starts was left by a server process that stopped while its script ran (restarted while a dialog held
        /// it, for example). Left open, it swallows every later transaction: Inventor's undo stays disabled and
        /// rollbacks undo nothing. Ending it keeps its changes, which were already made, as one undo step.
        /// </remarks>
        public static string? CloseOrphaned(Application application)
        {
            Transaction? orphan = null;
            try
            {
                // Inventor keeps an ambient "Unidentified transaction" open; ours would sit below it or above it.
                var current = application.TransactionManager.CurrentTransaction;
                while (current is not null)
                {
                    if (current.DisplayName.StartsWith(ScriptRunner.TransactionPrefix, StringComparison.Ordinal))
                    {
                        orphan = current;
                    }

                    current = current.HasParentTransaction ? current.ParentTransaction : null;
                }
            }
            catch (COMException)
            {
                // Some of Inventor's own transactions cannot be read; what was found so far is still valid.
            }

            if (orphan is null)
            {
                return null;
            }

            try
            {
                var description = orphan.DisplayName[ScriptRunner.TransactionPrefix.Length..];
                orphan.End();
                return $"first closed the transaction of an earlier script (\"{description}\"), left open because the " +
                    "server stopped while it ran; its changes stay, as one undo step. Then: ";
            }
            catch (COMException exception)
            {
                return $"found the transaction of an earlier script still open, left by a server that stopped while it " +
                    $"ran, but could not close it ({exception.Message}); Inventor's undo may not work until Inventor restarts. Then: ";
            }
        }

        /// <summary>Ends the transaction after the script succeeded.</summary>
        public string Commit(Application application)
        {
            return orphanNote + CommitCore(application);
        }

        /// <summary>Aborts the transaction after the script threw.</summary>
        public string RollBack(Application application)
        {
            return orphanNote + RollBackCore(application);
        }

        private string CommitCore(Application application)
        {
            if (transaction is null)
            {
                return NoTransactionNote("nothing can be undone as one step");
            }

            var closedNote = $"none: the script closed \"{documentName}\", the document its transaction was on, so there is no undo step";

            try
            {
                transaction.End();
                return IsDocumentOpen(application)
                    ? $"committed on \"{documentName}\" (one Ctrl+Z in Inventor undoes it; documents created by the script are not covered)"
                    : closedNote;
            }
            catch (COMException exception)
            {
                return IsDocumentOpen(application)
                    ? $"could not be committed on \"{documentName}\" ({exception.Message}); the changes stay, but Ctrl+Z may not undo them as one step"
                    : closedNote;
            }
        }

        private string RollBackCore(Application application)
        {
            if (transaction is null)
            {
                return NoTransactionNote("changes made before the error remain");
            }

            try
            {
                transaction.Abort();
                return $"rolled back: changes to \"{documentName}\" were undone (documents created or saved by the script remain)";
            }
            catch (COMException exception)
            {
                return IsDocumentOpen(application)
                    ? $"rollback failed ({exception.Message}); check the document state"
                    : $"nothing to roll back: the script closed \"{documentName}\" before the error; other changes made before the error remain";
            }
        }

        private string NoTransactionNote(string consequence)
        {
            return undoable
                ? $"none: no document was open when the script started, so {consequence}"
                : $"none: run with undoable=false, so {consequence}";
        }

        /// <summary>Whether the transaction's document is still loaded, with or without a window.</summary>
        /// <remarks>
        /// Cheap even with hundreds of documents loaded: the documents with a window first, then a lookup by file.
        /// </remarks>
        private bool IsDocumentOpen(Application application)
        {
            try
            {
                foreach (Document document in application.Documents.VisibleDocuments)
                {
                    // By internal name, which survives SaveAs. Files copied from one another share it, so this can
                    // say "open" for a closed copy whose twin is open: the safe side.
                    if (document.InternalName == documentKey)
                    {
                        return true;
                    }
                }

                if (documentFile.Length == 0)
                {
                    return false;
                }

                _ = application.Documents.ItemByName[documentFile];
                return true;
            }
            catch (ArgumentException)
            {
                // ItemByName: no document with that file is loaded.
                return false;
            }
            catch (COMException)
            {
                // Inventor could not be asked: do not claim the document was closed.
                return true;
            }
        }
    }
}
