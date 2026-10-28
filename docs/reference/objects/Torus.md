# Torus

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateTorus(…)`

```csharp
interface Torus
{
    // Properties
    UnitVector AxisVector { get; set; }
    Point CenterPoint { get; set; }
    SurfaceEvaluator Evaluator { get; }
    double MajorRadius { get; set; }
    double MinorRadius { get; set; }
    // Methods
    Torus Copy();
    void GetTorusData(out double[] CenterPoint, out double[] AxisVector, out double MajorRadius, out double MinorRadius);
    void PutTorusData(out double[] CenterPoint, out double[] AxisVector, double MajorRadius, double MinorRadius);
}
```

**Returned by:** [Torus](../objects/Torus.md).Copy, [TransientGeometry](../objects/TransientGeometry.md).CreateTorus

**Referenced types:** [Point](../objects/Point.md), [SurfaceEvaluator](../objects/SurfaceEvaluator.md), [UnitVector](../objects/UnitVector.md)

