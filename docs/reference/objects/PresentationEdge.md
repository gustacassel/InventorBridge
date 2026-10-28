# PresentationEdge

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PresentationDocument).Scenes.Item[…].TopSceneComponent.SurfaceBodies.Item[…].Edges.Item[…]`

```csharp
interface PresentationEdge
{
    // Properties
    object Application { get; }
    CurveEvaluator Evaluator { get; }
    PresentationFacesEnumerator Faces { get; }
    object Geometry { get; }
    int GeometryForm { get; }
    CurveTypeEnum GeometryType { get; }
    bool IsParamReversed { get; }
    PresentationBody Parent { get; }
    Point PointOnEdge { get; }
    PresentationVertex StartVertex { get; }
    PresentationVertex StopVertex { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void CalculateStrokes(double Tolerance, out int VertexCount, out int SegmentCount, out double[] VertexCoordinates, out int[] VertexIndices);
    void CalculateStrokesWithOptions(double ChordalTolerance, NameValueMap Options, out int VertexCount, out double[] VertexCoordinates, out int PolylineCount, out int[] PolylineLengths);
    void GetExistingStrokeTolerances(out int ToleranceCount, out double[] ExistingTolerances);
    void GetExistingStrokes(double ToleranceIndex, out int VertexCount, out double[] VertexCoordinates, out int PolylineCount, out int[] PolylineLengths);
}
```

**Returned by:** [PresentationEdgesEnumerator](../objects/PresentationEdgesEnumerator.md).Item

**Referenced types:** [CurveEvaluator](../objects/CurveEvaluator.md), [CurveTypeEnum](../enums/CurveTypeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [PresentationBody](../objects/PresentationBody.md), [PresentationFacesEnumerator](../objects/PresentationFacesEnumerator.md), [PresentationVertex](../objects/PresentationVertex.md)

