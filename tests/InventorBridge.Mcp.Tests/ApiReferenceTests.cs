using InventorBridge.Mcp.Reference;
using Xunit;

namespace InventorBridge.Mcp.Tests
{
    /// <summary>Runs against the real generated reference, which the build copies next to the server.</summary>
    public sealed class ApiReferenceTests
    {
        private readonly ApiReference reference = new();

        [Fact]
        public void ATypeNameReturnsItsPage()
        {
            var text = reference.Lookup("ExtrudeFeatures", null);

            Assert.Contains("interface ExtrudeFeatures", text);
            Assert.Contains("ExtrudeDefinition CreateExtrudeDefinition(Profile Profile, PartFeatureOperationEnum Operation);", text);
            Assert.Contains("How to get it", text);
        }

        [Fact]
        public void TypeNamesAreCaseInsensitive()
        {
            Assert.Contains("interface ExtrudeFeatures", reference.Lookup("extrudefeatures", null));
        }

        [Fact]
        public void TypeDotTextListsTheMatchingMembers()
        {
            var text = reference.Lookup("ExtrudeFeatures.add", null);

            Assert.Contains("ExtrudeFeature Add(ExtrudeDefinition Definition);", text);
            Assert.DoesNotContain("CreateExtrudeDefinition", text);
        }

        [Fact]
        public void EnumValuesCanBeSearchedByName()
        {
            var text = reference.Lookup("ObjectTypeEnum.kExtrudeFeatureObject", null);

            Assert.Contains("kExtrudeFeatureObject = ", text);
        }

        [Fact]
        public void OtherTextSearchesTypesAndMembers()
        {
            var text = reference.Lookup("AddInsertConstraint", null);

            Assert.Contains("AssemblyConstraints: InsertConstraint AddInsertConstraint(", text);
        }

        [Fact]
        public void MembersFromLaterVersionsAreHidden()
        {
            const string memberLine = "DarkSiteLevelEnum DarkSiteLevel { get; }";

            Assert.Contains(memberLine, reference.Lookup("Application", null));
            Assert.DoesNotContain(memberLine, reference.Lookup("Application", 2024));
            Assert.Contains("not in Inventor 2024", reference.Lookup("Application.DarkSite", 2024));
        }

        [Fact]
        public void ArraysTheCallFillsArePassedByRef()
        {
            var text = reference.Lookup("CurveEvaluator.GetPointAtParam", null);

            Assert.Contains("void GetPointAtParam(ref double[] Params, ref double[] Points);", text);
        }

        [Fact]
        public void AnUnknownNameSaysSo()
        {
            Assert.Contains("Nothing matches", reference.Lookup("zzzzzz", null));
        }
    }
}
