# MeshFeatureProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [MeshFeature](../objects/MeshFeature.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.MeshFeatureSets.Item[…].Item[…] → (MeshFeatureProxy)`

```csharp
interface MeshFeatureProxy
{
    // Properties
    Asset Appearance { get; set; }
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    MeshFeatureEntitiesEnumerator Entities { get; }
    HealthStatusEnum HealthStatus { get; }
    string Name { get; set; }
    MeshFeature NativeObject { get; }
    MeshFeatureSet Parent { get; }
    Box RangeBox { get; }
    bool Suppressed { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void Delete(bool RetainDependentFeaturesAndSketches = false, bool RetainDependentWorkFeatures = false);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AppearanceSourceTypeEnum](../enums/AppearanceSourceTypeEnum.md), [Asset](../objects/Asset.md), [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [MeshFeature](../objects/MeshFeature.md), [MeshFeatureEntitiesEnumerator](../objects/MeshFeatureEntitiesEnumerator.md), [MeshFeatureSet](../objects/MeshFeatureSet.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

