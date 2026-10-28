# EdgeProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Edge](../objects/Edge.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SurfaceBodies.Item[…].Edges.Item[…] → (EdgeProxy)`

```csharp
interface EdgeProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    EdgeUses EdgeUses { get; }
    CurveEvaluator Evaluator { get; }
    Faces Faces { get; }
    object Geometry { get; }
    int GeometryForm { get; }
    CurveTypeEnum GeometryType { get; }
    bool IsParamReversed { get; }
    bool IsTolerant { get; }
    Edge NativeObject { get; }
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

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [CurveEvaluator](../objects/CurveEvaluator.md), [CurveTypeEnum](../enums/CurveTypeEnum.md), [Edge](../objects/Edge.md), [EdgeCollection](../objects/EdgeCollection.md), [EdgeUses](../objects/EdgeUses.md), [Faces](../objects/Faces.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [SurfaceBody](../objects/SurfaceBody.md), [Vertex](../objects/Vertex.md), [Wire](../objects/Wire.md)

