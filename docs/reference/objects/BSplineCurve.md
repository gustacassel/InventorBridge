# BSplineCurve

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateBSplineCurve(…)`

```csharp
interface BSplineCurve
{
    // Properties
    CurveEvaluator Evaluator { get; }
    Point PoleAtIndex[int Index] { get; set; }
    // Methods
    BSplineCurve Copy();
    BSplineCurve ExtractPartial(double StartParam, double EndParam);
    void GetBSplineData(out double[] Poles, out double[] Knots, out double[] Weights);
    void GetBSplineInfo(out int Order, out int NumPoles, out int NumKnots, out bool IsRational, out bool IsPeriodic, out bool IsClosed, out bool IsPlanar, out double[] PlaneVector);
    void PutBSplineInfoAndData(int Order, out double[] Poles, out double[] Knots, out double[] Weights, bool IsPeriodic);
    void Split(double SplitParam, out BSplineCurve CurveOne, out BSplineCurve CurveTwo);
}
```

**Returned by:** [BSplineCurve](../objects/BSplineCurve.md).Copy, [BSplineCurve](../objects/BSplineCurve.md).ExtractPartial, [SketchControlPointSpline](../objects/SketchControlPointSpline.md).Geometry3d, [SketchControlPointSpline3D](../objects/SketchControlPointSpline3D.md).Geometry, [SketchControlPointSpline3DProxy](../objects/SketchControlPointSpline3DProxy.md).Geometry, [SketchControlPointSplineProxy](../objects/SketchControlPointSplineProxy.md).Geometry3d, [SketchEquationCurve](../objects/SketchEquationCurve.md).Geometry3d, [SketchEquationCurve3D](../objects/SketchEquationCurve3D.md).Geometry, [SketchEquationCurve3DProxy](../objects/SketchEquationCurve3DProxy.md).Geometry, [SketchEquationCurveProxy](../objects/SketchEquationCurveProxy.md).Geometry3d, [SketchFixedSpline](../objects/SketchFixedSpline.md).Geometry3d, [SketchFixedSpline3D](../objects/SketchFixedSpline3D.md).Geometry, [SketchFixedSpline3DProxy](../objects/SketchFixedSpline3DProxy.md).Geometry, [SketchFixedSplineProxy](../objects/SketchFixedSplineProxy.md).Geometry3d, [SketchOffsetSpline](../objects/SketchOffsetSpline.md).Geometry3d, [SketchOffsetSplineProxy](../objects/SketchOffsetSplineProxy.md).Geometry3d, [SketchSpline](../objects/SketchSpline.md).Geometry3d, [SketchSpline3D](../objects/SketchSpline3D.md).Geometry, [SketchSpline3DProxy](../objects/SketchSpline3DProxy.md).Geometry, [SketchSplineProxy](../objects/SketchSplineProxy.md).Geometry3d, [TransientGeometry](../objects/TransientGeometry.md).CreateBSplineCurve, [TransientGeometry](../objects/TransientGeometry.md).CreateFittedBSplineCurve

**Referenced types:** [CurveEvaluator](../objects/CurveEvaluator.md), [Point](../objects/Point.md)

