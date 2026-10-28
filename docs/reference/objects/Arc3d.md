# Arc3d

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateArc3d(…)`

```csharp
interface Arc3d
{
    // Properties
    Point Center { get; set; }
    Point EndPoint { get; }
    CurveEvaluator Evaluator { get; }
    UnitVector Normal { get; set; }
    double Radius { get; set; }
    UnitVector ReferenceVector { get; set; }
    double StartAngle { get; set; }
    Point StartPoint { get; }
    double SweepAngle { get; set; }
    // Methods
    Arc3d Copy();
    void GetArcData(out double[] Center, out double[] AxisVector, out double[] RefVector, out double Radius, out double StartAngle, out double SweepAngle);
    void PutArcData(out double[] Center, out double[] AxisVector, out double[] RefVector, double Radius, double StartAngle, double SweepAngle);
}
```

**Returned by:** [Arc3d](../objects/Arc3d.md).Copy, [SketchArc](../objects/SketchArc.md).Geometry3d, [SketchArc3D](../objects/SketchArc3D.md).Geometry, [SketchArc3DProxy](../objects/SketchArc3DProxy.md).Geometry, [SketchArcProxy](../objects/SketchArcProxy.md).Geometry3d, [TransientGeometry](../objects/TransientGeometry.md).CreateArc3d, [TransientGeometry](../objects/TransientGeometry.md).CreateArc3dByThreePoints

**Referenced types:** [CurveEvaluator](../objects/CurveEvaluator.md), [Point](../objects/Point.md), [UnitVector](../objects/UnitVector.md)

