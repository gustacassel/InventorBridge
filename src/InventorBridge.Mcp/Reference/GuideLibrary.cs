using System.Text;

namespace InventorBridge.Mcp.Reference
{
    /// <summary>
    /// The hand-written guides (docs/guides), copied next to the server at build time and served by the guide
    /// tool, so the agent can read them from any folder.
    /// </summary>
    /// <remarks>Each guide starts with "# Title" and a "> one-line summary" line, shown in the list.</remarks>
    public sealed class GuideLibrary
    {
        private const string FolderName = "guides";
        private const string SummaryPrefix = "> ";

        private readonly string directory = Path.Combine(AppContext.BaseDirectory, FolderName);

        /// <summary>The list of guides with their summaries.</summary>
        public string List()
        {
            var text = new StringBuilder();
            text.AppendLine("Guides (call guide with a name to read one):");

            foreach (var path in GuidePaths())
            {
                var summary = File.ReadLines(path)
                    .FirstOrDefault(line => line.StartsWith(SummaryPrefix, StringComparison.Ordinal))?[SummaryPrefix.Length..]
                    ?? "";
                text.AppendLine($"  {Path.GetFileNameWithoutExtension(path)}: {summary}");
            }

            return text.ToString();
        }

        /// <summary>The guide's text, or null if there is no guide with that name.</summary>
        public string? Read(string name)
        {
            var path = GuidePaths().FirstOrDefault(candidate =>
                string.Equals(Path.GetFileNameWithoutExtension(candidate), name.Trim(), StringComparison.OrdinalIgnoreCase));

            return path is null ? null : File.ReadAllText(path);
        }

        /// <exception cref="InvalidOperationException">The guides folder is missing.</exception>
        private List<string> GuidePaths()
        {
            if (!Directory.Exists(directory))
            {
                throw new InvalidOperationException(
                    $"The guides were not found at {directory}. Build InventorBridge.Mcp from the repository: " +
                    "the build copies docs/guides next to the server.");
            }

            return Directory.EnumerateFiles(directory, "*.md").Order(StringComparer.Ordinal).ToList();
        }
    }
}
