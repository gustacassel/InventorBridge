using System.Text.RegularExpressions;

namespace InventorBridge.Mcp.Reference
{
    /// <summary>
    /// Decides whether something in the reference exists in one Inventor version.
    /// A version newer than the reference is treated as the newest version in it.
    /// </summary>
    public sealed class VersionFilter
    {
        private static readonly Regex SinceNote = new(@"// since (\d{4})", RegexOptions.Compiled);
        private static readonly Regex RemovedNote = new(@"removed in (\d{4})", RegexOptions.Compiled);

        private readonly int year;

        public VersionFilter(int requestedYear, int newestYear)
        {
            RequestedYear = requestedYear;
            year = Math.Min(requestedYear, newestYear);
        }

        public int RequestedYear { get; }

        /// <summary>Checks a version label from members.tsv or a page header: "2024+" or "2025, 2026, 2027".</summary>
        public bool Includes(string versions)
        {
            var label = versions.Trim();

            if (label.EndsWith('+'))
            {
                return int.TryParse(label[..^1], out var first) && year >= first;
            }

            foreach (var part in label.Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries))
            {
                if (int.TryParse(part, out var listed) && listed == year)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>Checks a line of pseudo-C# by its "// since 20xx" and "removed in 20xx" notes.</summary>
        public bool IncludesLine(string line)
        {
            var since = SinceNote.Match(line);
            if (since.Success && int.Parse(since.Groups[1].Value) > year)
            {
                return false;
            }

            var removed = RemovedNote.Match(line);
            if (removed.Success && int.Parse(removed.Groups[1].Value) <= year)
            {
                return false;
            }

            return true;
        }
    }
}
