using InventorBridge.Mcp.Scripting;
using Xunit;
using State = InventorBridge.Mcp.Scripting.DocumentSnapshot.DocumentState;

namespace InventorBridge.Mcp.Tests
{
    /// <summary>How the changes between two snapshots are described, with states made without Inventor.</summary>
    public sealed class DocumentSnapshotTests
    {
        private static readonly DateTime Before = new(2026, 11, 13, 12, 0, 0, DateTimeKind.Utc);
        private static readonly DateTime After = Before.AddSeconds(5);

        [Fact]
        public void ClosingAReferencedDocumentOnlyClosesItsWindow()
        {
            var before = Snapshot(Before, 2, Doc("a", "Tube.ipt", window: true), Doc("b", "Pipes.iam", window: true));
            var after = Snapshot(After, 2, Doc("a", "Tube.ipt", window: false), Doc("b", "Pipes.iam", window: true));

            var changes = DocumentSnapshot.Compare(before, after, _ => throw new InvalidOperationException("not needed"));

            Assert.Equal(["closed the window of Tube.ipt; it stays loaded because another open document references it"], changes);
        }

        [Fact]
        public void ADocumentThatIsGoneWasClosed()
        {
            var before = Snapshot(Before, 1, Doc("a", "Tube.ipt", window: true));
            var after = Snapshot(After, 0);

            Assert.Equal(["closed Tube.ipt"], DocumentSnapshot.Compare(before, after, _ => false));
        }

        [Fact]
        public void AboveTheLimitUntrackedDocumentsAreNotReportedAsClosed()
        {
            // Before: a small assembly and its parts, all tracked. After: a large assembly was opened, so only
            // documents with a window are tracked; the parts are still loaded but no longer seen.
            var before = Snapshot(Before, 3,
                Doc("asm", "Rail.iam", window: true), Doc("p1", "Beam.ipt", window: false), Doc("p2", "Guide.ipt", window: false));
            var after = Snapshot(After, 799,
                Doc("asm", "Rail.iam", window: true), Doc("big", "Box.iam", window: true, lastWriteUtc: Before.AddDays(-3)));

            var changes = DocumentSnapshot.Compare(before, after, _ => true);

            Assert.DoesNotContain(changes, change => change.Contains("Beam.ipt") || change.Contains("Guide.ipt"));
            Assert.Contains(changes, change => change.StartsWith("opened Box.iam"));
            Assert.Contains(changes, change => change.StartsWith("loaded documents: 3 -> 799"));
        }

        [Fact]
        public void AboveTheLimitAClosedWindowIsCheckedAgainstTheLoadedDocuments()
        {
            var before = Snapshot(Before, 400, Doc("a", "Tube.ipt", window: true), Doc("b", "Bend.ipt", window: true));
            var after = Snapshot(After, 400);

            var changes = DocumentSnapshot.Compare(before, after, file => file.EndsWith("Tube.ipt"));

            Assert.Contains("closed the window of Tube.ipt; it stays loaded because another open document references it", changes);
            Assert.Contains("closed Bend.ipt", changes);
        }

        [Fact]
        public void NewDocumentsAreCreatedSavedOrOpened()
        {
            var before = Snapshot(Before, 0);
            var after = Snapshot(After, 3,
                Doc("new", "Part1", window: true, file: ""),
                Doc("saved", "Tube.ipt", window: true, lastWriteUtc: After),
                Doc("old", "Rail.iam", window: true, lastWriteUtc: Before.AddDays(-3)));

            var changes = DocumentSnapshot.Compare(before, after, _ => true);

            Assert.Contains("created Part1 (part, not saved yet)", changes);
            Assert.Contains(@"created Tube.ipt (part) and saved it to C:\Work\Tube.ipt", changes);
            Assert.Contains(@"opened Rail.iam (part, C:\Work\Rail.iam)", changes);
        }

        [Fact]
        public void ReferencedDocumentsLoadedWithAnAssemblyAreCountedNotListed()
        {
            var old = Before.AddDays(-3);
            var before = Snapshot(Before, 0);
            var after = Snapshot(After, 4,
                Doc("asm", "Rail.iam", window: true, lastWriteUtc: old),
                Doc("p1", "Beam.ipt", window: false, lastWriteUtc: old),
                Doc("p2", "Guide.ipt", window: false, lastWriteUtc: old),
                Doc("p3", "Bolt.ipt", window: false, lastWriteUtc: old));

            var changes = DocumentSnapshot.Compare(before, after, _ => true);

            Assert.Equal([@"opened Rail.iam (part, C:\Work\Rail.iam)", "loaded 3 referenced document(s) without a window"], changes);
        }

        private static DocumentSnapshot Snapshot(DateTime takenUtc, int loadedCount, params State[] states)
        {
            return DocumentSnapshot.FromStates(states, loadedCount, takenUtc);
        }

        private static State Doc(string key, string name, bool window, DateTime? lastWriteUtc = null, string? file = null)
        {
            return State.ForTest(key, name, file ?? @"C:\Work\" + name, window, lastWriteUtc ?? Before.AddDays(-1));
        }
    }
}
