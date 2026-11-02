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
    void GetBSplineData(ref double[] Poles, ref double[] KnotsU, ref double[] KnotsV, ref double[] Weights);
    void GetBSplineInfo(ref int[] Order, ref int[] NumPoles, ref int[] NumKnots, out bool IsRational, ref bool[] IsPeriodic, ref bool[] IsClosed, out bool IsPlanar, ref double[] PlaneVector);
    void PutBSplineInfoAndData(ref int[] Order, ref double[] Poles, ref double[] KnotsU, ref double[] KnotsV, ref double[] Weights, ref bool[] IsPeriodic);
}
```

**Returned by:** [BSplineSurface](../objects/BSplineSurface.md).Copy, [TransientGeometry](../objects/TransientGeometry.md).CreateBSplineSurface

**Referenced types:** [Point](../objects/Point.md), [SurfaceEvaluator](../objects/SurfaceEvaluator.md)

