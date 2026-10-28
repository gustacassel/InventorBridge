# DimensionConstraints3D

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].DimensionConstraints3D`

```csharp
interface DimensionConstraints3D
{
    // Properties
    object Application { get; }
    int Count { get; }
    DimensionConstraint3D Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    LineLengthDimConstraint3D AddLineLength(SketchLine3D Line, object TextPoint = Missing, bool Driven = false);
    PointAndPlaneDistanceDimConstraint3D AddPointAndPlaneDistance(SketchPoint3D Point, object Plane, object TextPoint = Missing, bool Driven = false);
    RadiusDimConstraint3D AddRadius(SketchEntity3D Entity, object TextPoint = Missing, bool Driven = false);
    SplineLengthDimConstraint3D AddSplineLength(SketchEntity3D SketchSpline, object TextPoint = Missing, bool Driven = false);
    TwoLineAngleDimConstraint3D AddTwoLineAngle(SketchLine3D LineOne, SketchLine3D LineTwo, object TextPoint = Missing, bool Driven = false);
    TwoPointDistanceDimConstraint3D AddTwoPointDistance(object PointOne, object PointTwo, object TextPoint = Missing, bool Driven = false);
    Plane GetDimensionPlane(ObjectCollection Entities);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sketch3D](../objects/Sketch3D.md).DimensionConstraints3D, [Sketch3DProxy](../objects/Sketch3DProxy.md).DimensionConstraints3D

**Referenced types:** [DimensionConstraint3D](../objects/DimensionConstraint3D.md), [LineLengthDimConstraint3D](../objects/LineLengthDimConstraint3D.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Plane](../objects/Plane.md), [PointAndPlaneDistanceDimConstraint3D](../objects/PointAndPlaneDistanceDimConstraint3D.md), [RadiusDimConstraint3D](../objects/RadiusDimConstraint3D.md), [SketchEntity3D](../objects/SketchEntity3D.md), [SketchLine3D](../objects/SketchLine3D.md), [SketchPoint3D](../objects/SketchPoint3D.md), [SplineLengthDimConstraint3D](../objects/SplineLengthDimConstraint3D.md), [TwoLineAngleDimConstraint3D](../objects/TwoLineAngleDimConstraint3D.md), [TwoPointDistanceDimConstraint3D](../objects/TwoPointDistanceDimConstraint3D.md)

