# Edge

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SurfaceBodies.Item[…].Edges.Item[…]`

```csharp
interface Edge
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    EdgeUses EdgeUses { get; }
    CurveEvaluator Evaluator { get; }
    Faces Faces { get; }
    object Geometry { get; }
    int GeometryForm { get; }
    CurveTypeEnum GeometryType { get; }
    bool IsParamReversed { get; }
    bool IsTolerant { get; }
    SurfaceBody Parent { get; }
    Point PointOnEdge { get; }
    Vertex StartVertex { get; }
    Vertex StopVertex { get; }
    EdgeCollection TangentiallyConnectedEdges { get; }
    double Tolerance { get; }
    int TransientKey { get; }
    ObjectTypeEnum Type { get; }
    Wire Wire { get; }
    // Methods
    void CalculateStrokes(double Tolerance, out int VertexCount, out int SegmentCount, out double[] VertexCoordinates, out int[] VertexIndices);
    void CalculateStrokesWithOptions(double ChordalTolerance, NameValueMap Options, out int VertexCount, out double[] VertexCoordinates, out int PolylineCount, out int[] PolylineLengths);
    Point GetClosestPointTo(Point InputPoint);
    void GetExistingStrokeTolerances(out int ToleranceCount, out double[] ExistingTolerances);
    void GetExistingStrokes(double ToleranceIndex, out int VertexCount, out double[] VertexCoordinates, out int PolylineCount, out int[] PolylineLengths);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    Edge GetSourceEdge(bool GetLeafSource = true);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AnalyticEdgeWorkAxisDef](../objects/AnalyticEdgeWorkAxisDef.md).Edge, [Edge](../objects/Edge.md).GetSourceEdge, [EdgeProxy](../objects/EdgeProxy.md).GetSourceEdge, [EdgeProxy](../objects/EdgeProxy.md).NativeObject, [EdgeUse](../objects/EdgeUse.md).Edge, [EdgeUseProxy](../objects/EdgeUseProxy.md).Edge, [Edges](../objects/Edges.md).Item, [FilletIntermediateRadius](../objects/FilletIntermediateRadius.md).Edge, [FilletSetback](../objects/FilletSetback.md).Edge, [FlatBendResult](../objects/FlatBendResult.md).Edge, [MeshEdge](../objects/MeshEdge.md).Edge, [MeshEdgeProxy](../objects/MeshEdgeProxy.md).Edge, [MidPointWorkPointDef](../objects/MidPointWorkPointDef.md).Edge, [NonLinearEdgeWorkPointDef](../objects/NonLinearEdgeWorkPointDef.md).Edge, [SurfaceGraphicsEdge](../objects/SurfaceGraphicsEdge.md).Edge

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [CurveEvaluator](../objects/CurveEvaluator.md), [CurveTypeEnum](../enums/CurveTypeEnum.md), [EdgeCollection](../objects/EdgeCollection.md), [EdgeUses](../objects/EdgeUses.md), [Faces](../objects/Faces.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [SurfaceBody](../objects/SurfaceBody.md), [Vertex](../objects/Vertex.md), [Wire](../objects/Wire.md)

