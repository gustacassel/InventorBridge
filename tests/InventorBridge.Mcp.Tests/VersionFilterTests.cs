using InventorBridge.Mcp.Reference;
using Xunit;

namespace InventorBridge.Mcp.Tests
{
    public sealed class VersionFilterTests
    {
        private const int NewestYear = 2027;

        [Theory]
        [InlineData("2024+", 2024, true)]
        [InlineData("2024+", 2027, true)]
        [InlineData("2025+", 2024, false)]
        [InlineData("2025, 2026, 2027", 2024, false)]
        [InlineData("2025, 2026, 2027", 2026, true)]
        [InlineData("2024, 2025", 2026, false)]
        public void IncludesChecksTheVersionLabel(string label, int year, bool expected)
        {
            var filter = new VersionFilter(year, NewestYear);

            Assert.Equal(expected, filter.Includes(label));
        }

        [Fact]
        public void ANewerVersionIsTreatedAsTheNewestInTheReference()
        {
            var filter = new VersionFilter(2030, NewestYear);

            Assert.True(filter.Includes("2027"));
            Assert.False(filter.Includes("2024, 2025"));
            Assert.Equal(2030, filter.RequestedYear);
        }

        [Fact]
        public void IncludesLineDropsMembersAddedLater()
        {
            var filter = new VersionFilter(2024, NewestYear);

            Assert.False(filter.IncludesLine("    DarkSiteLevelEnum DarkSiteLevel { get; } // since 2027"));
            Assert.True(filter.IncludesLine("    Document ActiveDocument { get; }"));
        }

        [Fact]
        public void IncludesLineDropsMembersAlreadyRemoved()
        {
            var filter = new VersionFilter(2026, NewestYear);

            Assert.False(filter.IncludesLine("    void Old(); // removed in 2026"));
            Assert.True(filter.IncludesLine("    void Old(); // removed in 2027"));
        }
    }
}
