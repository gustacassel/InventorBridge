# TransientGeometry

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry`

```csharp
interface TransientGeometry
{
    // Properties
    double PointTolerance { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    Arc2d CreateArc2d(Point2d Center, double Radius, double StartAngle, double SweepAngle);
    Arc2d CreateArc2dByThreePoints2(Point2d PointOne, Point2d PointTwo, Point2d PointThree); // since 2025
    Arc3d CreateArc3d(Point Center, UnitVector Normal, UnitVector ReferenceVector, double Radius, double StartAngle, double SweepAngle);
    Arc3d CreateArc3dByThreePoints(Point PointOne, Point PointTwo, Point PointThree);
    BSplineCurve CreateBSplineCurve(int Order, out double[] Poles, out double[] Knots, out double[] Weights, bool IsPeriodic);
    BSplineCurve2d CreateBSplineCurve2d(int Order, out double[] Poles, out double[] Knots, out double[] Weights, bool IsPeriodic);
    BSplineCurve2dDefinition CreateBSplineCurve2dDefinition();
    BSplineCurveDefinition CreateBSplineCurveDefinition();
    BSplineSurface CreateBSplineSurface(ref int[] Order, ref double[] Poles, ref double[] KnotsU, ref double[] KnotsV, ref double[] Weights, ref bool[] IsPeriodic);
    Box CreateBox();
    Box2d CreateBox2d();
    Circle CreateCircle(Point Center, UnitVector Normal, double Radius);
    Circle2d CreateCircle2d(Point2d Center, double Radius);
    Circle2d CreateCircle2dByThreePoints(Point2d PointOne, Point2d PointTwo, Point2d PointThree);
    Circle CreateCircleByThreePoints(Point PointOne, Point PointTwo, Point PointThree);
    Cone CreateCone(Point RootPoint, UnitVector Axis, double Radius, double HalfAngle, bool IsExpanding);
    Cylinder CreateCylinder(Point RootPoint, UnitVector Axis, double Radius);
    EllipseFull CreateEllipseFull(Point Center, UnitVector Normal, Vector MajorAxisVector, double MinorMajorRatio);
    EllipseFull2d CreateEllipseFull2d(Point2d Center, Vector2d MajorAxisVector, double MinorMajorRatio);
    EllipticalArc CreateEllipticalArc(Point Center, UnitVector MajorAxis, UnitVector MinorAxis, double MajorRadius, double MinorRadius, double StartAngle, double SweepAngle);
    EllipticalArc2d CreateEllipticalArc2d(Point2d Center, UnitVector2d MajorAxis, double MajorRadius, double MinorRadius, double StartAngle, double SweepAngle);
    EllipticalCone CreateEllipticalCone(Point BasePoint, UnitVector AxisVector, Vector MajorAxisVector, double MinorMajorRatio, double HalfAngle, bool IsExpanding);
    EllipticalCylinder CreateEllipticalCylinder(Point BasePoint, UnitVector AxisVector, Vector MajorAxisVector, double MinorMajorRatio);
    BSplineCurve CreateFittedBSplineCurve(BSplineCurveDefinition Definition);
    BSplineCurve2d CreateFittedBSplineCurve2d(BSplineCurve2dDefinition Definition);
    Line CreateLine(Point RootPoint, Vector Direction);
    Line2d CreateLine2d(Point2d RootPoint, UnitVector2d Direction);
    LineSegment CreateLineSegment(Point StartPoint, Point EndPoint);
    LineSegment2d CreateLineSegment2d(Point2d StartPoint, Point2d EndPoint);
    Matrix CreateMatrix();
    Matrix2d CreateMatrix2d();
    OrientedBox CreateOrientedBox(object CornerPoint = Missing, object DirectionOne = Missing, object DirectionTwo = Missing, object DirectionThree = Missing);
    Plane CreatePlane(Point RootPoint, Vector Normal);
    Plane CreatePlaneByThreePoints(Point PointOne, Point PointTwo, Point PointThree);
    Point CreatePoint(double XCoord = 0, double YCoord = 0, double ZCoord = 0);
    Point2d CreatePoint2d(double XCoord = 0, double YCoord = 0);
    Polyline2d CreatePolyline2d(object Points);
    Polyline2d CreatePolyline2dFromCurve(object Curve, double Tolerance);
    Polyline3d CreatePolyline3d(object Points);
    Polyline3d CreatePolyline3dFromCurve(object Curve, double Tolerance);
    Sphere CreateSphere(Point CenterPoint, double Radius);
    Torus CreateTorus(Point CenterPoint, UnitVector AxisVector, double MajorRadius, double MinorRadius);
    UnitVector CreateUnitVector(double XCoord = 0, double YCoord = 0, double ZCoord = 1);
    UnitVector2d CreateUnitVector2d(double XCoord = 0, double YCoord = 1);
    Vector CreateVector(double XCoord = 0, double YCoord = 0, double ZCoord = 0);
    Vector2d CreateVector2d(double XCoord = 0, double YCoord = 0);
    ObjectsEnumerator CurveCurveIntersection(object CurveOne, object CurveTwo, double Tolerance = 0);
    ObjectsEnumerator CurveSurfaceIntersection(object Curve, object Surface, double Tolerance = 0);
    Point GetFarmostPoint(object Entity, UnitVector Direction);
    ObjectsEnumerator SurfaceSurfaceIntersection(object SurfaceOne, object SurfaceTwo, double Tolerance = 0);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).TransientGeometry, [ApprenticeServer](../objects/ApprenticeServer.md).TransientGeometry, [ApprenticeServerComponent](../objects/ApprenticeServerComponent.md).TransientGeometry, [InventorServer](../objects/InventorServer.md).TransientGeometry

**Referenced types:** [Arc2d](../objects/Arc2d.md), [Arc3d](../objects/Arc3d.md), [BSplineCurve](../objects/BSplineCurve.md), [BSplineCurve2d](../objects/BSplineCurve2d.md), [BSplineCurve2dDefinition](../objects/BSplineCurve2dDefinition.md), [BSplineCurveDefinition](../objects/BSplineCurveDefinition.md), [BSplineSurface](../objects/BSplineSurface.md), [Box](../objects/Box.md), [Box2d](../objects/Box2d.md), [Circle](../objects/Circle.md), [Circle2d](../objects/Circle2d.md), [Cone](../objects/Cone.md), [Cylinder](../objects/Cylinder.md), [EllipseFull](../objects/EllipseFull.md), [EllipseFull2d](../objects/EllipseFull2d.md), [EllipticalArc](../objects/EllipticalArc.md), [EllipticalArc2d](../objects/EllipticalArc2d.md), [EllipticalCone](../objects/EllipticalCone.md), [EllipticalCylinder](../objects/EllipticalCylinder.md), [Line](../objects/Line.md), [Line2d](../objects/Line2d.md), [LineSegment](../objects/LineSegment.md), [LineSegment2d](../objects/LineSegment2d.md), [Matrix](../objects/Matrix.md), [Matrix2d](../objects/Matrix2d.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [OrientedBox](../objects/OrientedBox.md), [Plane](../objects/Plane.md), [Point](../objects/Point.md), [Point2d](../objects/Point2d.md), [Polyline2d](../objects/Polyline2d.md), [Polyline3d](../objects/Polyline3d.md), [Sphere](../objects/Sphere.md), [Torus](../objects/Torus.md), [UnitVector](../objects/UnitVector.md), [UnitVector2d](../objects/UnitVector2d.md), [Vector](../objects/Vector.md), [Vector2d](../objects/Vector2d.md)

