# Sphere

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateSphere(…)`

```csharp
interface Sphere
{
    // Properties
    Point CenterPoint { get; set; }
    SurfaceEvaluator Evaluator { get; }
    double Radius { get; set; }
    // Methods
    Sphere Copy();
    void GetSphereData(out double[] CenterPoint, out double Radius);
    void PutSphereData(out double[] CenterPoint, double Radius);
}
```

**Returned by:** [Sphere](../objects/Sphere.md).Copy, [TransientGeometry](../objects/TransientGeometry.md).CreateSphere

**Referenced types:** [Point](../objects/Point.md), [SurfaceEvaluator](../objects/SurfaceEvaluator.md)

