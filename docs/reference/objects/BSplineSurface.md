# BSplineSurface

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateBSplineSurface(…)`

```csharp
interface BSplineSurface
{
    // Properties
    SurfaceEvaluator Evaluator { get; }
    Point PoleAtIndex[int IndexU, int IndexV] { get; set; }
    // Methods
    BSplineSurface Copy();
    void GetBSplineData(out double[] Poles, out double[] KnotsU, out double[] KnotsV, out double[] Weights);
    void GetBSplineInfo(out int[] Order, out int[] NumPoles, out int[] NumKnots, out bool IsRational, out bool[] IsPeriodic, out bool[] IsClosed, out bool IsPlanar, out double[] PlaneVector);
    void PutBSplineInfoAndData(out int[] Order, out double[] Poles, out double[] KnotsU, out double[] KnotsV, out double[] Weights, out bool[] IsPeriodic);
}
```

**Returned by:** [BSplineSurface](../objects/BSplineSurface.md).Copy, [TransientGeometry](../objects/TransientGeometry.md).CreateBSplineSurface

**Referenced types:** [Point](../objects/Point.md), [SurfaceEvaluator](../objects/SurfaceEvaluator.md)

