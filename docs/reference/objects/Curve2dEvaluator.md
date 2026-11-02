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

**Returned by:** [Arc2d](../objects/Arc2d.md).Evaluator, [BSplineCurve2d](../objects/BSplineCurve2d.md).Evaluator, [Circle2d](../objects/Circle2d.md).Evaluator, [DrawingCurve](../objects/DrawingCurve.md).Evaluator2D, [EdgeUse](../objects/EdgeUse.md).Evaluator, [EdgeUseProxy](../objects/EdgeUseProxy.md).Evaluator, [EllipseFull2d](../objects/EllipseFull2d.md).Evaluator, [EllipticalArc2d](../objects/EllipticalArc2d.md).Evaluator, [Line2d](../objects/Line2d.md).Evaluator, [LineSegment2d](../objects/LineSegment2d.md).Evaluator, [Polyline2d](../objects/Polyline2d.md).Evaluator

**Referenced types:** [Box2d](../objects/Box2d.md), [SolutionNatureEnum](../enums/SolutionNatureEnum.md)

