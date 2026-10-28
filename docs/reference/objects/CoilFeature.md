# CoilFeature

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [PartFeature](../objects/PartFeature.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.CoilFeatures.Item[…]`

```csharp
interface CoilFeature
{
    // Properties
    bool Adaptive { get; set; }
    Asset Appearance { get; set; }
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool AxisDirectionReversed { get; set; }
    object AxisEntity { get; set; }
    bool ClockwiseRotation { get; set; }
    bool ConsumeInputs { get; set; }
    Parameter EndFlatAngle { get; }
    Parameter EndTransitionAngle { get; }
    string ExtendedName { get; }
    PartFeatureExtent Extent { get; }
    PartFeatureExtentEnum ExtentType { get; }
    Faces Faces { get; }
    FeatureDimensions FeatureDimensions { get; }
    bool FlatEndType { get; set; }
    bool FlatStartType { get; set; }
    HealthStatusEnum HealthStatus { get; }
    bool IsOwnedByFeature { get; }
    string Name { get; set; }
    PartFeatureOperationEnum Operation { get; set; }
    PartFeature OwnedBy { get; }
    ParametersEnumerator Parameters { get; }
    ComponentDefinition Parent { get; }
    ComponentOccurrencesEnumerator Participants { get; }
    Profile Profile { get; set; }
    Box RangeBox { get; }
    bool Shared { get; set; }
    Parameter StartFlatAngle { get; }
    Parameter StartTransitionAngle { get; }
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
    void SetPitchAndHeightExtent(object Pitch, object Height, object TaperAngle = Missing);
    void SetPitchAndRevolutionExtent(object Pitch, object Revolution, object TaperAngle = Missing);
    void SetRevolutionAndHeightExtent(object Revolution, object Height, object TaperAngle = Missing);
    void SetSpiralExtent(object Pitch, object Revolution);
    void SetSuppressionCondition(Parameter Parameter, ComparisonTypeEnum ComparisonType, object Expression);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [CoilFeatureProxy](../objects/CoilFeatureProxy.md).NativeObject, [CoilFeatures](../objects/CoilFeatures.md).AddByPitchAndHeight, [CoilFeatures](../objects/CoilFeatures.md).AddByPitchAndRevolution, [CoilFeatures](../objects/CoilFeatures.md).AddByRevolutionAndHeight, [CoilFeatures](../objects/CoilFeatures.md).AddSpiral, [CoilFeatures](../objects/CoilFeatures.md).Item

**Referenced types:** [AppearanceSourceTypeEnum](../enums/AppearanceSourceTypeEnum.md), [Asset](../objects/Asset.md), [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ComparisonTypeEnum](../enums/ComparisonTypeEnum.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ComponentOccurrencesEnumerator](../objects/ComponentOccurrencesEnumerator.md), [Faces](../objects/Faces.md), [FeatureDimensions](../objects/FeatureDimensions.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [ParametersEnumerator](../objects/ParametersEnumerator.md), [PartFeature](../objects/PartFeature.md), [PartFeatureExtent](../objects/PartFeatureExtent.md), [PartFeatureExtentEnum](../enums/PartFeatureExtentEnum.md), [PartFeatureOperationEnum](../enums/PartFeatureOperationEnum.md), [Profile](../objects/Profile.md), [SurfaceBodies](../objects/SurfaceBodies.md)

