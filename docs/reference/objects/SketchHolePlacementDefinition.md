# SketchHolePlacementDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [HolePlacementDefinition](../objects/HolePlacementDefinition.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.HoleFeatures.Item[…].PlacementDefinition → (SketchHolePlacementDefinition)`

```csharp
interface SketchHolePlacementDefinition
{
    // Properties
    object Application { get; }
    ObjectCollection HoleCenterPoints { get; set; }
    HoleFeature Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [HoleFeatures](../objects/HoleFeatures.md).CreateSketchPlacementDefinition

**Referenced types:** [HoleFeature](../objects/HoleFeature.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

