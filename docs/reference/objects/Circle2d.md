# Circle2d

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateCircle2d(…)`

```csharp
interface Circle2d
{
    // Properties
    Point2d Center { get; set; }
    Curve2dEvaluator Evaluator { get; }
    double Radius { get; set; }
    // Methods
    Circle2d Copy();
    void GetCircleData(out double[] Center, out double Radius);
    void PutCircleData(out double[] Center, double Radius);
}
```

**Returned by:** [Circle2d](../objects/Circle2d.md).Copy, [SketchCircle](../objects/SketchCircle.md).Geometry, [SketchCircleProxy](../objects/SketchCircleProxy.md).Geometry, [TransientGeometry](../objects/TransientGeometry.md).CreateCircle2d, [TransientGeometry](../objects/TransientGeometry.md).CreateCircle2dByThreePoints

**Referenced types:** [Curve2dEvaluator](../objects/Curve2dEvaluator.md), [Point2d](../objects/Point2d.md)

