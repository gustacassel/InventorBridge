using InventorBridge.ReferenceGenerator.Analysis;
using InventorBridge.ReferenceGenerator.Model;
using InventorBridge.ReferenceGenerator.Output;
using Xunit;

namespace InventorBridge.Mcp.Tests;

public sealed class ApiMergerTests
{
    // Like BreakOperations.Add, the method on 2024, which 2027 hides in favor of AddWithOptions.
    [Fact]
    public void KeepsAMemberHiddenOnlyInNewerVersions()
    {
        var api = ApiMerger.Merge(
        [
            Version("2024", Method("Add", hidden: false)),
            Version("2025", Method("Add", hidden: false)),
            Version("2026", Method("Add", hidden: true)),
        ]);

        var add = api.Types["BreakOperations"].Members["Method:Add"];
        Assert.False(add.IsHidden);
        Assert.Equal(["2024", "2025"], add.VisibleVersions);
        Assert.False(add.Latest.IsHidden);

        var labels = new VersionLabels(api.VersionNames);
        Assert.Equal("2024, 2025", labels.Range(add.VisibleVersions));
        Assert.Contains("hidden in 2026", labels.MemberNote(add));
        Assert.DoesNotContain("signature changed", labels.MemberNote(add));
    }

    [Fact]
    public void LeavesOutAMemberHiddenInEveryVersion()
    {
        var api = ApiMerger.Merge([Version("2024", Method("Add", hidden: true)), Version("2025", Method("Add", hidden: true))]);

        Assert.True(api.Types["BreakOperations"].Members["Method:Add"].IsHidden);
        Assert.Empty(api.Types["BreakOperations"].VisibleMembers);
    }

    private static ApiMember Method(string name, bool hidden)
    {
        return new ApiMember { Name = name, Kind = ApiMemberKind.Method, ReturnType = "BreakOperation", IsHidden = hidden, Parameters = [] };
    }

    private static ApiVersion Version(string version, ApiMember member)
    {
        var type = new ApiType { Name = "BreakOperations", Kind = ApiTypeKind.Object, Members = [member] };
        return new ApiVersion { Version = version, AssemblyVersion = "0", Types = new Dictionary<string, ApiType> { [type.Name] = type } };
    }
}
