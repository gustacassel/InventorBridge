# MeshFeatureSet

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.MeshFeatureSets.Item[…]`

```csharp
interface MeshFeatureSet
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    int Count { get; }
    HealthStatusEnum HealthStatus { get; }
    MeshFeature Item[object Index] { get; }
    string Name { get; set; }
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

**Returned by:** [MeshFeature](../objects/MeshFeature.md).Parent, [MeshFeatureProxy](../objects/MeshFeatureProxy.md).Parent, [MeshFeatureSetProxy](../objects/MeshFeatureSetProxy.md).NativeObject, [MeshFeatureSets](../objects/MeshFeatureSets.md).Add, [MeshFeatureSets](../objects/MeshFeatureSets.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ComponentDefinition](../objects/ComponentDefinition.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [MeshFeature](../objects/MeshFeature.md), [MeshFeaturesSuppressionEnum](../enums/MeshFeaturesSuppressionEnum.md), [MeshFeaturesVisibilityEnum](../enums/MeshFeaturesVisibilityEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

