# MeshFeatureSetProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [MeshFeatureSet](../objects/MeshFeatureSet.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.MeshFeatureSets.Item[…] → (MeshFeatureSetProxy)`

```csharp
interface MeshFeatureSetProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    int Count { get; }
    HealthStatusEnum HealthStatus { get; }
    MeshFeature Item[object Index] { get; }
    string Name { get; set; }
    MeshFeatureSet NativeObject { get; }
    ComponentDefinition Parent { get; }
    Box RangeBox { get; }
    MeshFeaturesSuppressionEnum Suppressed { get; set; }
    ObjectTypeEnum Type { get; }
    MeshFeaturesVisibilityEnum Visible { get; set; }
    // Methods
    void Delete(bool RetainDependentFeaturesAndSketches = false, bool RetainDependentWorkFeatures = false);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SetEndOfPart(bool Before);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [MeshFeature](../objects/MeshFeature.md), [MeshFeatureSet](../objects/MeshFeatureSet.md), [MeshFeaturesSuppressionEnum](../enums/MeshFeaturesSuppressionEnum.md), [MeshFeaturesVisibilityEnum](../enums/MeshFeaturesVisibilityEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

