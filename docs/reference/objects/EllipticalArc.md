# EllipticalArc

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateEllipticalArc(…)`

```csharp
interface EllipticalArc
{
    // Properties
    Point Center { get; set; }
    Point EndPoint { get; }
    CurveEvaluator Evaluator { get; }
    UnitVector MajorAxis { get; set; }
    double MajorRadius { get; set; }
    UnitVector MinorAxis { get; set; }
    double MinorRadius { get; set; }
    double StartAngle { get; set; }
    Point StartPoint { get; }
    double SweepAngle { get; set; }
    // Methods
    EllipticalArc Copy();
    void GetEllipticalArcData(out double[] Center, out double[] MajorAxis, out double[] MinorAxis, out double MajorRadius, out double MinorRadius, out double StartAngle, out double SweepAngle);
    void PutEllipticalArcData(out double[] Center, out double[] MajorAxis, out double[] MinorAxis, double MajorRadius, double MinorRadius, double StartAngle, double SweepAngle);
}
```

**Returned by:** [EllipticalArc](../objects/EllipticalArc.md).Copy, [SketchEllipticalArc](../objects/SketchEllipticalArc.md).Geometry3d, [SketchEllipticalArc3D](../objects/SketchEllipticalArc3D.md).Geometry, [SketchEllipticalArc3DProxy](../objects/SketchEllipticalArc3DProxy.md).Geometry, [SketchEllipticalArcProxy](../objects/SketchEllipticalArcProxy.md).Geometry3d, [TransientGeometry](../objects/TransientGeometry.md).CreateEllipticalArc

**Referenced types:** [CurveEvaluator](../objects/CurveEvaluator.md), [Point](../objects/Point.md), [UnitVector](../objects/UnitVector.md)

