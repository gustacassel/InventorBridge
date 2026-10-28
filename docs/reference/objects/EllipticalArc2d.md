# EllipticalArc2d

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateEllipticalArc2d(…)`

```csharp
interface EllipticalArc2d
{
    // Properties
    Point2d Center { get; set; }
    Point2d EndPoint { get; }
    Curve2dEvaluator Evaluator { get; }
    UnitVector2d MajorAxis { get; set; }
    double MajorRadius { get; set; }
    double MinorRadius { get; set; }
    double StartAngle { get; set; }
    Point2d StartPoint { get; }
    double SweepAngle { get; set; }
    // Methods
    EllipticalArc2d Copy();
    void GetEllipticalArcData(out double[] Center, out double[] MajorAxis, out double MajorRadius, out double MinorRadius, out double StartAngle, out double SweepAngle);
    void PutEllipticalArcData(out double[] Center, out double[] MajorAxis, double MajorRadius, double MinorRadius, double StartAngle, double SweepAngle);
}
```

**Returned by:** [EllipticalArc2d](../objects/EllipticalArc2d.md).Copy, [SketchEllipticalArc](../objects/SketchEllipticalArc.md).Geometry, [SketchEllipticalArcProxy](../objects/SketchEllipticalArcProxy.md).Geometry, [TransientGeometry](../objects/TransientGeometry.md).CreateEllipticalArc2d

**Referenced types:** [Curve2dEvaluator](../objects/Curve2dEvaluator.md), [Point2d](../objects/Point2d.md), [UnitVector2d](../objects/UnitVector2d.md)

