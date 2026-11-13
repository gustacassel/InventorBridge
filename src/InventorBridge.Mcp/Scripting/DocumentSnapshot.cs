using System.Runtime.InteropServices;
using Inventor;
using InventorBridge.Mcp.Reading;

namespace InventorBridge.Mcp.Scripting
{
    /// <summary>
    /// The state of the loaded documents at one moment. Comparing the snapshots taken before and after a script
    /// tells the agent what the script changed: documents created, opened, saved or closed, and features,
    /// sketches, occurrences and constraints added.
    /// </summary>
    /// <remarks>
    /// Only counts are kept, to keep the cost low on large assemblies; names are read afterwards for the items
    /// past the old count. A script that deletes one feature and adds another shows no feature change.
    /// A document can be loaded without a window, because an open assembly or drawing references it. Closing it
    /// then only closes its window, so "closed the window" and "closed" are reported apart.
    /// Above <see cref="MaxTrackedDocuments"/> loaded documents only those with a window are tracked, and nothing
    /// is claimed about the others except their count.
    /// </remarks>
    public sealed class DocumentSnapshot
    {
        internal const int MaxTrackedDocuments = 300;

        // A file written within this margin before the snapshot is still counted as written by the script.
        private static readonly TimeSpan WriteTimeMargin = TimeSpan.FromSeconds(1);

        private readonly Dictionary<string, DocumentState> documents;
        private readonly HashSet<string> withWindow;

        private DocumentSnapshot(IEnumerable<DocumentState> states, int loadedCount, DateTime takenUtc)
        {
            documents = states.ToDictionary(state => state.Key);
            withWindow = documents.Values.Where(state => state.HasWindow).Select(state => state.Key).ToHashSet();
            LoadedCount = loadedCount;
            CoversAll = loadedCount <= MaxTrackedDocuments;
            TakenUtc = takenUtc;
        }

        /// <summary>How many documents were loaded, with or without a window.</summary>
        internal int LoadedCount { get; }

        /// <summary>True when every loaded document is tracked; false when only those with a window are.</summary>
        internal bool CoversAll { get; }

        internal DateTime TakenUtc { get; }

        public static DocumentSnapshot Take(Application application)
        {
            var takenUtc = DateTime.UtcNow;
            var loaded = application.Documents;
            var loadedCount = loaded.Count;

            var states = new Dictionary<string, DocumentState>();
            foreach (Document document in loaded.VisibleDocuments)
            {
                var state = DocumentState.Read(document, hasWindow: true);
                states[state.Key] = state;
            }

            if (loadedCount <= MaxTrackedDocuments)
            {
                foreach (Document document in loaded)
                {
                    var key = document.InternalName;
                    if (!states.ContainsKey(key))
                    {
                        states[key] = DocumentState.Read(document, hasWindow: false);
                    }
                }
            }

            return new DocumentSnapshot(states.Values, loadedCount, takenUtc);
        }

        /// <summary>A snapshot built from states made without Inventor, for tests.</summary>
        internal static DocumentSnapshot FromStates(IEnumerable<DocumentState> states, int loadedCount, DateTime takenUtc)
        {
            return new DocumentSnapshot(states, loadedCount, takenUtc);
        }

