using System.Runtime.InteropServices;
using Inventor;
using InventorBridge.Mcp.Reading;

namespace InventorBridge.Mcp.Scripting
{
    /// <summary>
    /// The state of the open documents at one moment. Comparing the snapshots taken before and after a script
    /// tells the agent what the script changed: documents created, saved or closed, and features, sketches,
    /// occurrences and constraints added.
    /// </summary>
    /// <remarks>
    /// Only counts are kept, to keep the cost low on large assemblies; names are read afterwards for the items
    /// past the old count. A script that deletes one feature and adds another shows no feature change.
    /// </remarks>
    public sealed class DocumentSnapshot
    {
        // Above this many loaded documents (a large assembly), only the visible documents are tracked.
        private const int MaxTrackedDocuments = 300;

        private readonly Dictionary<string, DocumentState> documents;

        private DocumentSnapshot(Dictionary<string, DocumentState> documents)
        {
            this.documents = documents;
        }

        public static DocumentSnapshot Take(Application application)
        {
            var source = application.Documents.Count > MaxTrackedDocuments
                ? (System.Collections.IEnumerable)application.Documents.VisibleDocuments
                : application.Documents;

            var documents = new Dictionary<string, DocumentState>();
            foreach (Document document in source)
            {
                var state = DocumentState.Read(document);
                documents[state.Key] = state;
            }

            return new DocumentSnapshot(documents);
        }

        /// <summary>One line per change, or an empty list when nothing changed.</summary>
        public static List<string> Compare(DocumentSnapshot before, DocumentSnapshot after)
        {
            var changes = new List<string>();

            foreach (var state in after.documents.Values)
            {
                if (!before.documents.TryGetValue(state.Key, out var old))
                {
                    var where = state.FullFileName.Length == 0 ? "not saved yet" : state.FullFileName;
                    changes.Add($"created or opened {state.DisplayName} ({state.TypeName}, {where})" + state.DescribeContents());
                    continue;
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
                if (!after.documents.ContainsKey(old.Key))
                {
                    changes.Add($"closed {old.DisplayName}");
                }
            }

            return changes;
        }

        /// <summary>What one document looked like when the snapshot was taken.</summary>
        private sealed class DocumentState
        {
            private const int MaxNamesListed = 10;

            private Document document = null!;

            public string Key { get; private init; } = "";

            public string DisplayName { get; private init; } = "";

            public string FullFileName { get; private init; } = "";

            public string TypeName { get; private init; } = "";

            private DateTime? LastWriteUtc { get; init; }

            private int Features { get; init; }

            private int Sketches { get; init; }

            private int Occurrences { get; init; }

            private int Constraints { get; init; }

            public static DocumentState Read(Document document)
            {
                var fullFileName = document.FullFileName ?? "";
                var state = new DocumentState
                {
                    document = document,
                    Key = document.InternalName,
                    DisplayName = document.DisplayName,
                    FullFileName = fullFileName,
                    TypeName = StatusReader.DocumentTypeName(document.DocumentType),
                    LastWriteUtc = fullFileName.Length > 0 && System.IO.File.Exists(fullFileName)
                        ? System.IO.File.GetLastWriteTimeUtc(fullFileName)
                        : null,
                    Features = CountOrZero(() => (document as PartDocument)?.ComponentDefinition.Features.Count ?? 0),
                    Sketches = CountOrZero(() => (document as PartDocument)?.ComponentDefinition.Sketches.Count ?? 0),
                    Occurrences = CountOrZero(() => (document as AssemblyDocument)?.ComponentDefinition.Occurrences.Count ?? 0),
                    Constraints = CountOrZero(() => (document as AssemblyDocument)?.ComponentDefinition.Constraints.Count ?? 0),
                };

                return state;
            }

            public bool WasSavedSince(DocumentState old)
            {
                return FullFileName.Length > 0
                    && (FullFileName != old.FullFileName || (LastWriteUtc is not null && LastWriteUtc != old.LastWriteUtc));
            }

            /// <summary>"; features: Extrusion1, Revolution1" for a document that did not exist before.</summary>
            public string DescribeContents()
            {
                var empty = new DocumentState();
                var additions = DescribeAdditions(empty);
                return additions.Length == 0 ? "" : "; " + additions;
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
