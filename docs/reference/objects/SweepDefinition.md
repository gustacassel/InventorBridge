# SweepDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.SweepFeatures.Item[…].Definition`

```csharp
interface SweepDefinition
{
    // Properties
    ObjectCollection AffectedBodies { get; set; }
    ObjectCollection AffectedOccurrences { get; set; }
    object Application { get; }
    Path GuideRail { get; set; }
    object GuideSurface { get; set; }
    PartFeatureOperationEnum Operation { get; set; }
    SweepFeature Parent { get; }
    Path Path { get; set; }
    Profile Profile { get; set; }
    SweepProfileOrientationEnum ProfileOrientation { get; set; }
    SweepProfileScalingEnum ProfileScaling { get; set; }
    SweepTypeEnum SweepType { get; set; }
    object TaperAngle { get; set; }
    object TwistAngle { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    SweepDefinition Copy();
    void GetSectionTwists(out ObjectCollection SectionTwistPoints, out ObjectCollection SectionTwistVectors);
    void SetSectionTwists(ObjectCollection SectionTwistPoints, ObjectCollection SectionTwistVectors);
}
```

**Returned by:** [SweepDefinition](../objects/SweepDefinition.md).Copy, [SweepFeature](../objects/SweepFeature.md).Definition, [SweepFeatureProxy](../objects/SweepFeatureProxy.md).Definition, [SweepFeatures](../objects/SweepFeatures.md).CreateSweepDefinition

**Referenced types:** [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureOperationEnum](../enums/PartFeatureOperationEnum.md), [Path](../objects/Path.md), [Profile](../objects/Profile.md), [SweepFeature](../objects/SweepFeature.md), [SweepProfileOrientationEnum](../enums/SweepProfileOrientationEnum.md), [SweepProfileScalingEnum](../enums/SweepProfileScalingEnum.md), [SweepTypeEnum](../enums/SweepTypeEnum.md)

