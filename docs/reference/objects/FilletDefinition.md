# FilletDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.FilletFeatures.Item[…].FilletDefinition`

```csharp
interface FilletDefinition
{
    // Properties
    object Application { get; }
    int EdgeSetCount { get; }
    FilletRadiusEdgeSet EdgeSetItem[int Index] { get; }
    FilletConstantRadiusFaceSet FaceSet { get; }
    FilletTypeEnum FilletType { get; }
    FilletFullRoundSet FullRoundSet { get; }
    FilletFeature Parent { get; }
    int SetbackVertexCount { get; }
    FilletSetbackVertex SetbackVertexItem[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    FilletConstantRadiusEdgeSet AddConstantRadiusEdgeSet(EdgeCollection Edges, object ConstantRadius);
    FilletConstantRadiusFaceSet AddFaceSet(FaceCollection FacesOne, FaceCollection FacesTwo, object Radius, bool IncludeTangentFaces = true, object BiasPoint = Missing, bool FacesOneReverseDirection = false, bool FacesTwoReverseDirection = false);
    FilletFullRoundSet AddFullRoundSet(FaceCollection SideFacesOne, FaceCollection CenterFaces, FaceCollection SideFacesTwo, bool IncludeTangentFaces = true);
    FilletVariableRadiusEdgeSet AddVariableRadiusEdgeSet(EdgeCollection Edges, object StartRadius, object EndRadius);
}
```

**Returned by:** [FilletFeature](../objects/FilletFeature.md).FilletDefinition, [FilletFeatureProxy](../objects/FilletFeatureProxy.md).FilletDefinition, [FilletFeatures](../objects/FilletFeatures.md).CreateFilletDefinition

**Referenced types:** [EdgeCollection](../objects/EdgeCollection.md), [FaceCollection](../objects/FaceCollection.md), [FilletConstantRadiusEdgeSet](../objects/FilletConstantRadiusEdgeSet.md), [FilletConstantRadiusFaceSet](../objects/FilletConstantRadiusFaceSet.md), [FilletFeature](../objects/FilletFeature.md), [FilletFullRoundSet](../objects/FilletFullRoundSet.md), [FilletRadiusEdgeSet](../objects/FilletRadiusEdgeSet.md), [FilletSetbackVertex](../objects/FilletSetbackVertex.md), [FilletTypeEnum](../enums/FilletTypeEnum.md), [FilletVariableRadiusEdgeSet](../objects/FilletVariableRadiusEdgeSet.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

