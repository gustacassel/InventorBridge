# FeatureDimensions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.Item[…].FeatureDimensions`

```csharp
interface FeatureDimensions
{
    // Properties
    object Application { get; }
    int Count { get; }
    FeatureDimension Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Show();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AliasFreeformFeature](../objects/AliasFreeformFeature.md).FeatureDimensions, [AliasFreeformFeatureProxy](../objects/AliasFreeformFeatureProxy.md).FeatureDimensions, [BendFeature](../objects/BendFeature.md).FeatureDimensions, [BendFeatureProxy](../objects/BendFeatureProxy.md).FeatureDimensions, [BendPartFeature](../objects/BendPartFeature.md).FeatureDimensions, [BendPartFeatureProxy](../objects/BendPartFeatureProxy.md).FeatureDimensions, [BossFeature](../objects/BossFeature.md).FeatureDimensions, [BossFeatureProxy](../objects/BossFeatureProxy.md).FeatureDimensions, [BoundaryPatchFeature](../objects/BoundaryPatchFeature.md).FeatureDimensions, [BoundaryPatchFeatureProxy](../objects/BoundaryPatchFeatureProxy.md).FeatureDimensions, [ChamferFeature](../objects/ChamferFeature.md).FeatureDimensions, [ChamferFeatureProxy](../objects/ChamferFeatureProxy.md).FeatureDimensions, [CircularPatternFeature](../objects/CircularPatternFeature.md).FeatureDimensions, [CircularPatternFeatureProxy](../objects/CircularPatternFeatureProxy.md).FeatureDimensions, [ClientFeature](../objects/ClientFeature.md).FeatureDimensions, [ClientFeatureProxy](../objects/ClientFeatureProxy.md).FeatureDimensions, [CoilFeature](../objects/CoilFeature.md).FeatureDimensions, [CoilFeatureProxy](../objects/CoilFeatureProxy.md).FeatureDimensions, [CombineFeature](../objects/CombineFeature.md).FeatureDimensions, [CombineFeatureProxy](../objects/CombineFeatureProxy.md).FeatureDimensions, [ContourFlangeFeature](../objects/ContourFlangeFeature.md).FeatureDimensions, [ContourFlangeFeatureProxy](../objects/ContourFlangeFeatureProxy.md).FeatureDimensions, [ContourRollFeature](../objects/ContourRollFeature.md).FeatureDimensions, [ContourRollFeatureProxy](../objects/ContourRollFeatureProxy.md).FeatureDimensions, [CornerChamferFeature](../objects/CornerChamferFeature.md).FeatureDimensions, [CornerChamferFeatureProxy](../objects/CornerChamferFeatureProxy.md).FeatureDimensions, [CornerFeature](../objects/CornerFeature.md).FeatureDimensions, [CornerFeatureProxy](../objects/CornerFeatureProxy.md).FeatureDimensions, [CornerRoundFeature](../objects/CornerRoundFeature.md).FeatureDimensions, [CornerRoundFeatureProxy](../objects/CornerRoundFeatureProxy.md).FeatureDimensions, [CosmeticBendFeature](../objects/CosmeticBendFeature.md).FeatureDimensions, [CosmeticBendFeatureProxy](../objects/CosmeticBendFeatureProxy.md).FeatureDimensions, [CutFeature](../objects/CutFeature.md).FeatureDimensions, [CutFeatureProxy](../objects/CutFeatureProxy.md).FeatureDimensions, [DecalFeature](../objects/DecalFeature.md).FeatureDimensions, [DecalFeatureProxy](../objects/DecalFeatureProxy.md).FeatureDimensions, [DeleteFaceFeature](../objects/DeleteFaceFeature.md).FeatureDimensions, [DeleteFaceFeatureProxy](../objects/DeleteFaceFeatureProxy.md).FeatureDimensions, [DirectEditFeature](../objects/DirectEditFeature.md).FeatureDimensions, [DirectEditFeatureProxy](../objects/DirectEditFeatureProxy.md).FeatureDimensions and 95 more (see `members.tsv`)

**Referenced types:** [FeatureDimension](../objects/FeatureDimension.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

