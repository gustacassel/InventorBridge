# RibDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.RibFeatures.Item[…].Definition`

```csharp
interface RibDefinition
{
    // Properties
    SurfaceBody AffectedBody { get; set; }
    object Application { get; }
    BossSets BossSets { get; }
    bool DirectionReversed { get; set; }
    IntPtr DraftAngle { get; set; }
    bool DraftProfileEnds { get; set; }
    bool ExtendProfile { get; set; }
    IntPtr ExtentDistance { get; }
    RibFeatureExtentEnum ExtentType { get; }
    bool IsRib { get; set; }
    RibFeature Parent { get; }
    ObjectCollection ProfileCurves { get; set; }
    IntPtr Thickness { get; set; }
    PartFeatureExtentDirectionEnum ThicknessDirection { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    RibDefinition Copy();
    void GetThicknessPlane(out RibThicknessPlaneEnum HoldThicknessAt, out object NeutralGeometry);
    void SetFiniteExtent(object Distance);
    void SetThicknessPlane(RibThicknessPlaneEnum HoldThicknessAt, object NeutralGeometry = Missing);
    void SetToNextExtent();
}
```

**Returned by:** [BossSet](../objects/BossSet.md).Parent, [RibDefinition](../objects/RibDefinition.md).Copy, [RibFeature](../objects/RibFeature.md).Definition, [RibFeatureProxy](../objects/RibFeatureProxy.md).Definition, [RibFeatures](../objects/RibFeatures.md).CreateDefinition

**Referenced types:** [BossSets](../objects/BossSets.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureExtentDirectionEnum](../enums/PartFeatureExtentDirectionEnum.md), [RibFeature](../objects/RibFeature.md), [RibFeatureExtentEnum](../enums/RibFeatureExtentEnum.md), [RibThicknessPlaneEnum](../enums/RibThicknessPlaneEnum.md), [SurfaceBody](../objects/SurfaceBody.md)

