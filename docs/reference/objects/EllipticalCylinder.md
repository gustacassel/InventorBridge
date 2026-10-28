# EllipticalCylinder

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateEllipticalCylinder(…)`

```csharp
interface EllipticalCylinder
{
    // Properties
    UnitVector AxisVector { get; set; }
    Point BasePoint { get; set; }
    SurfaceEvaluator Evaluator { get; }
    Vector MajorAxisVector { get; set; }
    double MinorMajorRatio { get; set; }
    // Methods
    EllipticalCylinder Copy();
    void GetEllipticalCylinderData(out double[] BasePoint, out double[] AxisVector, out double[] MajorAxis, out double MinorMajorRatio);
    void PutEllipticalCylinderData(out double[] BasePoint, out double[] AxisVector, out double[] MajorAxis, double MinorMajorRatio);
}
```

**Returned by:** [EllipticalCylinder](../objects/EllipticalCylinder.md).Copy, [TransientGeometry](../objects/TransientGeometry.md).CreateEllipticalCylinder

**Referenced types:** [Point](../objects/Point.md), [SurfaceEvaluator](../objects/SurfaceEvaluator.md), [UnitVector](../objects/UnitVector.md), [Vector](../objects/Vector.md)

