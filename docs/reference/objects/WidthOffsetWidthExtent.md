# WidthOffsetWidthExtent

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [PartFeatureExtent](../objects/PartFeatureExtent.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.CoilFeatures.Item[…].Extent → (WidthOffsetWidthExtent)`

```csharp
interface WidthOffsetWidthExtent
{
    // Properties
    object Application { get; }
    Edge Edge { get; } // hidden in 2025, 2026, 2027: there, prefer the newer members
    Parameter OffsetDistance { get; }
    object OffsetEntity { get; }
    PartFeature Parent { get; }
    bool PositiveDirection { get; }
    ObjectTypeEnum Type { get; }
    Parameter Width { get; }
}
```

**Referenced types:** [Edge](../objects/Edge.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [PartFeature](../objects/PartFeature.md)

