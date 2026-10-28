# MeshVertex

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [MeshFeatureEntity](../objects/MeshFeatureEntity.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.MeshFeatureSets.Item[…].Item[…].Entities.Item[…] → (MeshVertex)`

```csharp
interface MeshVertex
{
    // Properties
    object Application { get; }
    Point Geometry { get; }
    MeshFeature MeshFeature { get; }
    MeshFeatureEntity MeshFeatureEntity { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [MeshVertexProxy](../objects/MeshVertexProxy.md).NativeObject

**Referenced types:** [MeshFeature](../objects/MeshFeature.md), [MeshFeatureEntity](../objects/MeshFeatureEntity.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

