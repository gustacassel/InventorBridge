# PointHolePlacementDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [HolePlacementDefinition](../objects/HolePlacementDefinition.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.HoleFeatures.Item[…].PlacementDefinition → (PointHolePlacementDefinition)`

```csharp
interface PointHolePlacementDefinition
{
    // Properties
    object Application { get; }
    object Direction { get; }
    HoleFeature Parent { get; }
    object Point { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [HoleFeatures](../objects/HoleFeatures.md).CreatePointPlacementDefinition

**Referenced types:** [HoleFeature](../objects/HoleFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

