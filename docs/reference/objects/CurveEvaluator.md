# CurveEvaluator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateArc3d(…).Evaluator`

```csharp
interface CurveEvaluator
{
    // Properties
    int Continuity { get; }
    Box RangeBox { get; }
    // Methods
    void GetCurvature(out double[] Params, out double[] Directions, out double[] Curvatures);
    void GetEndPoints(out double[] StartPoint, out double[] EndPoint);
    void GetFirstDerivatives(out double[] Params, out double[] FirstDerivs);
    void GetLengthAtParam(double FromParam, double ToParam, out double Length);
    void GetParamAnomaly(out double[] Periodicity, out bool IsSingular, out bool UnboundedParam);
    void GetParamAtLength(double FromParam, double Length, out double Param);
    void GetParamAtPoint(out double[] Points, out double[] GuessParams, out double[] MaxDeviations, out double[] Params, out SolutionNatureEnum[] SolTypes);
    void GetParamExtents(out double MinParam, out double MaxParam);
    void GetPointAtParam(out double[] Params, out double[] Points);
    void GetSecondDerivatives(out double[] Params, out double[] SecondDerivs);
    void GetStrokes(double FromParam, double ToParam, double Tolerance, out int VertexCount, out double[] VertexCoordinates);
    void GetTangent(out double[] Params, out double[] Tangents);
    void GetThirdDerivatives(out double[] Params, out double[] ThirdDerivs);
}
```

**Returned by:** [Arc3d](../objects/Arc3d.md).Evaluator, [BSplineCurve](../objects/BSplineCurve.md).Evaluator, [Circle](../objects/Circle.md).Evaluator, [DrawingCurve](../objects/DrawingCurve.md).Evaluator3D, [Edge](../objects/Edge.md).Evaluator, [EdgeProxy](../objects/EdgeProxy.md).Evaluator, [EllipseFull](../objects/EllipseFull.md).Evaluator, [EllipticalArc](../objects/EllipticalArc.md).Evaluator, [Line](../objects/Line.md).Evaluator, [LineSegment](../objects/LineSegment.md).Evaluator, [MeshEdge](../objects/MeshEdge.md).Evaluator, [MeshEdgeProxy](../objects/MeshEdgeProxy.md).Evaluator, [Polyline3d](../objects/Polyline3d.md).Evaluator, [PresentationEdge](../objects/PresentationEdge.md).Evaluator

**Referenced types:** [Box](../objects/Box.md), [SolutionNatureEnum](../enums/SolutionNatureEnum.md)