        /// <summary>One line per change, or an empty list when nothing changed.</summary>
        /// <param name="isLoaded">Whether a document with this file is still loaded, asked only for a document
        /// whose window went away when the snapshot after it does not track every document.</param>
        public static List<string> Compare(DocumentSnapshot before, DocumentSnapshot after, Func<string, bool> isLoaded)
        {
            var changes = new List<string>();
            var referencesLoaded = 0;
            var referencesUnloaded = 0;

            foreach (var state in after.documents.Values)
            {
                if (!before.documents.TryGetValue(state.Key, out var old))
                {
                    if (state.HasWindow || state.IsNewSince(before.TakenUtc))
                    {
                        changes.Add(state.DescribeNew(before.TakenUtc));
                    }
                    else if (before.CoversAll)
                    {
                        referencesLoaded++;
                    }

                    continue;
                }

                if (old.HasWindow && !state.HasWindow)
                {
                    changes.Add($"closed the window of {state.DisplayName}; it stays loaded because another open document references it");
                }
                else if (!old.HasWindow && state.HasWindow)
                {
                    changes.Add($"opened a window for {state.DisplayName}, which was already loaded");
                }

                if (state.WasSavedSince(old))
                {
                    changes.Add($"saved {state.DisplayName} to {state.FullFileName}");
                }

                var contentChanges = state.DescribeAdditions(old);
                if (contentChanges.Length > 0)
                {
                    changes.Add($"{state.DisplayName}: {contentChanges}");
                }
            }

            foreach (var old in before.documents.Values)
            {
                if (after.documents.ContainsKey(old.Key))
                {
                    continue;
                }

                if (after.CoversAll)
                {
                    if (old.HasWindow)
                    {
                        changes.Add($"closed {old.DisplayName}");
                    }
                    else
                    {
                        referencesUnloaded++;
                    }
                }
                else if (old.HasWindow)
                {
                    // Only documents with a window are tracked now: ask whether it is still loaded.
                    changes.Add(old.FullFileName.Length > 0 && isLoaded(old.FullFileName)
                        ? $"closed the window of {old.DisplayName}; it stays loaded because another open document references it"
                        : $"closed {old.DisplayName}");
                }
            }

            if (referencesLoaded > 0)
            {
                changes.Add($"loaded {referencesLoaded} referenced document(s) without a window");
            }

            if (referencesUnloaded > 0)
            {
                changes.Add($"unloaded {referencesUnloaded} referenced document(s) that had no window");
            }

            if (!(before.CoversAll && after.CoversAll) && before.LoadedCount != after.LoadedCount)
            {
                changes.Add($"loaded documents: {before.LoadedCount} -> {after.LoadedCount} (above {MaxTrackedDocuments}, " +
                    "only documents with a window are tracked one by one)");
            }

            return changes;
        }

        /// <summary>What one document looked like when the snapshot was taken.</summary>
        internal sealed class DocumentState
        {
            private const int MaxNamesListed = 10;

            private Document? document;

            public string Key { get; private init; } = "";

            public string DisplayName { get; private init; } = "";

            public string FullFileName { get; private init; } = "";

            public string TypeName { get; private init; } = "";

            public bool HasWindow { get; private init; }

            private DateTime? LastWriteUtc { get; init; }

            private int Features { get; init; }

            private int Sketches { get; init; }

            private int Occurrences { get; init; }

            private int Constraints { get; init; }

            public static DocumentState Read(Document document, bool hasWindow)
            {
                var fullFileName = document.FullFileName ?? "";
                return new DocumentState
                {
                    document = document,
                    Key = document.InternalName,
                    DisplayName = document.DisplayName,
                    FullFileName = fullFileName,
                    TypeName = StatusReader.DocumentTypeName(document.DocumentType),
                    HasWindow = hasWindow,
                    LastWriteUtc = ReadLastWriteUtc(fullFileName),
                    Features = CountOrZero(() => (document as PartDocument)?.ComponentDefinition.Features.Count ?? 0),
                    Sketches = CountOrZero(() => (document as PartDocument)?.ComponentDefinition.Sketches.Count ?? 0),
                    Occurrences = CountOrZero(() => (document as AssemblyDocument)?.ComponentDefinition.Occurrences.Count ?? 0),
                    Constraints = CountOrZero(() => (document as AssemblyDocument)?.ComponentDefinition.Constraints.Count ?? 0),
                };
            }

