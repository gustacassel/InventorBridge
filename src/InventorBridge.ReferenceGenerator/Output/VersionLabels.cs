using InventorBridge.ReferenceGenerator.Model;

namespace InventorBridge.ReferenceGenerator.Output
{
    /// <summary>Text about which versions something exists in ("2024+", "// since 2026", "// removed in 2027"...).</summary>
    public sealed class VersionLabels
    {
        private readonly IReadOnlyList<string> allVersions;

        public VersionLabels(IReadOnlyList<string> allVersions)
        {
            this.allVersions = allVersions;
        }

        /// <summary>
        /// "2024" if there is a single version; "2024+" if it exists in all of them; otherwise the list ("2025, 2026").
        /// </summary>
        public string Range(IReadOnlyList<string> versions)
        {
            if (versions.Count != allVersions.Count)
            {
                return string.Join(", ", versions);
            }

            return versions.Count == 1 ? versions[0] : $"{versions[0]}+";
        }

        /// <summary>
        /// Comment for the end of a line of code: " // since 2026", " // removed in 2027" or "".
        /// </summary>
        public string Note(IReadOnlyList<string> versions)
        {
            if (allVersions.Count < 2)
            {
                return "";
            }

            var parts = new List<string>();

            if (versions[0] != allVersions[0])
            {
                parts.Add($"since {versions[0]}");
            }

            var lastIndex = IndexOf(versions[^1]);
            if (lastIndex < allVersions.Count - 1)
            {
                parts.Add($"removed in {allVersions[lastIndex + 1]}");
            }

            return parts.Count == 0 ? "" : " // " + string.Join(", ", parts);
        }

        /// <summary><see cref="Note"/> plus the older signatures, when the signature changed between versions.</summary>
        public string MemberNote(MergedMember member)
        {
            var note = Note(member.Versions);

            var currentSignature = SignatureFormatter.Format(member.Latest);
            var olderSignatures = member.SignatureByVersion
                .Where(entry => entry.Value != currentSignature)
                .Select(entry => $"in {entry.Key}: {entry.Value}")
                .ToList();

            if (olderSignatures.Count > 0)
            {
                note += " // signature changed; " + string.Join("; ", olderSignatures);
            }

            return note;
        }

        private int IndexOf(string version)
        {
            for (var i = 0; i < allVersions.Count; i++)
            {
                if (allVersions[i] == version)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
