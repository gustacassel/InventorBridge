# MeshFeatureEntity

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.MeshFeatureSets.Item[…].Item[…].Entities.Item[…]`

```csharp
interface MeshFeatureEntity
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ColorBindingEnum ColorBinding { get; }
    GraphicsDataSetsCollection GraphicsDataSetsCollection { get; } // since 2026
    NormalBindingEnum NormalBinding { get; }
    MeshFeature Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

6 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [MeshEdge](../objects/MeshEdge.md).MeshFeatureEntity, [MeshEdgeProxy](../objects/MeshEdgeProxy.md).MeshFeatureEntity, [MeshFace](../objects/MeshFace.md).MeshFeatureEntity, [MeshFaceProxy](../objects/MeshFaceProxy.md).MeshFeatureEntity, [MeshFeatureEntitiesEnumerator](../objects/MeshFeatureEntitiesEnumerator.md).Item, [MeshFeatureEntityProxy](../objects/MeshFeatureEntityProxy.md).NativeObject, [MeshVertex](../objects/MeshVertex.md).MeshFeatureEntity, [MeshVertexProxy](../objects/MeshVertexProxy.md).MeshFeatureEntity

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ColorBindingEnum](../enums/ColorBindingEnum.md), [GraphicsDataSetsCollection](../objects/GraphicsDataSetsCollection.md), [MeshFeature](../objects/MeshFeature.md), [NormalBindingEnum](../enums/NormalBindingEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

