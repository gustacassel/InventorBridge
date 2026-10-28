# MirrorFeatureProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [MirrorFeature](../objects/MirrorFeature.md) → [PartFeature](../objects/PartFeature.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.MirrorFeatures.Item[…] → (MirrorFeatureProxy)`

```csharp
interface MirrorFeatureProxy
{
    // Properties
    bool Adaptive { get; set; }
    Asset Appearance { get; set; }
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool ConsumeInputs { get; set; }
    ComponentOccurrence ContainingOccurrence { get; }
    MirrorFeatureDefinition Definition { get; set; }
    string ExtendedName { get; }
    Faces Faces { get; }
    FeatureDimensions FeatureDimensions { get; }
    HealthStatusEnum HealthStatus { get; }
    bool IsOwnedByFeature { get; }
    string Name { get; set; }
    MirrorFeature NativeObject { get; }
    PartFeature OwnedBy { get; }
    ParametersEnumerator Parameters { get; }
    ComponentDefinition Parent { get; }
    ComponentOccurrencesEnumerator Participants { get; }
    FeaturePatternElements PatternElements { get; }
    Box RangeBox { get; }
    ObjectsEnumerator ResultFeatures { get; }
    bool Shared { get; set; }
    bool Suppressed { get; set; }
    SurfaceBodies SurfaceBodies { get; }
    bool SurfacesOpaque { get; set; }
    bool SurfacesVisible { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void AddParticipant(ComponentOccurrence Occurrenc);
    void Delete(bool RetainConsumedSketches = false, bool RetainDependentFeaturesAndSketches = false, bool RetainDependentWorkFeatures = false);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    bool GetSuppressionCondition(out Parameter Parameter, out ComparisonTypeEnum ComparisonType, out object Expression);
    void RemoveParticipant(ComponentOccurrence Occurrence);
    void SetAffectedBodies(ObjectCollection Bodies);
    void SetEndOfPart(bool Before);
    void SetSuppressionCondition(Parameter Parameter, ComparisonTypeEnum ComparisonType, object Expression);
}
```

9 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AppearanceSourceTypeEnum](../enums/AppearanceSourceTypeEnum.md), [Asset](../objects/Asset.md), [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ComparisonTypeEnum](../enums/ComparisonTypeEnum.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ComponentOccurrencesEnumerator](../objects/ComponentOccurrencesEnumerator.md), [Faces](../objects/Faces.md), [FeatureDimensions](../objects/FeatureDimensions.md), [FeaturePatternElements](../objects/FeaturePatternElements.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [MirrorFeature](../objects/MirrorFeature.md), [MirrorFeatureDefinition](../objects/MirrorFeatureDefinition.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [Parameter](../objects/Parameter.md), [ParametersEnumerator](../objects/ParametersEnumerator.md), [PartFeature](../objects/PartFeature.md), [SurfaceBodies](../objects/SurfaceBodies.md)

