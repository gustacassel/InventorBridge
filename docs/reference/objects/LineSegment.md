# LineSegment

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateLineSegment(…)`

```csharp
interface LineSegment
{
    // Properties
    UnitVector Direction { get; }
    Point EndPoint { get; set; }
    CurveEvaluator Evaluator { get; }
    Point MidPoint { get; }
    Point StartPoint { get; set; }
    // Methods
    LineSegment Copy();
    double DistanceTo(Point Point);
    void GetLineSegmentData(out double[] StartPoint, out double[] EndPoint);
    ObjectsEnumerator IntersectWithCurve(object Curve, double Tolerance = 0);
    ObjectsEnumerator IntersectWithSurface(object Surface, double Tolerance = 0);
    void PutLineSegmentData(out double[] StartPoint, out double[] EndPoint);
}
```

**Returned by:** [AngularModelDimension](../objects/AngularModelDimension.md).ExtensionLineOne, [AngularModelDimension](../objects/AngularModelDimension.md).ExtensionLineTwo, [AngularModelDimensionProxy](../objects/AngularModelDimensionProxy.md).ExtensionLineOne, [AngularModelDimensionProxy](../objects/AngularModelDimensionProxy.md).ExtensionLineTwo, [DWGEntityLineSegment](../objects/DWGEntityLineSegment.md).Geometry, [DWGEntityLineSegmentProxy](../objects/DWGEntityLineSegmentProxy.md).Geometry, [LineSegment](../objects/LineSegment.md).Copy, [SketchLine](../objects/SketchLine.md).Geometry3d, [SketchLine3D](../objects/SketchLine3D.md).Geometry, [SketchLine3DProxy](../objects/SketchLine3DProxy.md).Geometry, [SketchLineProxy](../objects/SketchLineProxy.md).Geometry3d, [SketchSplineHandle](../objects/SketchSplineHandle.md).Geometry3d, [SketchSplineHandle3D](../objects/SketchSplineHandle3D.md).Geometry, [SketchSplineHandle3DProxy](../objects/SketchSplineHandle3DProxy.md).Geometry, [SketchSplineHandleProxy](../objects/SketchSplineHandleProxy.md).Geometry3d, [TransientGeometry](../objects/TransientGeometry.md).CreateLineSegment

**Referenced types:** [CurveEvaluator](../objects/CurveEvaluator.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [Point](../objects/Point.md), [UnitVector](../objects/UnitVector.md)

