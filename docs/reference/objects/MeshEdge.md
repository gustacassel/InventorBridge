# MeshEdge

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [MeshFeatureEntity](../objects/MeshFeatureEntity.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.MeshFeatureSets.Item[…].Item[…].Entities.Item[…] → (MeshEdge)`

```csharp
interface MeshEdge
{
    // Properties
    object Application { get; }
    Edge Edge { get; }
    CurveEvaluator Evaluator { get; }
    object Geometry { get; }
    CurveTypeEnum GeometryType { get; }
    MeshFeature MeshFeature { get; }
    MeshFeatureEntity MeshFeatureEntity { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [MeshEdgeProxy](../objects/MeshEdgeProxy.md).NativeObject

**Referenced types:** [CurveEvaluator](../objects/CurveEvaluator.md), [CurveTypeEnum](../enums/CurveTypeEnum.md), [Edge](../objects/Edge.md), [MeshFeature](../objects/MeshFeature.md), [MeshFeatureEntity](../objects/MeshFeatureEntity.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

