using System.Text.Json.Serialization;

namespace DocGen.Model
{
    // Model with ALL versions combined, used to generate the documentation.

    public sealed class MergedMember
    {
        public required string Name { get; init; }
        public required ApiMemberKind Kind { get; init; }

        /// <summary>The member as it appears in the newest version that has it.</summary>
        public required ApiMember Latest { get; set; }

        /// <summary>Versions in which the member exists, in order.</summary>
        public List<string> Versions { get; } = [];

        /// <summary>Formatted signature per version, to point out signature changes between versions.</summary>
        public Dictionary<string, string> SignatureByVersion { get; } = [];

        [JsonIgnore]
        public bool IsHidden => Latest.IsHidden;

        [JsonIgnore]
        public string Key => Latest.Key;
    }

    public sealed class MergedEnumValue
    {
        public required string Name { get; init; }
        public long Value { get; set; }
        public List<string> Versions { get; } = [];
    }

    public sealed class MergedType
    {
        public required string Name { get; init; }
        public required ApiTypeKind Kind { get; init; }
        public bool IsHidden { get; set; }
        public IReadOnlyList<string> VTable { get; set; } = [];
        public List<string> Versions { get; } = [];

        /// <summary>Members by <see cref="ApiMember.Key"/>, in reading order.</summary>
        public Dictionary<string, MergedMember> Members { get; } = [];

        /// <summary>Enum values by name.</summary>
        public Dictionary<string, MergedEnumValue> EnumValues { get; } = [];

        // Filled in by the analysis (Analysis folder).

        /// <summary>
        /// COM ancestors, from the closest to the farthest. E.g. SheetMetalComponentDefinition has
        /// [PartComponentDefinition, ComponentDefinition].
        /// </summary>
        public List<string> Ancestors { get; } = [];

        /// <summary>"Owner.Member" entries that return this object.</summary>
        public List<string> ReturnedBy { get; } = [];

        /// <summary>"Owner.Member" entries that use this enum (as return type or parameter).</summary>
        public List<string> UsedBy { get; } = [];

        /// <summary>An example path from Application. Null if no path is known.</summary>
        public string? AccessPath { get; set; }

        [JsonIgnore]
        public IEnumerable<MergedMember> VisibleMembers => Members.Values.Where(member => !member.IsHidden);
    }

    /// <summary>The API combined across all versions read.</summary>
    public sealed class MergedApi
    {
        public MergedApi(IReadOnlyList<ApiVersion> versions, Dictionary<string, MergedType> types)
        {
            SourceVersions = versions;
            VersionNames = versions.Select(version => version.Version).Order().ToList();
            Types = types;

            // Keeps the reading order: the analysis depends on it to break ties.
            VisibleObjectsByName = types.Values
                .Where(type => type.Kind == ApiTypeKind.Object && !type.IsHidden)
                .ToDictionary(type => type.Name);
        }

        public IReadOnlyList<ApiVersion> SourceVersions { get; }

        /// <summary>Version names in ascending order, e.g. ["2024", "2025"].</summary>
        public IReadOnlyList<string> VersionNames { get; }

        /// <summary>All types, including hidden ones.</summary>
        public IReadOnlyDictionary<string, MergedType> Types { get; }

        /// <summary>Non-hidden objects, in reading order.</summary>
        public IReadOnlyDictionary<string, MergedType> VisibleObjectsByName { get; }

        /// <summary>Non-hidden objects in alphabetical order, for output.</summary>
        public IEnumerable<MergedType> SortedVisibleObjects =>
            VisibleObjectsByName.Values.OrderBy(type => type.Name, StringComparer.Ordinal);

        /// <summary>Non-hidden enums in alphabetical order, for output.</summary>
        public IEnumerable<MergedType> SortedVisibleEnums =>
            Types.Values
                .Where(type => type.Kind == ApiTypeKind.Enum && !type.IsHidden)
                .OrderBy(type => type.Name, StringComparer.Ordinal);

        /// <summary>True if the type exists and is not hidden, i.e. it has a page in the reference.</summary>
        public bool HasPage(string typeName)
        {
            return Types.TryGetValue(typeName, out var type) && !type.IsHidden;
        }
    }
}
