using InventorBridge.Mcp.Reference;
using Xunit;

namespace InventorBridge.Mcp.Tests;

/// <summary>Company guides from folders outside the repository, next to the general ones.</summary>
public sealed class CompanyGuideTests : IDisposable
{
    private readonly string builtIn = Path.Combine(AppContext.BaseDirectory, "guides");
    private readonly string company = Path.Combine(Path.GetTempPath(), $"inventorbridge-guides-{Guid.NewGuid():N}");

    public CompanyGuideTests()
    {
        Directory.CreateDirectory(company);
        File.WriteAllText(Path.Combine(company, "acme-standards.md"), "# ACME standards\n\n> File names and part numbers at ACME.\n\nPart numbers have 8 digits.\n");
        File.WriteAllText(Path.Combine(company, "README.md"), "# ACME guides\n\nHow to register the server with these guides.\n");
    }

    public void Dispose()
    {
        Directory.Delete(company, recursive: true);
    }

    [Fact]
    public void CompanyGuidesAreListedApartAndCanBeRead()
    {
        var guides = new GuideLibrary(builtIn, [company]);

        var list = guides.List();

        Assert.Contains("workflow: Read first", list);
        Assert.Contains("Company guides", list);
        Assert.Contains("acme-standards: File names and part numbers at ACME.", list);
        Assert.Contains("Part numbers have 8 digits.", guides.Read("acme-standards"));
        Assert.Equal(["acme-standards"], guides.CompanyGuideNames);
    }

    [Fact]
    public void ACompanyGuideCannotReplaceAGeneralOne()
    {
        File.WriteAllText(Path.Combine(company, "workflow.md"), "# Our workflow\n\n> Not the general one.\n");
        var guides = new GuideLibrary(builtIn, [company]);

        Assert.StartsWith("# Workflow", guides.Read("workflow"));
        Assert.Contains("is not served: a guide named \"workflow\" already exists", guides.List());
        Assert.DoesNotContain("workflow", guides.CompanyGuideNames);
    }

    [Fact]
    public void AMissingFolderIsReportedNotFatal()
    {
        var missing = Path.Combine(company, "nowhere");
        var guides = new GuideLibrary(builtIn, [missing, company]);

        Assert.Contains($"the guide folder {missing} (from INVENTORBRIDGE_GUIDES) does not exist", guides.List());
        Assert.Equal(["acme-standards"], guides.CompanyGuideNames);
    }

    [Fact]
    public void WithoutCompanyFoldersOnlyTheGeneralGuidesAreListed()
    {
        var guides = new GuideLibrary(builtIn, []);

        Assert.DoesNotContain("Company guides", guides.List());
        Assert.Empty(guides.CompanyGuideNames);
    }
}
