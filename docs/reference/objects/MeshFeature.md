# MeshFeature

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.MeshFeatureSets.Item[…].Item[…]`

```csharp
interface MeshFeature
{
    // Properties
    Asset Appearance { get; set; }
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    MeshFeatureEntitiesEnumerator Entities { get; }
    HealthStatusEnum HealthStatus { get; }
    string Name { get; set; }
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

**Returned by:** [MeshEdge](../objects/MeshEdge.md).MeshFeature, [MeshEdgeProxy](../objects/MeshEdgeProxy.md).MeshFeature, [MeshFace](../objects/MeshFace.md).MeshFeature, [MeshFaceProxy](../objects/MeshFaceProxy.md).MeshFeature, [MeshFeatureEntity](../objects/MeshFeatureEntity.md).Parent, [MeshFeatureEntityProxy](../objects/MeshFeatureEntityProxy.md).Parent, [MeshFeatureProxy](../objects/MeshFeatureProxy.md).NativeObject, [MeshFeatureSet](../objects/MeshFeatureSet.md).Item, [MeshFeatureSetProxy](../objects/MeshFeatureSetProxy.md).Item, [MeshVertex](../objects/MeshVertex.md).MeshFeature, [MeshVertexProxy](../objects/MeshVertexProxy.md).MeshFeature

**Referenced types:** [AppearanceSourceTypeEnum](../enums/AppearanceSourceTypeEnum.md), [Asset](../objects/Asset.md), [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [MeshFeatureEntitiesEnumerator](../objects/MeshFeatureEntitiesEnumerator.md), [MeshFeatureSet](../objects/MeshFeatureSet.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

