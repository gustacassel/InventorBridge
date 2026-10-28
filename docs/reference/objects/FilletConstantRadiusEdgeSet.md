# FilletConstantRadiusEdgeSet

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [FilletRadiusEdgeSet](../objects/FilletRadiusEdgeSet.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.FilletFeatures.Item[…].FilletDefinition.EdgeSetItem[…] → (FilletConstantRadiusEdgeSet)`

```csharp
interface FilletConstantRadiusEdgeSet
{
    // Properties
    bool AllFillets { get; }
    bool AllRounds { get; }
    object Application { get; }
    ContinuityTypeEnum ContinuityType { get; set; }
    EdgeCollection Edges { get; }
    bool InvertedFillet { get; set; }
    Parameter Radius { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [FilletDefinition](../objects/FilletDefinition.md).AddConstantRadiusEdgeSet

**Referenced types:** [ContinuityTypeEnum](../enums/ContinuityTypeEnum.md), [EdgeCollection](../objects/EdgeCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md)

