# Plane

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreatePlane(…)`

```csharp
interface Plane
{
    // Properties
    SurfaceEvaluator Evaluator { get; }
    bool IsCoplanarTo[Plane Plane, double Tolerance = 0] { get; }
    bool IsParallelTo[object LineOrPlane, double Tolerance = 0] { get; }
    bool IsPerpendicularTo[object LineOrPlane, double Tolerance = 0] { get; }
    UnitVector Normal { get; set; }
    Point RootPoint { get; set; }
    // Methods
    Plane Copy();
    double DistanceTo(Point Point);
    void GetPlaneData(out double[] RootPoint, out double[] Normal);
    ObjectsEnumerator IntersectWithCurve(object Curve, double Tolerance = 0);
    Point IntersectWithLine(object Line, double Tolerance = 0);
    Line IntersectWithPlane(Plane Plane, double Tolerance = 0);
    ObjectsEnumerator IntersectWithSurface(object Surface, double Tolerance = 0);
    void PutPlaneData(out double[] RootPoint, out double[] Normal);
}
```

**Returned by:** [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md).Plane, [DimensionConstraint3D](../objects/DimensionConstraint3D.md).DimensionPlane, [DimensionConstraints3D](../objects/DimensionConstraints3D.md).GetDimensionPlane, [GroundPlaneSettings](../objects/GroundPlaneSettings.md).Plane, [LineLengthDimConstraint3D](../objects/LineLengthDimConstraint3D.md).DimensionPlane, [LineLengthDimConstraint3DProxy](../objects/LineLengthDimConstraint3DProxy.md).DimensionPlane, [PlanarSketch](../objects/PlanarSketch.md).PlanarEntityGeometry, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).PlanarEntityGeometry, [Plane](../objects/Plane.md).Copy, [PointAndPlaneDistanceDimConstraint3D](../objects/PointAndPlaneDistanceDimConstraint3D.md).DimensionPlane, [PointAndPlaneDistanceDimConstraint3DProxy](../objects/PointAndPlaneDistanceDimConstraint3DProxy.md).DimensionPlane, [PointCloudPlane](../objects/PointCloudPlane.md).Geometry, [PointCloudPlaneProxy](../objects/PointCloudPlaneProxy.md).Geometry, [RadiusDimConstraint3D](../objects/RadiusDimConstraint3D.md).DimensionPlane, [RadiusDimConstraint3DProxy](../objects/RadiusDimConstraint3DProxy.md).DimensionPlane, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).PlanarEntityGeometry, [SketchBlockDefinitionProxy](../objects/SketchBlockDefinitionProxy.md).PlanarEntityGeometry, [SplineLengthDimConstraint3D](../objects/SplineLengthDimConstraint3D.md).DimensionPlane, [SplineLengthDimConstraint3DProxy](../objects/SplineLengthDimConstraint3DProxy.md).DimensionPlane, [TransientGeometry](../objects/TransientGeometry.md).CreatePlane, [TransientGeometry](../objects/TransientGeometry.md).CreatePlaneByThreePoints, [TwoLineAngleDimConstraint3D](../objects/TwoLineAngleDimConstraint3D.md).DimensionPlane, [TwoLineAngleDimConstraint3DProxy](../objects/TwoLineAngleDimConstraint3DProxy.md).DimensionPlane, [TwoPointDistanceDimConstraint3D](../objects/TwoPointDistanceDimConstraint3D.md).DimensionPlane, [TwoPointDistanceDimConstraint3DProxy](../objects/TwoPointDistanceDimConstraint3DProxy.md).DimensionPlane, [WorkPlane](../objects/WorkPlane.md).Plane, [WorkPlaneProxy](../objects/WorkPlaneProxy.md).Plane

**Referenced types:** [Line](../objects/Line.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [Point](../objects/Point.md), [SurfaceEvaluator](../objects/SurfaceEvaluator.md), [UnitVector](../objects/UnitVector.md)

