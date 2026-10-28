# Arc2d

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateArc2d(…)`

```csharp
interface Arc2d
{
    // Properties
    Point2d Center { get; set; }
    Point2d EndPoint { get; }
    Curve2dEvaluator Evaluator { get; }
    Point2d MidPoint { get; } // since 2025
    double Radius { get; set; }
    double StartAngle { get; set; }
    Point2d StartPoint { get; }
    double SweepAngle { get; set; }
    // Methods
    Arc2d Copy();
    void GetArcData(out double[] Center, out double Radius, out double StartAngle, out double SweepAngle);
    void PutArcData(out double[] Center, double Radius, double StartAngle, double SweepAngle);
}
```

**Returned by:** [Arc2d](../objects/Arc2d.md).Copy, [SketchArc](../objects/SketchArc.md).Geometry, [SketchArcProxy](../objects/SketchArcProxy.md).Geometry, [TransientGeometry](../objects/TransientGeometry.md).CreateArc2d, [TransientGeometry](../objects/TransientGeometry.md).CreateArc2dByThreePoints2

**Referenced types:** [Curve2dEvaluator](../objects/Curve2dEvaluator.md), [Point2d](../objects/Point2d.md)

