using System.Text;
using System.Text.RegularExpressions;

namespace InventorBridge.Mcp.Reference
{
    /// <summary>
    /// Turns a reference page (Markdown written for GitHub) into compact text for the agent:
    /// links become plain names, members missing from the requested version are dropped,
    /// and very long enums are cut short.
    /// </summary>
    public static class PageFormatter
    {
        private const int MaxEnumValues = 100;
        private const string CodeStart = "```csharp";
        private const string CodeEnd = "```";

        // Long lists on the pages end with "and N more (see `members.tsv`)"; the agent searches with api_lookup instead.
        private const string MembersFileHint = "(see `members.tsv`)";
        private const string AgentListHint = "(search them with api_lookup)";

        private static readonly Regex IndexLink = new(@" · \[index\]\([^)]*\)", RegexOptions.Compiled);
        private static readonly Regex Link = new(@"\[([^\]]+)\]\([^)]*\)", RegexOptions.Compiled);

        public static string Format(string markdown, string typeName, bool isEnum, VersionFilter? filter)
        {
            var text = new StringBuilder();
            var insideCode = false;
            var enumValues = 0;
            var hiddenEnumValues = 0;

            foreach (var rawLine in markdown.Split('\n'))
            {
                var line = Link.Replace(IndexLink.Replace(rawLine.TrimEnd('\r'), ""), "$1")
                    .Replace(MembersFileHint, AgentListHint, StringComparison.Ordinal);

                if (!insideCode)
                {
                    insideCode = line.StartsWith(CodeStart, StringComparison.Ordinal);
                    text.AppendLine(line);
                    continue;
                }

                if (line.StartsWith(CodeEnd, StringComparison.Ordinal))
                {
                    insideCode = false;
                    text.AppendLine(line);
                    continue;
                }

                if (line.StartsWith('}'))
                {
                    text.Append(EnumCutNote(hiddenEnumValues, typeName));
                }

                if (filter is not null && !filter.IncludesLine(line))
                {
                    continue;
                }

                if (isEnum && line.StartsWith("    ", StringComparison.Ordinal))
                {
                    enumValues++;
                    if (enumValues > MaxEnumValues)
                    {
                        hiddenEnumValues++;
                        continue;
                    }
                }

                text.AppendLine(line);
            }

            return text.ToString().TrimEnd() + System.Environment.NewLine;
        }

        private static string EnumCutNote(int hiddenEnumValues, string typeName)
        {
            if (hiddenEnumValues == 0)
            {
                return "";
            }

            return $"    // ... {hiddenEnumValues} more values: call api_lookup with \"{typeName}.<part of the name>\" to search them{System.Environment.NewLine}";
        }
    }
}
