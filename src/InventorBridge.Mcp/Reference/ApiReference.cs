using System.Text;
using System.Text.RegularExpressions;

namespace InventorBridge.Mcp.Reference
{
    /// <summary>
    /// The generated API reference (docs/reference), copied next to the server at build time.
    /// It is loaded on first use and answers api_lookup queries; it does not need Inventor.
    /// </summary>
    public sealed class ApiReference
    {
        private const string FolderName = "reference";
        private const string MembersFileName = "members.tsv";
        private const int MaxResults = 30;

        private static readonly Regex Year = new(@"\d{4}", RegexOptions.Compiled);
        private static readonly Regex PageVersions = new(@"versions: ([^·\r\n]+)", RegexOptions.Compiled);

        private readonly Lazy<LoadedReference> loaded;

        public ApiReference()
        {
            loaded = new Lazy<LoadedReference>(() => Load(Path.Combine(AppContext.BaseDirectory, FolderName)));
        }

        /// <summary>
        /// "ExtrudeFeatures": the type's page. "ExtrudeFeatures.Add": its members whose name contains "Add".
        /// Anything else: a search over type and member names.
        /// </summary>
        /// <param name="year">Inventor version to filter by (2024...), or null for every version.</param>
        /// <exception cref="InvalidOperationException">The reference files are missing.</exception>
        public string Lookup(string query, int? year)
        {
            var reference = loaded.Value;
            var filter = year is null ? null : new VersionFilter(year.Value, reference.NewestYear);
            var text = query.Trim();

            var header = new StringBuilder();
            header.AppendLine(DescribeFilter(reference, filter));

            var firstDot = text.IndexOf('.');
            if (firstDot > 0)
            {
                var typeName = text[..firstDot];
                var memberText = text[(text.LastIndexOf('.') + 1)..];

                if (reference.Types.TryGetValue(typeName, out var type))
                {
                    return header + DescribeMembers(reference, type, memberText, filter);
                }

                header.AppendLine($"There is no type named {typeName}; searching for \"{memberText}\" instead.");
                text = memberText;
            }

            if (reference.Types.TryGetValue(text, out var page))
            {
                return header + DescribePage(page, filter);
            }

            return header + Search(reference, text, filter);
        }

        private static string DescribeFilter(LoadedReference reference, VersionFilter? filter)
        {
            if (filter is null)
            {
                return $"Inventor {reference.OldestYear} to {reference.NewestYear}. Members marked \"// since 20xx\" do not exist in older versions.";
            }

            if (filter.RequestedYear > reference.NewestYear)
            {
                return $"Inventor {filter.RequestedYear} is newer than the reference, which goes up to {reference.NewestYear}: showing {reference.NewestYear}.";
            }

            return $"Inventor {filter.RequestedYear}: members that do not exist in this version are hidden.";
        }

        private static string DescribePage(TypePage type, VersionFilter? filter)
        {
            var markdown = File.ReadAllText(type.Path);
            var text = new StringBuilder();

            var versions = PageVersions.Match(markdown);
            if (filter is not null && versions.Success && !filter.Includes(versions.Groups[1].Value))
            {
                text.AppendLine($"Warning: {type.Name} does not exist in Inventor {filter.RequestedYear} (versions: {versions.Groups[1].Value.Trim()}).");
            }

            text.AppendLine();
            text.Append(PageFormatter.Format(markdown, type.Name, type.IsEnum, filter));
            return text.ToString();
        }

        private static string DescribeMembers(LoadedReference reference, TypePage type, string memberText, VersionFilter? filter)
        {
            var all = reference.MembersByType.TryGetValue(type.Name, out var members) ? members : [];
            var matching = all.Where(member => member.Name.Contains(memberText, StringComparison.OrdinalIgnoreCase)).ToList();
            var visible = matching.Where(member => filter is null || filter.Includes(member.Versions)).ToList();

            var text = new StringBuilder();

            if (visible.Count == 0)
            {
                text.AppendLine(matching.Count == 0
                    ? $"{type.Name} has no member whose name contains \"{memberText}\". Call api_lookup(\"{type.Name}\") to see all of them."
                    : $"{type.Name} has members containing \"{memberText}\", but not in Inventor {filter!.RequestedYear}: " +
                      string.Join(", ", matching.Select(member => $"{member.Name} ({member.Versions})")));
                return text.ToString();
            }

            text.AppendLine($"{type.Name} members whose name contains \"{memberText}\":");
            foreach (var member in visible)
            {
                text.AppendLine($"    {member.Signature}{VersionsNote(reference, member)}");
            }

            return text.ToString();
        }

