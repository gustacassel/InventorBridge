# HolePlacementDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.HoleFeatures.Item[…].PlacementDefinition`

```csharp
interface HolePlacementDefinition
{
    // Properties
    object Application { get; }
    HoleFeature Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [HoleFeature](../objects/HoleFeature.md).PlacementDefinition, [HoleFeatureProxy](../objects/HoleFeatureProxy.md).PlacementDefinition

**Referenced types:** [HoleFeature](../objects/HoleFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

