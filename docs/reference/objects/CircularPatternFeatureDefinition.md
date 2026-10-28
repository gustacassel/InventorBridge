# CircularPatternFeatureDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.CircularPatternFeatures.Item[…].Definition`

```csharp
interface CircularPatternFeatureDefinition
{
    // Properties
    ObjectCollection AffectedBodies { get; set; }
    ObjectCollection AffectedOccurrences { get; set; }
    object Angle { get; set; }
    object Application { get; }
    PatternBoundarySetting BoundarySetting { get; set; } // since 2025
    PatternComputeTypeEnum ComputeType { get; set; }
    object Count { get; set; }
    bool HasBoundarySettingConfigured { get; set; } // since 2025
    IrregularDistributionSet IrregularDistributionSet { get; } // since 2027
    bool LockRotation { get; set; }
    bool MidPlanePattern { get; set; }
    bool NaturalRotationAxisDirection { get; set; }
    PartFeatureOperationEnum Operation { get; set; }
    ObjectCollection ParentFeatures { get; set; }
    bool PatternOfBody { get; }
    object PatternRadiusPoint { get; set; }
    PatternPositioningMethodEnum PositioningMethod { get; set; }
    object RotationAxis { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    CircularPatternFeatureDefinition Copy();
}
```

**Returned by:** [CircularPatternFeature](../objects/CircularPatternFeature.md).Definition, [CircularPatternFeatureDefinition](../objects/CircularPatternFeatureDefinition.md).Copy, [CircularPatternFeatureProxy](../objects/CircularPatternFeatureProxy.md).Definition, [CircularPatternFeatures](../objects/CircularPatternFeatures.md).CreateDefinition

**Referenced types:** [IrregularDistributionSet](../objects/IrregularDistributionSet.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureOperationEnum](../enums/PartFeatureOperationEnum.md), [PatternBoundarySetting](../objects/PatternBoundarySetting.md), [PatternComputeTypeEnum](../enums/PatternComputeTypeEnum.md), [PatternPositioningMethodEnum](../enums/PatternPositioningMethodEnum.md)

