# OffsetWidthExtent

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [PartFeatureExtent](../objects/PartFeatureExtent.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.CoilFeatures.Item[…].Extent → (OffsetWidthExtent)`

```csharp
interface OffsetWidthExtent
{
    // Properties
    object Application { get; }
    Parameter OffsetDistanceOne { get; }
    Parameter OffsetDistanceTwo { get; }
    object OffsetEntityOne { get; }
    object OffsetEntityTwo { get; }
    PartFeature Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [PartFeature](../objects/PartFeature.md)

