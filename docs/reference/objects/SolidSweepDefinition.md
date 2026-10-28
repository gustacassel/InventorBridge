# SolidSweepDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.SweepFeatures.Item[…].SolidSweepDefinition`

```csharp
interface SolidSweepDefinition
{
    // Properties
    ObjectCollection AffectedBodies { get; set; }
    object AlignToVector { get; set; }
    object Application { get; }
    bool KeepToolbody { get; set; }
    PartFeatureOperationEnum Operation { get; set; }
    SweepProfileOrientationEnum Orientation { get; set; }
    SweepFeature Parent { get; }
    Path Path { get; set; }
    SurfaceBody ToolBody { get; set; }
    object TwistAngle { get; set; }
    object TwistAxis { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    SolidSweepDefinition Copy();
    void SetOrientationInfo(SweepProfileOrientationEnum Orientation, object AlignToVector = Missing);
    void SetTwistInfo(object TwistAngle, object TwistAxis = Missing);
}
```

**Returned by:** [SolidSweepDefinition](../objects/SolidSweepDefinition.md).Copy, [SweepFeature](../objects/SweepFeature.md).SolidSweepDefinition, [SweepFeatureProxy](../objects/SweepFeatureProxy.md).SolidSweepDefinition, [SweepFeatures](../objects/SweepFeatures.md).CreateSolidSweepDefinition

**Referenced types:** [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureOperationEnum](../enums/PartFeatureOperationEnum.md), [Path](../objects/Path.md), [SurfaceBody](../objects/SurfaceBody.md), [SweepFeature](../objects/SweepFeature.md), [SweepProfileOrientationEnum](../enums/SweepProfileOrientationEnum.md)

