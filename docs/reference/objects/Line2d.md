# Line2d

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateLine2d(…)`

```csharp
interface Line2d
{
    // Properties
    UnitVector2d Direction { get; set; }
    Curve2dEvaluator Evaluator { get; }
    Point2d RootPoint { get; set; }
    // Methods
    Line2d Copy();
    double DistanceTo(Point2d Point);
    void GetLineData(out double[] RootPoint, out double[] Direction);
    ObjectsEnumerator IntersectWithCurve(object Curve, double Tolerance = 0);
    void PutLineData(out double[] RootPoint, out double[] Direction);
}
```

**Returned by:** [Line2d](../objects/Line2d.md).Copy, [TransientGeometry](../objects/TransientGeometry.md).CreateLine2d

**Referenced types:** [Curve2dEvaluator](../objects/Curve2dEvaluator.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [Point2d](../objects/Point2d.md), [UnitVector2d](../objects/UnitVector2d.md)

