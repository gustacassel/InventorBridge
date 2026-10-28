# Polyline2d

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreatePolyline2d(…)`

```csharp
interface Polyline2d
{
    // Properties
    Curve2dEvaluator Evaluator { get; }
    Point2d PointAtIndex[int Index] { get; set; }
    int PointCount { get; }
    // Methods
    Polyline2d Copy();
    void GetPoints(out double[] Points);
    void PutPoints(object Points);
}
```

**Returned by:** [Polyline2d](../objects/Polyline2d.md).Copy, [TransientGeometry](../objects/TransientGeometry.md).CreatePolyline2d, [TransientGeometry](../objects/TransientGeometry.md).CreatePolyline2dFromCurve

**Referenced types:** [Curve2dEvaluator](../objects/Curve2dEvaluator.md), [Point2d](../objects/Point2d.md)

