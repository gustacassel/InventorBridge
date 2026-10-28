# LineSegment2d

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateLineSegment2d(…)`

```csharp
interface LineSegment2d
{
    // Properties
    UnitVector2d Direction { get; }
    Point2d EndPoint { get; set; }
    Curve2dEvaluator Evaluator { get; }
    Point2d MidPoint { get; }
    Point2d StartPoint { get; set; }
    // Methods
    LineSegment2d Copy();
    double DistanceTo(Point2d Point);
    void GetLineSegmentData(out double[] StartPoint, out double[] EndPoint);
    ObjectsEnumerator IntersectWithCurve(object Curve, double Tolerance = 0);
    void PutLineSegmentData(out double[] StartPoint, out double[] EndPoint);
}
```

**Returned by:** [LineSegment2d](../objects/LineSegment2d.md).Copy, [SketchLine](../objects/SketchLine.md).Geometry, [SketchLineProxy](../objects/SketchLineProxy.md).Geometry, [SketchSplineHandle](../objects/SketchSplineHandle.md).Geometry, [SketchSplineHandleProxy](../objects/SketchSplineHandleProxy.md).Geometry, [TransientGeometry](../objects/TransientGeometry.md).CreateLineSegment2d

**Referenced types:** [Curve2dEvaluator](../objects/Curve2dEvaluator.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [Point2d](../objects/Point2d.md), [UnitVector2d](../objects/UnitVector2d.md)

