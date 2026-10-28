# Curve2dEvaluator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateArc2d(…).Evaluator`

```csharp
interface Curve2dEvaluator
{
    // Properties
    int Continuity { get; }
    Box2d RangeBox { get; }
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

**Returned by:** [Arc2d](../objects/Arc2d.md).Evaluator, [BSplineCurve2d](../objects/BSplineCurve2d.md).Evaluator, [Circle2d](../objects/Circle2d.md).Evaluator, [DrawingCurve](../objects/DrawingCurve.md).Evaluator2D, [EdgeUse](../objects/EdgeUse.md).Evaluator, [EdgeUseProxy](../objects/EdgeUseProxy.md).Evaluator, [EllipseFull2d](../objects/EllipseFull2d.md).Evaluator, [EllipticalArc2d](../objects/EllipticalArc2d.md).Evaluator, [Line2d](../objects/Line2d.md).Evaluator, [LineSegment2d](../objects/LineSegment2d.md).Evaluator, [Polyline2d](../objects/Polyline2d.md).Evaluator

**Referenced types:** [Box2d](../objects/Box2d.md), [SolutionNatureEnum](../enums/SolutionNatureEnum.md)

