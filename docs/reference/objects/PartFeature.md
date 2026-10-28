# PartFeature

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.Item[…]`

```csharp
interface PartFeature
{
    // Properties
    bool Adaptive { get; set; }
    Asset Appearance { get; set; }
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool ConsumeInputs { get; set; }
    string ExtendedName { get; }
    Faces Faces { get; }
    FeatureDimensions FeatureDimensions { get; }
    HealthStatusEnum HealthStatus { get; }
    bool IsOwnedByFeature { get; }
    string Name { get; set; }
    PartFeature OwnedBy { get; }
    ParametersEnumerator Parameters { get; }
    ComponentDefinition Parent { get; }
    ComponentOccurrencesEnumerator Participants { get; }
    Box RangeBox { get; }
    bool Shared { get; set; }
    bool Suppressed { get; set; }
    SurfaceBodies SurfaceBodies { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete(bool RetainConsumedSketches = false, bool RetainDependentFeaturesAndSketches = false, bool RetainDependentWorkFeatures = false);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    bool GetSuppressionCondition(out Parameter Parameter, out ComparisonTypeEnum ComparisonType, out object Expression);
    void RemoveParticipant(ComponentOccurrence Occurrence);
    void SetAffectedBodies(ObjectCollection Bodies);
    void SetEndOfPart(bool Before);
    void SetSuppressionCondition(Parameter Parameter, ComparisonTypeEnum ComparisonType, object Expression);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AliasFreeformFeature](../objects/AliasFreeformFeature.md).OwnedBy, [AliasFreeformFeatureProxy](../objects/AliasFreeformFeatureProxy.md).OwnedBy, [AngleExtent](../objects/AngleExtent.md).Parent, [BendFeature](../objects/BendFeature.md).OwnedBy, [BendFeatureProxy](../objects/BendFeatureProxy.md).OwnedBy, [BendPartFeature](../objects/BendPartFeature.md).OwnedBy, [BendPartFeatureProxy](../objects/BendPartFeatureProxy.md).OwnedBy, [BossFeature](../objects/BossFeature.md).OwnedBy, [BossFeatureProxy](../objects/BossFeatureProxy.md).OwnedBy, [BoundaryPatchFeature](../objects/BoundaryPatchFeature.md).OwnedBy, [BoundaryPatchFeatureProxy](../objects/BoundaryPatchFeatureProxy.md).OwnedBy, [CenteredWidthExtent](../objects/CenteredWidthExtent.md).Parent, [ChamferDefinition](../objects/ChamferDefinition.md).Parent, [ChamferFeature](../objects/ChamferFeature.md).OwnedBy, [ChamferFeatureProxy](../objects/ChamferFeatureProxy.md).OwnedBy, [CircularPatternFeature](../objects/CircularPatternFeature.md).OwnedBy, [CircularPatternFeatureProxy](../objects/CircularPatternFeatureProxy.md).OwnedBy, [ClientFeature](../objects/ClientFeature.md).OwnedBy, [ClientFeatureProxy](../objects/ClientFeatureProxy.md).OwnedBy, [CoilFeature](../objects/CoilFeature.md).OwnedBy, [CoilFeatureProxy](../objects/CoilFeatureProxy.md).OwnedBy, [CombineFeature](../objects/CombineFeature.md).OwnedBy, [CombineFeatureProxy](../objects/CombineFeatureProxy.md).OwnedBy, [ContourFlangeFeature](../objects/ContourFlangeFeature.md).OwnedBy, [ContourFlangeFeatureProxy](../objects/ContourFlangeFeatureProxy.md).OwnedBy, [ContourRollFeature](../objects/ContourRollFeature.md).OwnedBy, [ContourRollFeatureProxy](../objects/ContourRollFeatureProxy.md).OwnedBy, [CornerChamferFeature](../objects/CornerChamferFeature.md).OwnedBy, [CornerChamferFeatureProxy](../objects/CornerChamferFeatureProxy.md).OwnedBy, [CornerFeature](../objects/CornerFeature.md).OwnedBy, [CornerFeatureProxy](../objects/CornerFeatureProxy.md).OwnedBy, [CornerRoundFeature](../objects/CornerRoundFeature.md).OwnedBy, [CornerRoundFeatureProxy](../objects/CornerRoundFeatureProxy.md).OwnedBy, [CosmeticBendFeature](../objects/CosmeticBendFeature.md).OwnedBy, [CosmeticBendFeatureProxy](../objects/CosmeticBendFeatureProxy.md).OwnedBy, [CutAcrossBendsExtent](../objects/CutAcrossBendsExtent.md).Parent, [CutFeature](../objects/CutFeature.md).OwnedBy, [CutFeatureProxy](../objects/CutFeatureProxy.md).OwnedBy, [DecalFeature](../objects/DecalFeature.md).OwnedBy, [DecalFeatureProxy](../objects/DecalFeatureProxy.md).OwnedBy and 145 more (see `members.tsv`)

**Referenced types:** [AppearanceSourceTypeEnum](../enums/AppearanceSourceTypeEnum.md), [Asset](../objects/Asset.md), [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ComparisonTypeEnum](../enums/ComparisonTypeEnum.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ComponentOccurrencesEnumerator](../objects/ComponentOccurrencesEnumerator.md), [Faces](../objects/Faces.md), [FeatureDimensions](../objects/FeatureDimensions.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [ParametersEnumerator](../objects/ParametersEnumerator.md), [SurfaceBodies](../objects/SurfaceBodies.md)

