# Cone

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateCone(…)`

```csharp
interface Cone
{
    // Properties
    UnitVector AxisVector { get; set; }
    Point BasePoint { get; set; }
    SurfaceEvaluator Evaluator { get; }
    double HalfAngle { get; set; }
    bool IsExpanding { get; set; }
    double Radius { get; set; }
    // Methods
    Cone Copy();
    void GetConeData(out double[] BasePoint, out double[] AxisVector, out double Radius, out double HalfAngle, out bool IsExpanding);
    void PutConeData(out double[] BasePoint, out double[] AxisVector, double Radius, double HalfAngle, bool IsExpanding);
}
```

**Returned by:** [Cone](../objects/Cone.md).Copy, [TransientGeometry](../objects/TransientGeometry.md).CreateCone

**Referenced types:** [Point](../objects/Point.md), [SurfaceEvaluator](../objects/SurfaceEvaluator.md), [UnitVector](../objects/UnitVector.md)

