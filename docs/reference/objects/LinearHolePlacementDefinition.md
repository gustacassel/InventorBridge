# LinearHolePlacementDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [HolePlacementDefinition](../objects/HolePlacementDefinition.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.HoleFeatures.Item[…].PlacementDefinition → (LinearHolePlacementDefinition)`

```csharp
interface LinearHolePlacementDefinition
{
    // Properties
    object Application { get; }
    bool DirectionOneReversed { get; set; }
    bool DirectionTwoReversed { get; set; }
    Parameter DistanceOne { get; }
    Parameter DistanceTwo { get; }
    HoleFeature Parent { get; }
    object Plane { get; }
    object ReferenceEntityOne { get; }
    object ReferenceEntityTwo { get; }
    ObjectTypeEnum Type { get; }
}
```

**Referenced types:** [HoleFeature](../objects/HoleFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md)

