using System.Text;

namespace InventorBridge.Mcp.Reference;

/// <summary>
/// The guides served by the guide tool: the general ones (docs/guides, copied next to the server at build
/// time) and a company's own, from folders outside this repository.
/// </summary>
/// <remarks>
/// Each guide starts with "# Title" and a "> one-line summary" line, shown in the list. Company guides come from
/// the folders in the INVENTORBRIDGE_GUIDES environment variable (separated by ';'), set where the server is
/// registered, so each company keeps its standards (numbering, ERP codes, templates, vault rules) in its own
/// repository. A company guide cannot take the name of a general one: it would silently change what the
/// general guide says. Files are read on every call, so edits show up without restarting the server.
/// </remarks>
public sealed class GuideLibrary
{
    public const string FoldersVariable = "INVENTORBRIDGE_GUIDES";

    private const string FolderName = "guides";
    private const string SummaryPrefix = "> ";

    private readonly string builtInDirectory;
    private readonly IReadOnlyList<string> companyDirectories;

    public GuideLibrary()
        : this(Path.Combine(AppContext.BaseDirectory, FolderName), FoldersFromEnvironment())
    {
    }

    internal GuideLibrary(string builtInDirectory, IEnumerable<string> companyDirectories)
    {
        this.builtInDirectory = builtInDirectory;
        this.companyDirectories = companyDirectories.ToList();
    }

    /// <summary>The company guides' names, for the server instructions; empty when there are none.</summary>
    public IReadOnlyList<string> CompanyGuideNames => Collect().Company.Select(guide => guide.Name).ToList();

    /// <summary>The list of guides with their summaries, company guides apart, and any problem found.</summary>
    public string List()
    {
        var (general, company, problems) = Collect();
        var text = new StringBuilder();
        text.AppendLine("Guides (call guide with a name to read one):");

        foreach (var guide in general)
        {
            text.AppendLine($"  {guide.Name}: {Summary(guide.Path)}");
        }

        if (company.Count > 0)
        {
            text.AppendLine();
            text.AppendLine("Company guides (this organization's own standards; where they differ from the guides above, they win):");
            foreach (var guide in company)
            {
                text.AppendLine($"  {guide.Name}: {Summary(guide.Path)}  [{Path.GetDirectoryName(guide.Path)}]");
            }
        }

        if (problems.Count > 0)
        {
            text.AppendLine();
            foreach (var problem in problems)
            {
                text.AppendLine($"Note: {problem}");
            }
        }

        return text.ToString();
    }

    /// <summary>The guide's text, or null if there is no guide with that name.</summary>
    public string? Read(string name)
    {
        var (general, company, _) = Collect();
        var guide = general.Concat(company).FirstOrDefault(candidate =>
            string.Equals(candidate.Name, name.Trim(), StringComparison.OrdinalIgnoreCase));

        return guide is null ? null : File.ReadAllText(guide.Path);
    }

    private sealed record Guide(string Name, string Path);

    /// <exception cref="InvalidOperationException">The general guides folder is missing.</exception>
    private (List<Guide> General, List<Guide> Company, List<string> Problems) Collect()
    {
        if (!Directory.Exists(builtInDirectory))
        {
            throw new InvalidOperationException(
                $"""
                    The guides were not found at {builtInDirectory}. Build InventorBridge.Mcp from the repository:
                    the build copies docs/guides next to the server.
                    """);
        }

        var general = GuidesIn(builtInDirectory);
        var company = new List<Guide>();
        var problems = new List<string>();
        var taken = new HashSet<string>(general.Select(guide => guide.Name), StringComparer.OrdinalIgnoreCase);

        foreach (var directory in companyDirectories)
        {
            if (!Directory.Exists(directory))
            {
                problems.Add($"the guide folder {directory} (from {FoldersVariable}) does not exist.");
                continue;
            }

            // A README explains the folder to people; it is not a guide.
            foreach (var guide in GuidesIn(directory).Where(guide => !guide.Name.Equals("README", StringComparison.OrdinalIgnoreCase)))
            {
                if (taken.Add(guide.Name))
                {
                    company.Add(guide);
                }
                else
                {
                    problems.Add($"{guide.Path} is not served: a guide named \"{guide.Name}\" already exists. Rename the file.");
                }
            }
        }

        return (general, company, problems);
    }

    private static List<Guide> GuidesIn(string directory)
    {
        return Directory.EnumerateFiles(directory, "*.md")
            .Order(StringComparer.Ordinal)
            .Select(path => new Guide(Path.GetFileNameWithoutExtension(path), path))
            .ToList();
    }

    private static string Summary(string path)
    {
        return File.ReadLines(path)
            .FirstOrDefault(line => line.StartsWith(SummaryPrefix, StringComparison.Ordinal))?[SummaryPrefix.Length..]
            ?? "";
    }

    private static IEnumerable<string> FoldersFromEnvironment()
    {
        var value = System.Environment.GetEnvironmentVariable(FoldersVariable) ?? "";
        return value.Split(';', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
            .Select(folder => System.Environment.ExpandEnvironmentVariables(folder.Trim('"')));
    }
}
