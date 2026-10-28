# ExtrudeDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.ExtrudeFeatures.Item[…].Definition`

```csharp
interface ExtrudeDefinition
{
    // Properties
    ObjectCollection AffectedBodies { get; set; }
    ObjectCollection AffectedOccurrences { get; set; }
    object Application { get; }
    PartFeatureExtent Extent { get; }
    PartFeatureExtent ExtentTwo { get; }
    PartFeatureExtentEnum ExtentTwoType { get; }
    PartFeatureExtentEnum ExtentType { get; }
    bool InferiMates { get; set; }
    bool IsTwoDirectional { get; }
    bool MatchShape { get; set; }
    PartFeatureOperationEnum Operation { get; set; }
    ExtrudeFeature Parent { get; }
    Profile Profile { get; set; }
    object TaperAngle { get; set; }
    object TaperAngleTwo { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    ExtrudeDefinition Copy();
    void SetDistanceExtent(object Distance, PartFeatureExtentDirectionEnum ExtentDirection);
    void SetDistanceExtentTwo(object Distance);
    void SetDistanceFromFaceExtent(object FromFace, bool ExtendFromFace, PartFeatureExtentDirectionEnum ExtentDirection, object Distance, object IsTwoDirectional = Missing, object DistanceTwo = Missing);
    void SetFromToExtent(object FromFace, bool ExtendFromFace, object ToFace, bool ExtendToFace);
    void SetThroughAllExtent(PartFeatureExtentDirectionEnum ExtentDirection);
    void SetToExtent(object ToEntity, bool ExtendToFace = false);
    void SetToNextExtent(PartFeatureExtentDirectionEnum ExtentDirection, SurfaceBody Terminator);
}
```

**Returned by:** [ExtrudeDefinition](../objects/ExtrudeDefinition.md).Copy, [ExtrudeFeature](../objects/ExtrudeFeature.md).Definition, [ExtrudeFeatureProxy](../objects/ExtrudeFeatureProxy.md).Definition, [ExtrudeFeatures](../objects/ExtrudeFeatures.md).CreateExtrudeDefinition

**Referenced types:** [ExtrudeFeature](../objects/ExtrudeFeature.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureExtent](../objects/PartFeatureExtent.md), [PartFeatureExtentDirectionEnum](../enums/PartFeatureExtentDirectionEnum.md), [PartFeatureExtentEnum](../enums/PartFeatureExtentEnum.md), [PartFeatureOperationEnum](../enums/PartFeatureOperationEnum.md), [Profile](../objects/Profile.md), [SurfaceBody](../objects/SurfaceBody.md)

