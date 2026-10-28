# MeshEdgeProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface MeshEdgeProxy
{
    // Properties
    object Application { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    Edge Edge { get; }
    CurveEvaluator Evaluator { get; }
    object Geometry { get; }
    CurveTypeEnum GeometryType { get; }
    MeshFeature MeshFeature { get; }
    MeshFeatureEntity MeshFeatureEntity { get; }
    MeshEdge NativeObject { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [ComponentOccurrence](../objects/ComponentOccurrence.md), [CurveEvaluator](../objects/CurveEvaluator.md), [CurveTypeEnum](../enums/CurveTypeEnum.md), [Edge](../objects/Edge.md), [MeshEdge](../objects/MeshEdge.md), [MeshFeature](../objects/MeshFeature.md), [MeshFeatureEntity](../objects/MeshFeatureEntity.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

