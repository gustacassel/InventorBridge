# EllipticalCone

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateEllipticalCone(…)`

```csharp
interface EllipticalCone
{
    // Properties
    UnitVector AxisVector { get; set; }
    Point BasePoint { get; set; }
    SurfaceEvaluator Evaluator { get; }
    double HalfAngle { get; set; }
    bool IsExpanding { get; set; }
    Vector MajorAxisVector { get; set; }
    double MinorMajorRatio { get; set; }
    // Methods
    EllipticalCone Copy();
    void GetEllipticalConeData(out double[] BasePoint, out double[] AxisVector, out double[] MajorAxis, out double MinorMajorRatio, out double HalfAngle, out bool IsExpanding);
    void PutEllipticalConeData(out double[] BasePoint, out double[] AxisVector, out double[] MajorAxis, double MinorMajorRatio, double HalfAngle, bool IsExpanding);
}
```

**Returned by:** [EllipticalCone](../objects/EllipticalCone.md).Copy, [TransientGeometry](../objects/TransientGeometry.md).CreateEllipticalCone

**Referenced types:** [Point](../objects/Point.md), [SurfaceEvaluator](../objects/SurfaceEvaluator.md), [UnitVector](../objects/UnitVector.md), [Vector](../objects/Vector.md)

