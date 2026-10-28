# EllipseFull

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateEllipseFull(…)`

```csharp
interface EllipseFull
{
    // Properties
    Point Center { get; set; }
    CurveEvaluator Evaluator { get; }
    Vector MajorAxisVector { get; set; }
    double MinorMajorRatio { get; set; }
    UnitVector Normal { get; set; }
    // Methods
    EllipseFull Copy();
    void GetEllipseFullData(out double[] Center, out double[] AxisVector, out double[] MajorAxis, out double MinorMajorRatio);
    void PutEllipseFullData(out double[] Center, out double[] AxisVector, out double[] MajorAxis, double MinorMajorRatio);
}
```

**Returned by:** [EllipseFull](../objects/EllipseFull.md).Copy, [SketchEllipse](../objects/SketchEllipse.md).Geometry3d, [SketchEllipse3D](../objects/SketchEllipse3D.md).Geometry, [SketchEllipse3DProxy](../objects/SketchEllipse3DProxy.md).Geometry, [SketchEllipseProxy](../objects/SketchEllipseProxy.md).Geometry3d, [TransientGeometry](../objects/TransientGeometry.md).CreateEllipseFull

**Referenced types:** [CurveEvaluator](../objects/CurveEvaluator.md), [Point](../objects/Point.md), [UnitVector](../objects/UnitVector.md), [Vector](../objects/Vector.md)

