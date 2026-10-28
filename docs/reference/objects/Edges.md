# Edges

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SurfaceBodies.Item[…].Edges`

```csharp
interface Edges
{
    // Properties
    int Count { get; }
    Edge Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [EdgeLoop](../objects/EdgeLoop.md).Edges, [EdgeLoopProxy](../objects/EdgeLoopProxy.md).Edges, [Face](../objects/Face.md).Edges, [FaceProxy](../objects/FaceProxy.md).Edges, [FaceShell](../objects/FaceShell.md).Edges, [FaceShellProxy](../objects/FaceShellProxy.md).Edges, [FlatPattern](../objects/FlatPattern.md).GetEdgesOfType, [FlatPunchResult](../objects/FlatPunchResult.md).SketchRepresentationEdges, [MarkFeature](../objects/MarkFeature.md).ResultEdges, [MarkFeatureProxy](../objects/MarkFeatureProxy.md).ResultEdges, [SurfaceBody](../objects/SurfaceBody.md).Edges, [SurfaceBodyProxy](../objects/SurfaceBodyProxy.md).Edges, [ThreadFeature](../objects/ThreadFeature.md).StartEdge, [ThreadFeatureProxy](../objects/ThreadFeatureProxy.md).StartEdge, [Vertex](../objects/Vertex.md).Edges, [VertexProxy](../objects/VertexProxy.md).Edges, [Wire](../objects/Wire.md).Edges

**Referenced types:** [Edge](../objects/Edge.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

