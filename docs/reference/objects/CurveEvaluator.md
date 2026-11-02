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
    void GetCurvature(ref double[] Params, ref double[] Directions, ref double[] Curvatures);
    void GetEndPoints(ref double[] StartPoint, ref double[] EndPoint);
    void GetFirstDerivatives(ref double[] Params, ref double[] FirstDerivs);
    void GetLengthAtParam(double FromParam, double ToParam, out double Length);
    void GetParamAnomaly(ref double[] Periodicity, out bool IsSingular, out bool UnboundedParam);
    void GetParamAtLength(double FromParam, double Length, out double Param);
    void GetParamAtPoint(ref double[] Points, ref double[] GuessParams, ref double[] MaxDeviations, ref double[] Params, ref SolutionNatureEnum[] SolTypes);
    void GetParamExtents(out double MinParam, out double MaxParam);
    void GetPointAtParam(ref double[] Params, ref double[] Points);
    void GetSecondDerivatives(ref double[] Params, ref double[] SecondDerivs);
    void GetStrokes(double FromParam, double ToParam, double Tolerance, out int VertexCount, out double[] VertexCoordinates);
    void GetTangent(ref double[] Params, ref double[] Tangents);
    void GetThirdDerivatives(ref double[] Params, ref double[] ThirdDerivs);
}
```

**Returned by:** [Arc3d](../objects/Arc3d.md).Evaluator, [BSplineCurve](../objects/BSplineCurve.md).Evaluator, [Circle](../objects/Circle.md).Evaluator, [DrawingCurve](../objects/DrawingCurve.md).Evaluator3D, [Edge](../objects/Edge.md).Evaluator, [EdgeProxy](../objects/EdgeProxy.md).Evaluator, [EllipseFull](../objects/EllipseFull.md).Evaluator, [EllipticalArc](../objects/EllipticalArc.md).Evaluator, [Line](../objects/Line.md).Evaluator, [LineSegment](../objects/LineSegment.md).Evaluator, [MeshEdge](../objects/MeshEdge.md).Evaluator, [MeshEdgeProxy](../objects/MeshEdgeProxy.md).Evaluator, [Polyline3d](../objects/Polyline3d.md).Evaluator, [PresentationEdge](../objects/PresentationEdge.md).Evaluator

**Referenced types:** [Box](../objects/Box.md), [SolutionNatureEnum](../enums/SolutionNatureEnum.md)

