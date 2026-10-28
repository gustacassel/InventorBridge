# DimensionConstraints

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].DimensionConstraints`

```csharp
interface DimensionConstraints
{
    // Properties
    object Application { get; }
    int Count { get; }
    DimensionConstraint Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ArcLengthDimConstraint AddArcLength(SketchEntity Entity, Point2d TextPoint, bool Driven = false);
    DiameterDimConstraint AddDiameter(SketchEntity Entity, Point2d TextPoint, bool Driven = false);
    EllipseRadiusDimConstraint AddEllipseRadius(SketchEntity Entity, bool MajorRadius, Point2d TextPoint, object PositiveSide = Missing, bool Driven = false);
    OffsetDimConstraint AddOffset(SketchLine Line, SketchEntity Entity, Point2d TextPoint, bool LinearDiameter, bool Driven = false);
    OffsetSplineDimConstraint AddOffsetSpline(SketchOffsetSpline Line, Point2d TextPoint, bool Driven = false);
    RadiusDimConstraint AddRadius(SketchEntity Entity, Point2d TextPoint, bool Driven = false);
    TangentDistanceDimConstraint AddTangentDistance(SketchEntity EntityOne, SketchEntity EntityTwo, Point2d ProximityPointOne, Point2d ProximityPointTwo, Point2d TextPoint, bool LinearDiameter, bool Driven = false);
    ThreePointAngleDimConstraint AddThreePointAngle(SketchPoint PointOne, SketchPoint PointTwo, SketchPoint PointThree, Point2d TextPoint, bool Driven = false);
    TwoLineAngleDimConstraint AddTwoLineAngle(SketchLine LineOne, SketchLine LineTwo, Point2d TextPoint, bool Driven = false);
    TwoPointDistanceDimConstraint AddTwoPointDistance(SketchPoint PointOne, SketchPoint PointTwo, DimensionOrientationEnum Orientation, Point2d TextPoint, bool Driven = false);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingSketch](../objects/DrawingSketch.md).DimensionConstraints, [PlanarSketch](../objects/PlanarSketch.md).DimensionConstraints, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).DimensionConstraints, [Sketch](../objects/Sketch.md).DimensionConstraints, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).DimensionConstraints, [SketchBlockDefinitionProxy](../objects/SketchBlockDefinitionProxy.md).DimensionConstraints

**Referenced types:** [ArcLengthDimConstraint](../objects/ArcLengthDimConstraint.md), [DiameterDimConstraint](../objects/DiameterDimConstraint.md), [DimensionConstraint](../objects/DimensionConstraint.md), [DimensionOrientationEnum](../enums/DimensionOrientationEnum.md), [EllipseRadiusDimConstraint](../objects/EllipseRadiusDimConstraint.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [OffsetDimConstraint](../objects/OffsetDimConstraint.md), [OffsetSplineDimConstraint](../objects/OffsetSplineDimConstraint.md), [Point2d](../objects/Point2d.md), [RadiusDimConstraint](../objects/RadiusDimConstraint.md), [SketchEntity](../objects/SketchEntity.md), [SketchLine](../objects/SketchLine.md), [SketchOffsetSpline](../objects/SketchOffsetSpline.md), [SketchPoint](../objects/SketchPoint.md), [TangentDistanceDimConstraint](../objects/TangentDistanceDimConstraint.md), [ThreePointAngleDimConstraint](../objects/ThreePointAngleDimConstraint.md), [TwoLineAngleDimConstraint](../objects/TwoLineAngleDimConstraint.md), [TwoPointDistanceDimConstraint](../objects/TwoPointDistanceDimConstraint.md)

