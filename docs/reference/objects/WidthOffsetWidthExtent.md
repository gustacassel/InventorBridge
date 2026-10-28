# WidthOffsetWidthExtent

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [PartFeatureExtent](../objects/PartFeatureExtent.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.CoilFeatures.Item[…].Extent → (WidthOffsetWidthExtent)`

```csharp
interface WidthOffsetWidthExtent
{
    // Properties
    object Application { get; }
    Parameter OffsetDistance { get; }
    object OffsetEntity { get; }
    PartFeature Parent { get; }
    bool PositiveDirection { get; }
    ObjectTypeEnum Type { get; }
    Parameter Width { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [PartFeature](../objects/PartFeature.md)

