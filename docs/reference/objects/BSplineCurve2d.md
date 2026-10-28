# BSplineCurve2d

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateBSplineCurve2d(…)`

```csharp
interface BSplineCurve2d
{
    // Properties
    Curve2dEvaluator Evaluator { get; }
    Point2d PoleAtIndex[int Index] { get; set; }
    // Methods
    BSplineCurve2d Copy();
    BSplineCurve2d ExtractPartial(double StartParam, double EndParam);
    void GetBSplineData(out double[] Poles, out double[] Knots, out double[] Weights);
    void GetBSplineInfo(out int Order, out int NumPoles, out int NumKnots, out bool IsRational, out bool IsPeriodic, out bool IsClosed);
    void PutBSplineInfoAndData(int Order, out double[] Poles, out double[] Knots, out double[] Weights, bool IsPeriodic);
    void Split(double SplitParam, out BSplineCurve2d CurveOne, out BSplineCurve2d CurveTwo);
}
```

**Returned by:** [BSplineCurve2d](../objects/BSplineCurve2d.md).Copy, [BSplineCurve2d](../objects/BSplineCurve2d.md).ExtractPartial, [SketchControlPointSpline](../objects/SketchControlPointSpline.md).Geometry, [SketchControlPointSplineProxy](../objects/SketchControlPointSplineProxy.md).Geometry, [SketchEquationCurve](../objects/SketchEquationCurve.md).Geometry, [SketchEquationCurveProxy](../objects/SketchEquationCurveProxy.md).Geometry, [SketchFixedSpline](../objects/SketchFixedSpline.md).Geometry, [SketchFixedSplineProxy](../objects/SketchFixedSplineProxy.md).Geometry, [SketchOffsetSpline](../objects/SketchOffsetSpline.md).Geometry, [SketchOffsetSplineProxy](../objects/SketchOffsetSplineProxy.md).Geometry, [SketchSpline](../objects/SketchSpline.md).Geometry, [SketchSplineProxy](../objects/SketchSplineProxy.md).Geometry, [TransientGeometry](../objects/TransientGeometry.md).CreateBSplineCurve2d, [TransientGeometry](../objects/TransientGeometry.md).CreateFittedBSplineCurve2d

**Referenced types:** [Curve2dEvaluator](../objects/Curve2dEvaluator.md), [Point2d](../objects/Point2d.md)

