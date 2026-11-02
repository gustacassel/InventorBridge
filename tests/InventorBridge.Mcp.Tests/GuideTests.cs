using System.Text.RegularExpressions;
using InventorBridge.Mcp.Reference;
using InventorBridge.Mcp.Scripting;
using Xunit;

namespace InventorBridge.Mcp.Tests
{
    /// <summary>Runs against the guides in docs/guides, which the build copies next to the server.</summary>
    public sealed class GuideTests
    {
        private static readonly Regex CodeBlock = new("```csharp\\r?\\n(.*?)```", RegexOptions.Singleline);

        private readonly GuideLibrary guides = new();

        public static TheoryData<string> GuideNames()
        {
            var names = new TheoryData<string>();
            foreach (var path in Directory.EnumerateFiles(Path.Combine(AppContext.BaseDirectory, "guides"), "*.md"))
            {
                names.Add(Path.GetFileNameWithoutExtension(path));
            }

            return names;
        }

        [Fact]
        public void TheListShowsEveryGuideWithItsSummary()
        {
            var list = guides.List();

            Assert.Contains("workflow: Read first", list);
            Assert.Contains("parts: ", list);
            Assert.Contains("assemblies: ", list);
            Assert.Contains("api-pitfalls: ", list);
        }

        [Theory]
        [MemberData(nameof(GuideNames))]
        public void EveryGuideHasATitleAndASummary(string name)
        {
            var lines = guides.Read(name)!.Split('\n');

            Assert.StartsWith("# ", lines[0]);
            Assert.Contains(lines, line => line.StartsWith("> ", StringComparison.Ordinal));
        }

        [Theory]
        [MemberData(nameof(GuideNames))]
        public void EveryCodeBlockCompilesAsARunCSharpScript(string name)
        {
            var runner = new ScriptRunner();

            foreach (Match block in CodeBlock.Matches(guides.Read(name)!))
            {
                var errors = runner.GetCompilationErrors(block.Groups[1].Value);
                Assert.True(errors.Count == 0, $"{name}: {string.Join("; ", errors)}");
            }
        }

        [Fact]
        public void AnUnknownGuideIsNull()
        {
            Assert.Null(guides.Read("no-such-guide"));
        }
    }
}