        private static string Search(LoadedReference reference, string text, VersionFilter? filter)
        {
            var types = reference.Types.Values
                .Where(type => type.Name.Contains(text, StringComparison.OrdinalIgnoreCase))
                .OrderBy(type => Rank(type.Name, text))
                .ThenBy(type => type.Name.Length)
                .ThenBy(type => type.Name, StringComparer.Ordinal)
                .ToList();

            var members = reference.Members
                .Where(member => member.Name.Contains(text, StringComparison.OrdinalIgnoreCase))
                .Where(member => filter is null || filter.Includes(member.Versions))
                .OrderBy(member => Rank(member.Name, text))
                .ThenBy(member => member.Name.Length)
                .ThenBy(member => member.TypeName, StringComparer.Ordinal)
                .ToList();

            var result = new StringBuilder();

            if (types.Count == 0 && members.Count == 0)
            {
                result.AppendLine($"Nothing matches \"{text}\". Try a shorter part of the name (\"Extrude\" instead of \"ExtrudeFeatureDefinition\").");
                return result.ToString();
            }

            if (types.Count > 0)
            {
                result.AppendLine($"Types ({Math.Min(types.Count, MaxResults)} of {types.Count}):");
                foreach (var type in types.Take(MaxResults))
                {
                    result.AppendLine($"    {type.Name} ({(type.IsEnum ? "enum" : "object")})");
                }
            }

            if (members.Count > 0)
            {
                result.AppendLine($"Members ({Math.Min(members.Count, MaxResults)} of {members.Count}):");
                foreach (var member in members.Take(MaxResults))
                {
                    result.AppendLine($"    {member.TypeName}: {member.Signature}{VersionsNote(reference, member)}");
                }
            }

            result.AppendLine("Call api_lookup(\"TypeName\") for a whole page, or api_lookup(\"TypeName.part of a member name\") for some members.");
            return result.ToString();
        }

        /// <summary>0 for an exact match, 1 when the name starts with the text, 2 when it only contains it.</summary>
        private static int Rank(string name, string text)
        {
            if (name.Equals(text, StringComparison.OrdinalIgnoreCase))
            {
                return 0;
            }

            return name.StartsWith(text, StringComparison.OrdinalIgnoreCase) ? 1 : 2;
        }

        private static string VersionsNote(LoadedReference reference, ReferenceMember member)
        {
            return member.Versions == $"{reference.OldestYear}+" ? "" : $"  // {member.Versions}";
        }

        private static LoadedReference Load(string directory)
        {
            var membersPath = Path.Combine(directory, MembersFileName);
            if (!File.Exists(membersPath))
            {
                throw new InvalidOperationException(
                    $"The API reference was not found at {directory}. Build InventorBridge.Mcp from the repository: " +
                    "the build copies docs/reference next to the server.");
            }

            var members = new List<ReferenceMember>();
            foreach (var line in File.ReadLines(membersPath).Skip(1))
            {
                var columns = line.Split('\t');
                if (columns.Length < 5)
                {
                    continue;
                }

                members.Add(new ReferenceMember
                {
                    TypeName = columns[0],
                    Name = columns[1],
                    Kind = columns[2],
                    Signature = columns[3],
                    Versions = columns[4],
                });
            }

            var types = new Dictionary<string, TypePage>(StringComparer.OrdinalIgnoreCase);
            AddPages(types, Path.Combine(directory, "objects"), isEnum: false);
            AddPages(types, Path.Combine(directory, "enums"), isEnum: true);

            var years = members
                .SelectMany(member => Year.Matches(member.Versions).Select(match => int.Parse(match.Value)))
                .Distinct()
                .ToList();

            return new LoadedReference
            {
                Members = members,
                MembersByType = members
                    .GroupBy(member => member.TypeName, StringComparer.OrdinalIgnoreCase)
                    .ToDictionary(group => group.Key, group => group.ToList(), StringComparer.OrdinalIgnoreCase),
                Types = types,
                OldestYear = years.Min(),
                NewestYear = years.Max(),
            };
        }

        private static void AddPages(Dictionary<string, TypePage> types, string directory, bool isEnum)
        {
            foreach (var path in Directory.EnumerateFiles(directory, "*.md"))
            {
                var name = Path.GetFileNameWithoutExtension(path);
                types.TryAdd(name, new TypePage { Name = name, Path = path, IsEnum = isEnum });
            }
        }

        private sealed class TypePage
        {
            public required string Name { get; init; }

            public required string Path { get; init; }

            public required bool IsEnum { get; init; }
        }

        private sealed class LoadedReference
        {
            public required List<ReferenceMember> Members { get; init; }

            public required Dictionary<string, List<ReferenceMember>> MembersByType { get; init; }

            public required Dictionary<string, TypePage> Types { get; init; }

            public required int OldestYear { get; init; }

            public required int NewestYear { get; init; }
        }
    }
}
