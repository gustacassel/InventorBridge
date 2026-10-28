# FromToExtent

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [PartFeatureExtent](../objects/PartFeatureExtent.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.CoilFeatures.Item[…].Extent → (FromToExtent)`

```csharp
interface FromToExtent
{
    // Properties
    object Application { get; }
    PartFeatureExtentDirectionEnum Direction { get; set; }
    bool ExtendFromFace { get; set; }
    bool ExtendToFace { get; set; }
    object FromFace { get; set; }
    bool MinimumSolution { get; set; }
    PartFeature Parent { get; }
    object ToFace { get; set; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeature](../objects/PartFeature.md), [PartFeatureExtentDirectionEnum](../enums/PartFeatureExtentDirectionEnum.md)