            /// <summary>A state made without Inventor, for tests. Contents are not described.</summary>
            public static DocumentState ForTest(string key, string displayName, string fullFileName, bool hasWindow,
                DateTime? lastWriteUtc = null)
            {
                return new DocumentState
                {
                    Key = key,
                    DisplayName = displayName,
                    FullFileName = fullFileName,
                    TypeName = "part",
                    HasWindow = hasWindow,
                    LastWriteUtc = lastWriteUtc,
                };
            }

            /// <summary>True for a document that has no file yet or whose file was written after the given time.</summary>
            public bool IsNewSince(DateTime sinceUtc)
            {
                return FullFileName.Length == 0 || LastWriteUtc >= sinceUtc - WriteTimeMargin;
            }

            /// <summary>"created ...", "created ... and saved it to ..." or "opened ..." for a document not seen before.</summary>
            public string DescribeNew(DateTime sinceUtc)
            {
                var window = HasWindow ? "" : ", without a window";

                if (FullFileName.Length == 0)
                {
                    return $"created {DisplayName} ({TypeName}, not saved yet{window})" + DescribeContents();
                }

                return IsNewSince(sinceUtc)
                    ? $"created {DisplayName} ({TypeName}{window}) and saved it to {FullFileName}" + DescribeContents()
                    : $"opened {DisplayName} ({TypeName}, {FullFileName}{window})";
            }

            public bool WasSavedSince(DocumentState old)
            {
                return FullFileName.Length > 0
                    && (FullFileName != old.FullFileName || (LastWriteUtc is not null && LastWriteUtc != old.LastWriteUtc));
            }

            /// <summary>"features +2 (Extrusion1, Fillet1); sketches +1 (Sketch2)", or "" if nothing was added.</summary>
            public string DescribeAdditions(DocumentState old)
            {
                var parts = new List<string>();

                if (document is PartDocument part)
                {
                    var definition = part.ComponentDefinition;
                    AddPart(parts, "features", old.Features, Features, index => definition.Features[index].Name);
                    AddPart(parts, "sketches", old.Sketches, Sketches, index => definition.Sketches[index].Name);
                }
                else if (document is AssemblyDocument assembly)
                {
                    var definition = assembly.ComponentDefinition;
                    AddPart(parts, "occurrences", old.Occurrences, Occurrences, index => definition.Occurrences[index].Name);
                    AddPart(parts, "constraints", old.Constraints, Constraints, index => definition.Constraints[index].Name);
                }

                return string.Join("; ", parts);
            }

            /// <summary>"; features +1 (Extrusion1)" for a document that did not exist before.</summary>
            private string DescribeContents()
            {
                var additions = DescribeAdditions(new DocumentState());
                return additions.Length == 0 ? "" : "; " + additions;
            }

            private static DateTime? ReadLastWriteUtc(string fullFileName)
            {
                return fullFileName.Length > 0 && System.IO.File.Exists(fullFileName)
                    ? System.IO.File.GetLastWriteTimeUtc(fullFileName)
                    : null;
            }

            private static void AddPart(List<string> parts, string label, int oldCount, int newCount, Func<int, string> nameAt)
            {
                if (newCount == oldCount)
                {
                    return;
                }

                if (newCount < oldCount)
                {
                    parts.Add($"{label} {newCount - oldCount}");
                    return;
                }

                var names = new List<string>();
                for (var index = oldCount + 1; index <= newCount && names.Count < MaxNamesListed; index++)
                {
                    names.Add(ReadOrUnknown(() => nameAt(index)));
                }

                var more = newCount - oldCount > names.Count ? ", ..." : "";
                parts.Add($"{label} +{newCount - oldCount} ({string.Join(", ", names)}{more})");
            }

            private static int CountOrZero(Func<int> count)
            {
                try
                {
                    return count();
                }
                catch (COMException)
                {
                    return 0;
                }
            }

            private static string ReadOrUnknown(Func<string> read)
            {
                try
                {
                    return read();
                }
                catch (COMException)
                {
                    return "?";
                }
            }
        }
    }
}
