# RipDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.BoundaryPatchFeatures.Item[…] → (RipFeatureProxy).Definition`

```csharp
interface RipDefinition
{
    // Properties
    object Application { get; }
    RipFeature Parent { get; }
    Face RipFace { get; set; }
    RipTypeEnum RipType { get; }
    object RipTypeDefinition { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    RipDefinition Copy();
    void SetFaceExtentsRipType(Face RipFace);
    void SetPointToPointRipType(Face RipFace, object PointOne, object PointTwo, object GapSize, PartFeatureExtentDirectionEnum GapSide);
    void SetSinglePointRipType(Face RipFace, object Point, object GapSize, PartFeatureExtentDirectionEnum GapSide);
}
```

**Returned by:** [PointToPointRipTypeDef](../objects/PointToPointRipTypeDef.md).Parent, [RipDefinition](../objects/RipDefinition.md).Copy, [RipFeature](../objects/RipFeature.md).Definition, [RipFeatureProxy](../objects/RipFeatureProxy.md).Definition, [RipFeatures](../objects/RipFeatures.md).CreateRipDefinition, [SinglePointRipTypeDef](../objects/SinglePointRipTypeDef.md).Parent

**Referenced types:** [Face](../objects/Face.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureExtentDirectionEnum](../enums/PartFeatureExtentDirectionEnum.md), [RipFeature](../objects/RipFeature.md), [RipTypeEnum](../enums/RipTypeEnum.md)

