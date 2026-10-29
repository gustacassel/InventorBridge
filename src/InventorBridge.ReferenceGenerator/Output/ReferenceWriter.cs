using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using InventorBridge.ReferenceGenerator.Model;

namespace InventorBridge.ReferenceGenerator.Output
{
    /// <summary>
    /// Writes the complete reference:
    /// - objects/{Name}.md and enums/{Name}.md, one page per type;
    /// - index.md;
    /// - members.tsv, one member per line, for grep;
    /// - _data/inventor-api.json, the full model for other tools.
    /// </summary>
    public sealed class ReferenceWriter
    {
        private static readonly string[] GeneratedFolders = ["objects", "enums", "_data"];

        private static readonly JsonSerializerOptions JsonOptions = new()
        {
            Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) },
        };

        private readonly MergedApi api;
        private readonly VersionLabels versionLabels;
        private readonly PageRenderer pageRenderer;

        public ReferenceWriter(MergedApi api)
        {
            this.api = api;
            versionLabels = new VersionLabels(api.VersionNames);
            pageRenderer = new PageRenderer(api, versionLabels);
        }

        public void WriteAll(string outputDirectory)
        {
            RecreateGeneratedFolders(outputDirectory);

            foreach (var type in api.SortedVisibleObjects)
            {
                File.WriteAllText(Path.Combine(outputDirectory, "objects", type.Name + ".md"), pageRenderer.RenderObjectPage(type));
            }

            foreach (var type in api.SortedVisibleEnums)
            {
                File.WriteAllText(Path.Combine(outputDirectory, "enums", type.Name + ".md"), pageRenderer.RenderEnumPage(type));
            }

            File.WriteAllText(Path.Combine(outputDirectory, "index.md"), pageRenderer.RenderIndexPage());
            File.WriteAllText(Path.Combine(outputDirectory, "members.tsv"), BuildMembersTsv());
            File.WriteAllText(Path.Combine(outputDirectory, "_data", "inventor-api.json"), BuildJson());
        }

        /// <summary>Deletes and recreates only the generated folders, so no page is left behind for a type that no longer exists.</summary>
        private static void RecreateGeneratedFolders(string outputDirectory)
        {
            foreach (var folder in GeneratedFolders)
            {
                var path = Path.Combine(outputDirectory, folder);
                if (Directory.Exists(path))
                {
                    Directory.Delete(path, recursive: true);
                }

                Directory.CreateDirectory(path);
            }
        }

        /// <summary>Columns: type, member, kind (property, method, event, enum-value), signature, versions.</summary>
        private string BuildMembersTsv()
        {
            var tsv = new StringBuilder("type\tmember\tkind\tsignature\tversions\n");

            foreach (var type in api.SortedVisibleObjects)
            {
                var members = type.VisibleMembers
                    .OrderBy(member => member.Kind)
                    .ThenBy(member => member.Name, StringComparer.Ordinal);

                foreach (var member in members)
                {
                    var kind = member.Kind.ToString().ToLowerInvariant();
                    var signature = SignatureFormatter.Format(member.Latest);
                    tsv.Append($"{type.Name}\t{member.Name}\t{kind}\t{signature}\t{versionLabels.Range(member.Versions)}\n");
                }
            }

            foreach (var type in api.SortedVisibleEnums)
            {
                foreach (var value in type.EnumValues.Values.OrderBy(value => value.Value))
                {
                    tsv.Append($"{type.Name}\t{value.Name}\tenum-value\t{value.Name} = {value.Value}\t{versionLabels.Range(value.Versions)}\n");
                }
            }

            return tsv.ToString();
        }

        private string BuildJson()
        {
            var document = new
            {
                versions = api.SourceVersions.Select(version => new { version.Version, version.AssemblyVersion }),
                types = api.Types.Values.OrderBy(type => type.Name, StringComparer.Ordinal),
            };

            return JsonSerializer.Serialize(document, JsonOptions);
        }
    }
}
