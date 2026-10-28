# DistanceFromFaceExtent

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [PartFeatureExtent](../objects/PartFeatureExtent.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.CoilFeatures.Item[…].Extent → (DistanceFromFaceExtent)`

```csharp
interface DistanceFromFaceExtent
{
    // Properties
    PartFeatureExtentDirectionEnum AlternateSolutionDirection { get; set; }
    object Application { get; }
    PartFeatureExtentDirectionEnum Direction { get; set; }
    object Distance { get; }
    object DistanceTwo { get; }
    bool ExtendFromFace { get; set; }
    object FromFace { get; set; }
    bool IsTwoDirectional { get; set; }
    bool MinimumSolution { get; set; }
    PartFeature Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeature](../objects/PartFeature.md), [PartFeatureExtentDirectionEnum](../enums/PartFeatureExtentDirectionEnum.md)

