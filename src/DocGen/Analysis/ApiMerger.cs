using DocGen.Model;
using DocGen.Output;

namespace DocGen.Analysis
{
    /// <summary>
    /// Combines the versions read into a single model. Each type, member and enum value keeps the versions
    /// it exists in; when something changes between versions, the newest version's form wins.
    /// </summary>
    public static class ApiMerger
    {
        public static MergedApi Merge(IReadOnlyList<ApiVersion> versions)
        {
            var types = new Dictionary<string, MergedType>();

            foreach (var version in versions.OrderBy(version => version.Version))
            {
                foreach (var type in version.Types.Values)
                {
                    var mergedType = GetOrAddType(types, type);
                    mergedType.IsHidden = type.IsHidden;
                    mergedType.VTable = type.VTable;
                    mergedType.Versions.Add(version.Version);

                    foreach (var member in type.Members)
                    {
                        MergeMember(mergedType, member, version.Version);
                    }

                    foreach (var enumValue in type.EnumValues)
                    {
                        MergeEnumValue(mergedType, enumValue, version.Version);
                    }
                }
            }

            return new MergedApi(versions, types);
        }

        private static MergedType GetOrAddType(Dictionary<string, MergedType> types, ApiType type)
        {
            if (!types.TryGetValue(type.Name, out var mergedType))
            {
                mergedType = new MergedType { Name = type.Name, Kind = type.Kind };
                types[type.Name] = mergedType;
            }

            return mergedType;
        }

        private static void MergeMember(MergedType mergedType, ApiMember member, string version)
        {
            if (!mergedType.Members.TryGetValue(member.Key, out var mergedMember))
            {
                mergedMember = new MergedMember { Name = member.Name, Kind = member.Kind, Latest = member };
                mergedType.Members[member.Key] = mergedMember;
            }

            mergedMember.Latest = member;
            mergedMember.Versions.Add(version);
            mergedMember.SignatureByVersion[version] = SignatureFormatter.Format(member);
        }

        private static void MergeEnumValue(MergedType mergedType, ApiEnumValue enumValue, string version)
        {
            if (!mergedType.EnumValues.TryGetValue(enumValue.Name, out var mergedValue))
            {
                mergedValue = new MergedEnumValue { Name = enumValue.Name };
                mergedType.EnumValues[enumValue.Name] = mergedValue;
            }

            mergedValue.Value = enumValue.Value;
            mergedValue.Versions.Add(version);
        }
    }
}
