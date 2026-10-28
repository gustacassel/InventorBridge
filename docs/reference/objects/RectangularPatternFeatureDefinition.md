# RectangularPatternFeatureDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.RectangularPatternFeatures.Item[…].Definition`

```csharp
interface RectangularPatternFeatureDefinition
{
    // Properties
    ObjectCollection AffectedBodies { get; set; }
    ObjectCollection AffectedOccurrences { get; set; }
    object Application { get; }
    PatternBoundarySetting BoundarySetting { get; set; } // since 2025
    PatternComputeTypeEnum ComputeType { get; set; }
    bool HasBoundarySettingConfigured { get; set; } // since 2025
    bool NaturalXDirection { get; set; }
    bool NaturalYDirection { get; set; }
    PartFeatureOperationEnum Operation { get; set; }
    PatternOrientationEnum OrientationMethod { get; set; }
    ObjectCollection ParentFeatures { get; set; }
    bool PatternOfBody { get; }
    ObjectTypeEnum Type { get; }
    object XCount { get; set; }
    object XDirectionEntity { get; set; }
    IrregularDistributionSet XDirectionIrregularDistributionSet { get; } // since 2027
    bool XDirectionMidPlanePattern { get; set; }
    PatternSpacingTypeEnum XDirectionSpacingType { get; set; }
    object XDirectionStartPoint { get; set; }
    object XSpacing { get; set; }
    object YCount { get; set; }
    object YDirectionEntity { get; set; }
    IrregularDistributionSet YDirectionIrregularDistributionSet { get; } // since 2027
    bool YDirectionMidPlanePattern { get; set; }
    PatternSpacingTypeEnum YDirectionSpacingType { get; set; }
    object YDirectionStartPoint { get; set; }
    object YSpacing { get; set; }
    // Methods
    RectangularPatternFeatureDefinition Copy();
}
```

**Returned by:** [RectangularPatternFeature](../objects/RectangularPatternFeature.md).Definition, [RectangularPatternFeatureDefinition](../objects/RectangularPatternFeatureDefinition.md).Copy, [RectangularPatternFeatureProxy](../objects/RectangularPatternFeatureProxy.md).Definition, [RectangularPatternFeatures](../objects/RectangularPatternFeatures.md).CreateDefinition

**Referenced types:** [IrregularDistributionSet](../objects/IrregularDistributionSet.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureOperationEnum](../enums/PartFeatureOperationEnum.md), [PatternBoundarySetting](../objects/PatternBoundarySetting.md), [PatternComputeTypeEnum](../enums/PatternComputeTypeEnum.md), [PatternOrientationEnum](../enums/PatternOrientationEnum.md), [PatternSpacingTypeEnum](../enums/PatternSpacingTypeEnum.md)

