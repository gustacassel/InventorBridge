# FromToWidthExtent

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [PartFeatureExtent](../objects/PartFeatureExtent.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.CoilFeatures.Item[…].Extent → (FromToWidthExtent)`

```csharp
interface FromToWidthExtent
{
    // Properties
    object Application { get; }
    Edge Edge { get; } // hidden in 2025, 2026, 2027: there, prefer the newer members
    object FromEntity { get; }
    PartFeature Parent { get; }
    object ToEntity { get; }
    ObjectTypeEnum Type { get; }
}
```

**Referenced types:** [Edge](../objects/Edge.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeature](../objects/PartFeature.md)

