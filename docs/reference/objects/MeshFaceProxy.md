# MeshFaceProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface MeshFaceProxy
{
    // Properties
    object Application { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    SurfaceEvaluator Evaluator { get; }
    Face Face { get; }
    object Geometry { get; }
    MeshFeature MeshFeature { get; }
    MeshFeatureEntity MeshFeatureEntity { get; }
    MeshFace NativeObject { get; }
    SurfaceTypeEnum SurfaceType { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [ComponentOccurrence](../objects/ComponentOccurrence.md), [Face](../objects/Face.md), [MeshFace](../objects/MeshFace.md), [MeshFeature](../objects/MeshFeature.md), [MeshFeatureEntity](../objects/MeshFeatureEntity.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SurfaceEvaluator](../objects/SurfaceEvaluator.md), [SurfaceTypeEnum](../enums/SurfaceTypeEnum.md)

