# PartFeatureExtent

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.CoilFeatures.Item[…].Extent`

```csharp
interface PartFeatureExtent
{
    // Properties
    object Application { get; }
    PartFeature Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [CoilFeature](../objects/CoilFeature.md).Extent, [CoilFeatureProxy](../objects/CoilFeatureProxy.md).Extent, [ContourFlangeDefinition](../objects/ContourFlangeDefinition.md).DistanceWidthExtentTwo, [ContourFlangeDefinition](../objects/ContourFlangeDefinition.md).WidthExtent, [CutDefinition](../objects/CutDefinition.md).Extent, [ExtrudeDefinition](../objects/ExtrudeDefinition.md).Extent, [ExtrudeDefinition](../objects/ExtrudeDefinition.md).ExtentTwo, [FlangeDefinition](../objects/FlangeDefinition.md).HeightExtent, [FlangeEdgeSet](../objects/FlangeEdgeSet.md).WidthExtent, [HemDefinition](../objects/HemDefinition.md).WidthExtent, [HoleFeature](../objects/HoleFeature.md).Extent, [HoleFeatureProxy](../objects/HoleFeatureProxy.md).Extent, [RevolveFeature](../objects/RevolveFeature.md).Extent, [RevolveFeature](../objects/RevolveFeature.md).ExtentTwo, [RevolveFeatureProxy](../objects/RevolveFeatureProxy.md).Extent, [RevolveFeatureProxy](../objects/RevolveFeatureProxy.md).ExtentTwo, [SlotDefinition](../objects/SlotDefinition.md).Extent

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeature](../objects/PartFeature.md)

