using InventorBridge.Mcp.Reference;
using Xunit;

namespace InventorBridge.Mcp.Tests
{
    public sealed class PageFormatterTests
    {
        private const string ObjectPage =
            "# Application\n" +
            "\n" +
            "Inventor API object · versions: 2024+ · [index](../index.md)\n" +
            "\n" +
            "```csharp\n" +
            "interface Application\n" +
            "{\n" +
            "    Document ActiveDocument { get; }\n" +
            "    DarkSiteLevelEnum DarkSiteLevel { get; } // since 2027\n" +
            "}\n" +
            "```\n" +
            "\n" +
            "**Returned by:** [Document](../objects/Document.md).Application and 5 more (see `members.tsv`)\n";

        [Fact]
        public void LinksBecomePlainNames()
        {
            var text = PageFormatter.Format(ObjectPage, "Application", isEnum: false, filter: null);

            Assert.DoesNotContain("](", text);
            Assert.DoesNotContain("index", text);
            Assert.Contains("**Returned by:** Document.Application", text);
        }

        [Fact]
        public void TheMembersFileHintPointsToApiLookup()
        {
            var text = PageFormatter.Format(ObjectPage, "Application", isEnum: false, filter: null);

            Assert.DoesNotContain("members.tsv", text);
            Assert.Contains("(search them with api_lookup)", text);
        }

        [Fact]
        public void MembersMissingFromTheVersionAreDropped()
        {
            var all = PageFormatter.Format(ObjectPage, "Application", isEnum: false, filter: null);
            var only2024 = PageFormatter.Format(ObjectPage, "Application", isEnum: false, filter: new VersionFilter(2024, 2027));

            Assert.Contains("DarkSiteLevel", all);
            Assert.DoesNotContain("DarkSiteLevel", only2024);
            Assert.Contains("ActiveDocument", only2024);
        }

        [Fact]
        public void LongEnumsAreCutBeforeTheClosingBrace()
        {
            var values = string.Concat(Enumerable.Range(1, 150).Select(value => $"    kValue{value} = {value},\n"));
            var page = "# BigEnum\n\n```csharp\nenum BigEnum\n{\n" + values + "}\n```\n";

            var lines = PageFormatter.Format(page, "BigEnum", isEnum: true, filter: null).Split(System.Environment.NewLine);

            Assert.Contains("    kValue100 = 100,", lines);
            Assert.DoesNotContain("    kValue101 = 101,", lines);
            var note = Array.FindIndex(lines, line => line.Contains("50 more values"));
            Assert.True(note > 0);
            Assert.Equal("}", lines[note + 1]);
        }
    }
}
