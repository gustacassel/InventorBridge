# SimplifyFeature

Inventor API object · versions: 2026, 2027 · [index](../index.md)

**Inherits from:** [PartFeature](../objects/PartFeature.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.SimplifyFeatures.Item[…]`

```csharp
interface SimplifyFeature
{
    // Properties
    bool Adaptive { get; set; } // since 2026
    Asset Appearance { get; set; } // since 2026
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; } // since 2026
    object Application { get; } // since 2026
    AttributeSets AttributeSets { get; } // since 2026
    bool ConsumeInputs { get; set; } // since 2026
    SimplifyDefinition Definition { get; set; } // since 2026
    string ExtendedName { get; } // since 2026
    Faces Faces { get; } // since 2026
    FeatureDimensions FeatureDimensions { get; } // since 2026
    HealthStatusEnum HealthStatus { get; } // since 2026
    bool IsOwnedByFeature { get; } // since 2026
    string Name { get; set; } // since 2026
    PartFeature OwnedBy { get; } // since 2026
    ParametersEnumerator Parameters { get; } // since 2026
    ComponentDefinition Parent { get; } // since 2026
    ComponentOccurrencesEnumerator Participants { get; } // since 2026
    Box RangeBox { get; } // since 2026
    bool Shared { get; set; } // since 2026
    bool Suppressed { get; set; } // since 2026
    SurfaceBodies SurfaceBodies { get; } // since 2026
    ObjectTypeEnum Type { get; } // since 2026
    // Methods
    void Delete(bool RetainConsumedSketches = false, bool RetainDependentFeaturesAndSketches = false, bool RetainDependentWorkFeatures = false); // since 2026
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0); // since 2026
    bool GetSuppressionCondition(out Parameter Parameter, out ComparisonTypeEnum ComparisonType, out object Expression); // since 2026
    void RemoveParticipant(ComponentOccurrence Occurrence); // since 2026
    void SetAffectedBodies(ObjectCollection Bodies); // since 2026
    void SetEndOfPart(bool Before); // since 2026
    void SetSuppressionCondition(Parameter Parameter, ComparisonTypeEnum ComparisonType, object Expression); // since 2026
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SimplifyDefinition](../objects/SimplifyDefinition.md).Parent, [SimplifyFeatureProxy](../objects/SimplifyFeatureProxy.md).NativeObject, [SimplifyFeatures](../objects/SimplifyFeatures.md).Add, [SimplifyFeatures](../objects/SimplifyFeatures.md).Item

**Referenced types:** [AppearanceSourceTypeEnum](../enums/AppearanceSourceTypeEnum.md), [Asset](../objects/Asset.md), [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ComparisonTypeEnum](../enums/ComparisonTypeEnum.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ComponentOccurrencesEnumerator](../objects/ComponentOccurrencesEnumerator.md), [Faces](../objects/Faces.md), [FeatureDimensions](../objects/FeatureDimensions.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [ParametersEnumerator](../objects/ParametersEnumerator.md), [PartFeature](../objects/PartFeature.md), [SimplifyDefinition](../objects/SimplifyDefinition.md), [SurfaceBodies](../objects/SurfaceBodies.md)

