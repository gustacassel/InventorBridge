# Point2d

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreatePoint2d(…)`

```csharp
interface Point2d
{
    // Properties
    double X { get; set; }
    double Y { get; set; }
    // Methods
    Point2d Copy();
    double DistanceTo(Point2d Point);
    void GetPointData(out double[] Coords);
    bool IsEqualTo(Point2d Point, double Tolerance = 0);
    void PutPointData(out double[] Coords);
    void TransformBy(Matrix2d Matrix);
    void TranslateBy(Vector2d Vector);
    Vector2d VectorTo(Point2d Point);
}
```

**Returned by:** [AngularGeneralDimension](../objects/AngularGeneralDimension.md).SecondArrowheadPosition, [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md).ModelToAnnotationPlane, [Arc2d](../objects/Arc2d.md).Center, [Arc2d](../objects/Arc2d.md).EndPoint, [Arc2d](../objects/Arc2d.md).MidPoint, [Arc2d](../objects/Arc2d.md).StartPoint, [ArcLengthDimConstraint](../objects/ArcLengthDimConstraint.md).DimensionCenterPoint, [ArcLengthDimConstraint](../objects/ArcLengthDimConstraint.md).TextPoint, [ArcLengthDimConstraintProxy](../objects/ArcLengthDimConstraintProxy.md).DimensionCenterPoint, [ArcLengthDimConstraintProxy](../objects/ArcLengthDimConstraintProxy.md).TextPoint, [AutoCADBlock](../objects/AutoCADBlock.md).Position, [BSplineCurve2d](../objects/BSplineCurve2d.md).PoleAtIndex, [Balloon](../objects/Balloon.md).Position, [BendNote](../objects/BendNote.md).Position, [Box2d](../objects/Box2d.md).MaxPoint, [Box2d](../objects/Box2d.md).MinPoint, [BreakOperation](../objects/BreakOperation.md).EndPoint, [BreakOperation](../objects/BreakOperation.md).MidPoint, [BreakOperation](../objects/BreakOperation.md).StartPoint, [Camera](../objects/Camera.md).ModelToViewSpace, [Centerline](../objects/Centerline.md).EndPoint, [Centerline](../objects/Centerline.md).StartPoint, [Centermark](../objects/Centermark.md).ExtensionPointFour, [Centermark](../objects/Centermark.md).ExtensionPointOne, [Centermark](../objects/Centermark.md).ExtensionPointThree, [Centermark](../objects/Centermark.md).ExtensionPointTwo, [Centermark](../objects/Centermark.md).Position, [ChamferNote](../objects/ChamferNote.md).Position, [Circle2d](../objects/Circle2d.md).Center, [CustomTable](../objects/CustomTable.md).Position, [DetailDrawingView](../objects/DetailDrawingView.md).Center, [DetailDrawingView](../objects/DetailDrawingView.md).DrawingViewToSheetSpace, [DetailDrawingView](../objects/DetailDrawingView.md).FenceCenter, [DetailDrawingView](../objects/DetailDrawingView.md).FenceCornerOne, [DetailDrawingView](../objects/DetailDrawingView.md).FenceCornerTwo, [DetailDrawingView](../objects/DetailDrawingView.md).ModelToDrawingViewSpace, [DetailDrawingView](../objects/DetailDrawingView.md).ModelToSheetSpace, [DetailDrawingView](../objects/DetailDrawingView.md).Position, [DetailDrawingView](../objects/DetailDrawingView.md).SheetToDrawingViewSpace, [DiameterDimConstraint](../objects/DiameterDimConstraint.md).DimensionCenterPoint and 113 more (see `members.tsv`)

**Referenced types:** [Matrix2d](../objects/Matrix2d.md), [Vector2d](../objects/Vector2d.md)

