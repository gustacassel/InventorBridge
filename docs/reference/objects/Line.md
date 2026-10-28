# Line

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateLine(…)`

```csharp
interface Line
{
    // Properties
    UnitVector Direction { get; set; }
    CurveEvaluator Evaluator { get; }
    bool IsColinearTo[object Line, double Tolerance = 0] { get; }
    Point RootPoint { get; set; }
    // Methods
    Line Copy();
    double DistanceTo(Point Point);
    void GetLineData(out double[] RootPoint, out double[] Direction);
    ObjectsEnumerator IntersectWithCurve(object Curve, double Tolerance = 0);
    ObjectsEnumerator IntersectWithSurface(object Surface, double Tolerance = 0);
    void PutLineData(out double[] RootPoint, out double[] Direction);
}
```

**Returned by:** [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md).XAxis, [DetailDrawingView](../objects/DetailDrawingView.md).DrawingViewToModelSpace, [DetailDrawingView](../objects/DetailDrawingView.md).SheetToModelSpace, [DrawingView](../objects/DrawingView.md).DrawingViewToModelSpace, [DrawingView](../objects/DrawingView.md).SheetToModelSpace, [Line](../objects/Line.md).Copy, [PlanarSketch](../objects/PlanarSketch.md).AxisEntityGeometry, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).AxisEntityGeometry, [Plane](../objects/Plane.md).IntersectWithPlane, [SectionDrawingView](../objects/SectionDrawingView.md).DrawingViewToModelSpace, [SectionDrawingView](../objects/SectionDrawingView.md).SheetToModelSpace, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).AxisEntityGeometry, [SketchBlockDefinitionProxy](../objects/SketchBlockDefinitionProxy.md).AxisEntityGeometry, [TransientGeometry](../objects/TransientGeometry.md).CreateLine, [WorkAxis](../objects/WorkAxis.md).Line, [WorkAxisProxy](../objects/WorkAxisProxy.md).Line

**Referenced types:** [CurveEvaluator](../objects/CurveEvaluator.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [Point](../objects/Point.md), [UnitVector](../objects/UnitVector.md)

