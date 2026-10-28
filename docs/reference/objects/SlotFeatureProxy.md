# SlotFeatureProxy

Inventor API object · versions: 2027 · [index](../index.md)

**Inherits from:** [MoveFaceFeature](../objects/MoveFaceFeature.md) → [PartFeature](../objects/PartFeature.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.MoveFaceFeatures.Item[…] → (SlotFeatureProxy)`

```csharp
interface SlotFeatureProxy
{
    // Properties
    bool Adaptive { get; set; } // since 2027
    Asset Appearance { get; set; } // since 2027
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; } // since 2027
    object Application { get; } // since 2027
    AttributeSets AttributeSets { get; } // since 2027
    bool ConsumeInputs { get; set; } // since 2027
    ComponentOccurrence ContainingOccurrence { get; } // since 2027
    SlotDefinition Definition { get; set; } // since 2027
    string ExtendedName { get; } // since 2027
    Faces Faces { get; } // since 2027
    FeatureDimensions FeatureDimensions { get; } // since 2027
    HealthStatusEnum HealthStatus { get; } // since 2027
    bool IsOwnedByFeature { get; } // since 2027
    string Name { get; set; } // since 2027
    SlotFeature NativeObject { get; } // since 2027
    PartFeature OwnedBy { get; } // since 2027
    ParametersEnumerator Parameters { get; } // since 2027
    ComponentDefinition Parent { get; } // since 2027
    ComponentOccurrencesEnumerator Participants { get; } // since 2027
    Box RangeBox { get; } // since 2027
    bool Shared { get; set; } // since 2027
    bool Suppressed { get; set; } // since 2027
    SurfaceBodies SurfaceBodies { get; } // since 2027
    ObjectTypeEnum Type { get; } // since 2027
    // Methods
    void Delete(bool RetainConsumedSketches = false, bool RetainDependentFeaturesAndSketches = false, bool RetainDependentWorkFeatures = false); // since 2027
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0); // since 2027
    bool GetSuppressionCondition(out Parameter Parameter, out ComparisonTypeEnum ComparisonType, out object Expression); // since 2027
    void RemoveParticipant(ComponentOccurrence Occurrence); // since 2027
    void SetAffectedBodies(ObjectCollection Bodies); // since 2027
    void SetEndOfPart(bool Before); // since 2027
    void SetSuppressionCondition(Parameter Parameter, ComparisonTypeEnum ComparisonType, object Expression); // since 2027
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AppearanceSourceTypeEnum](../enums/AppearanceSourceTypeEnum.md), [Asset](../objects/Asset.md), [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ComparisonTypeEnum](../enums/ComparisonTypeEnum.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ComponentOccurrencesEnumerator](../objects/ComponentOccurrencesEnumerator.md), [Faces](../objects/Faces.md), [FeatureDimensions](../objects/FeatureDimensions.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [ParametersEnumerator](../objects/ParametersEnumerator.md), [PartFeature](../objects/PartFeature.md), [SlotDefinition](../objects/SlotDefinition.md), [SlotFeature](../objects/SlotFeature.md), [SurfaceBodies](../objects/SurfaceBodies.md)

