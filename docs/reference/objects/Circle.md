# Circle

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateCircle(…)`

```csharp
interface Circle
{
    // Properties
    Point Center { get; set; }
    CurveEvaluator Evaluator { get; }
    UnitVector Normal { get; set; }
    double Radius { get; set; }
    // Methods
    Circle Copy();
    void GetCircleData(out double[] Center, out double[] AxisVector, out double Radius);
    void PutCircleData(out double[] Center, out double[] AxisVector, double Radius);
}
```

**Returned by:** [Circle](../objects/Circle.md).Copy, [SketchCircle](../objects/SketchCircle.md).Geometry3d, [SketchCircle3D](../objects/SketchCircle3D.md).Geometry, [SketchCircle3DProxy](../objects/SketchCircle3DProxy.md).Geometry, [SketchCircleProxy](../objects/SketchCircleProxy.md).Geometry3d, [TransientGeometry](../objects/TransientGeometry.md).CreateCircle, [TransientGeometry](../objects/TransientGeometry.md).CreateCircleByThreePoints

**Referenced types:** [CurveEvaluator](../objects/CurveEvaluator.md), [Point](../objects/Point.md), [UnitVector](../objects/UnitVector.md)

