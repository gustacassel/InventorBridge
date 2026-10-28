# Polyline3d

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreatePolyline3d(…)`

```csharp
interface Polyline3d
{
    // Properties
    CurveEvaluator Evaluator { get; }
    Point PointAtIndex[int Index] { get; set; }
    int PointCount { get; }
    // Methods
    Polyline3d Copy();
    void GetPoints(out double[] Points);
    void PutPoints(object Points);
}
```

**Returned by:** [Polyline3d](../objects/Polyline3d.md).Copy, [TransientGeometry](../objects/TransientGeometry.md).CreatePolyline3d, [TransientGeometry](../objects/TransientGeometry.md).CreatePolyline3dFromCurve

**Referenced types:** [CurveEvaluator](../objects/CurveEvaluator.md), [Point](../objects/Point.md)

