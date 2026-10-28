# EdgeCollection

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientObjects.CreateEdgeCollection(…)`

```csharp
interface EdgeCollection
{
    // Properties
    EdgeCollectionEnum CollectionType { get; }
    int Count { get; }
    object Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Add(object Object);
    void Clear();
    void Remove(int Index);
    void RemoveByObject(object Object);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BendDefinition](../objects/BendDefinition.md).Edges, [ChamferDefinition](../objects/ChamferDefinition.md).ChamferedEdges, [ContourFlangeDefinition](../objects/ContourFlangeDefinition.md).BendEdges, [CornerChamferDefinition](../objects/CornerChamferDefinition.md).CornerEdges, [CornerDefinition](../objects/CornerDefinition.md).Edges, [CornerRoundEdgeSet](../objects/CornerRoundEdgeSet.md).Edges, [CornerRoundFeatures](../objects/CornerRoundFeatures.md).GetEdgesFromFeature, [CosmeticWeldDefinition](../objects/CosmeticWeldDefinition.md).Edges, [Edge](../objects/Edge.md).TangentiallyConnectedEdges, [EdgeProxy](../objects/EdgeProxy.md).TangentiallyConnectedEdges, [FaceDraftDefinition](../objects/FaceDraftDefinition.md).FixedEdges, [FaceDraftFeature](../objects/FaceDraftFeature.md)._FixedEdges, [FaceDraftFeatureProxy](../objects/FaceDraftFeatureProxy.md)._FixedEdges, [FilletConstantRadiusEdgeSet](../objects/FilletConstantRadiusEdgeSet.md).Edges, [FilletRadiusEdgeSet](../objects/FilletRadiusEdgeSet.md).Edges, [FilletVariableRadiusEdgeSet](../objects/FilletVariableRadiusEdgeSet.md).Edges, [FlangeEdgeSet](../objects/FlangeEdgeSet.md).Edges, [HemDefinition](../objects/HemDefinition.md).Edges, [PartialChamferEdge](../objects/PartialChamferEdge.md).Edge, [SurfaceBody](../objects/SurfaceBody.md).ConcaveEdges, [SurfaceBody](../objects/SurfaceBody.md).ConvexEdges, [SurfaceBodyProxy](../objects/SurfaceBodyProxy.md).ConcaveEdges, [SurfaceBodyProxy](../objects/SurfaceBodyProxy.md).ConvexEdges, [TransientObjects](../objects/TransientObjects.md).CreateEdgeCollection, [UnwrapDefinition](../objects/UnwrapDefinition.md).LinearResult, [UnwrapDefinition](../objects/UnwrapDefinition.md).RigidResult, [UnwrapDefinition](../objects/UnwrapDefinition.md).SeamEdges

**Referenced types:** [EdgeCollectionEnum](../enums/EdgeCollectionEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

