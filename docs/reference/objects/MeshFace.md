# MeshFace

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [MeshFeatureEntity](../objects/MeshFeatureEntity.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.MeshFeatureSets.Item[…].Item[…].Entities.Item[…] → (MeshFace)`

```csharp
interface MeshFace
{
    // Properties
    object Application { get; }
    SurfaceEvaluator Evaluator { get; }
    Face Face { get; }
    object Geometry { get; }
    MeshFeature MeshFeature { get; }
    MeshFeatureEntity MeshFeatureEntity { get; }
    SurfaceTypeEnum SurfaceType { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [MeshFaceProxy](../objects/MeshFaceProxy.md).NativeObject

**Referenced types:** [Face](../objects/Face.md), [MeshFeature](../objects/MeshFeature.md), [MeshFeatureEntity](../objects/MeshFeatureEntity.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SurfaceEvaluator](../objects/SurfaceEvaluator.md), [SurfaceTypeEnum](../enums/SurfaceTypeEnum.md)

