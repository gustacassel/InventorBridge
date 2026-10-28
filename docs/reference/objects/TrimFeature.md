# TrimFeature

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [PartFeature](../objects/PartFeature.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.TrimFeatures.Item[…]`

```csharp
interface TrimFeature
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

**Returned by:** [TrimFeatureProxy](../objects/TrimFeatureProxy.md).NativeObject, [TrimFeatures](../objects/TrimFeatures.md).Item

**Referenced types:** [AppearanceSourceTypeEnum](../enums/AppearanceSourceTypeEnum.md), [Asset](../objects/Asset.md), [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ComparisonTypeEnum](../enums/ComparisonTypeEnum.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ComponentOccurrencesEnumerator](../objects/ComponentOccurrencesEnumerator.md), [Faces](../objects/Faces.md), [FeatureDimensions](../objects/FeatureDimensions.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [ParametersEnumerator](../objects/ParametersEnumerator.md), [PartFeature](../objects/PartFeature.md), [SurfaceBodies](../objects/SurfaceBodies.md)

