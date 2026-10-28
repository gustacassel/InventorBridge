# DistanceHeightExtent

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [PartFeatureExtent](../objects/PartFeatureExtent.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.CoilFeatures.Item[…].Extent → (DistanceHeightExtent)`

```csharp
interface DistanceHeightExtent
{
    // Properties
    object Application { get; }
    Parameter Distance { get; }
    PartFeatureExtentDirectionEnum FlangeDirection { get; set; }
    HeightDatumTypeEnum HeightDatumType { get; set; }
    PartFeature Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

**Referenced types:** [HeightDatumTypeEnum](../enums/HeightDatumTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [PartFeature](../objects/PartFeature.md), [PartFeatureExtentDirectionEnum](../enums/PartFeatureExtentDirectionEnum.md)

