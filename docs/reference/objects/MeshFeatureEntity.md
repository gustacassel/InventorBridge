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
    GraphicsIndexSet ColorIndexSet { get; } // hidden in 2026, 2027: there, prefer the newer members
    GraphicsColorSet ColorSet { get; } // hidden in 2026, 2027: there, prefer the newer members
    GraphicsIndexSet CoordinateIndexSet { get; } // hidden in 2026, 2027: there, prefer the newer members
    GraphicsCoordinateSet CoordinateSet { get; } // hidden in 2026, 2027: there, prefer the newer members
    GraphicsDataSetsCollection GraphicsDataSetsCollection { get; } // since 2026
    NormalBindingEnum NormalBinding { get; }
    GraphicsIndexSet NormalIndexSet { get; } // hidden in 2026, 2027: there, prefer the newer members
    GraphicsNormalSet NormalSet { get; } // hidden in 2026, 2027: there, prefer the newer members
    MeshFeature Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetReferenceKey(ref byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [MeshEdge](../objects/MeshEdge.md).MeshFeatureEntity, [MeshEdgeProxy](../objects/MeshEdgeProxy.md).MeshFeatureEntity, [MeshFace](../objects/MeshFace.md).MeshFeatureEntity, [MeshFaceProxy](../objects/MeshFaceProxy.md).MeshFeatureEntity, [MeshFeatureEntitiesEnumerator](../objects/MeshFeatureEntitiesEnumerator.md).Item, [MeshFeatureEntityProxy](../objects/MeshFeatureEntityProxy.md).NativeObject, [MeshVertex](../objects/MeshVertex.md).MeshFeatureEntity, [MeshVertexProxy](../objects/MeshVertexProxy.md).MeshFeatureEntity

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ColorBindingEnum](../enums/ColorBindingEnum.md), [GraphicsColorSet](../objects/GraphicsColorSet.md), [GraphicsCoordinateSet](../objects/GraphicsCoordinateSet.md), [GraphicsDataSetsCollection](../objects/GraphicsDataSetsCollection.md), [GraphicsIndexSet](../objects/GraphicsIndexSet.md), [GraphicsNormalSet](../objects/GraphicsNormalSet.md), [MeshFeature](../objects/MeshFeature.md), [NormalBindingEnum](../enums/NormalBindingEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

