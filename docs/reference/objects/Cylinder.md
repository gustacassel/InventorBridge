# Cylinder

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateCylinder(…)`

```csharp
interface Cylinder
{
    // Properties
    UnitVector AxisVector { get; set; }
    Point BasePoint { get; set; }
    SurfaceEvaluator Evaluator { get; }
    double Radius { get; set; }
    // Methods
    Cylinder Copy();
    void GetCylinderData(ref double[] BasePoint, ref double[] AxisVector, out double Radius);
    void PutCylinderData(ref double[] BasePoint, ref double[] AxisVector, double Radius);
}
```

**Returned by:** [Cylinder](../objects/Cylinder.md).Copy, [TransientGeometry](../objects/TransientGeometry.md).CreateCylinder

**Referenced types:** [Point](../objects/Point.md), [SurfaceEvaluator](../objects/SurfaceEvaluator.md), [UnitVector](../objects/UnitVector.md)

