# ConcentricHolePlacementDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [HolePlacementDefinition](../objects/HolePlacementDefinition.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.HoleFeatures.Item[…].PlacementDefinition → (ConcentricHolePlacementDefinition)`

```csharp
interface ConcentricHolePlacementDefinition
{
    // Properties
    object Application { get; }
    object ConcentricReference { get; }
    HoleFeature Parent { get; }
    object Plane { get; }
    ObjectTypeEnum Type { get; }
}
```

**Referenced types:** [HoleFeature](../objects/HoleFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

