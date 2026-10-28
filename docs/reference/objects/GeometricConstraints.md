# GeometricConstraints

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].GeometricConstraints`

```csharp
interface GeometricConstraints
{
    // Properties
    object Application { get; }
    int Count { get; }
    GeometricConstraint Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    CoincidentConstraint AddCoincident(SketchEntity EntityOne, SketchEntity EntityTwo);
    CollinearConstraint AddCollinear(SketchEntity EntityOne, SketchEntity EntityTwo, bool UseEllipseOneMajorAxis = true, bool UseEllipseTwoMajorAxis = true);
    ConcentricConstraint AddConcentric(SketchEntity EntityOne, SketchEntity EntityTwo);
    EqualLengthConstraint AddEqualLength(SketchLine LineOne, SketchLine LineTwo);
    EqualRadiusConstraint AddEqualRadius(SketchEntity EntityOne, SketchEntity EntityTwo);
    GroundConstraint AddGround(SketchEntity Entity);
    HorizontalConstraint AddHorizontal(SketchEntity Entity, bool UseEllipseMajorAxis = true);
    HorizontalAlignConstraint AddHorizontalAlign(SketchPoint PointOne, SketchPoint PointTwo);
    MidpointConstraint AddMidPointToArc(SketchPoint Point, SketchArc Arc);
    MidpointConstraint AddMidpoint(SketchPoint Point, SketchLine Line);
    ParallelConstraint AddParallel(SketchEntity EntityOne, SketchEntity EntityTwo, bool UseEllipseOneMajorAxis = true, bool UseEllipseTwoMajorAxis = true);
    PerpendicularConstraint AddPerpendicular(SketchEntity EntityOne, SketchEntity EntityTwo, bool UseEllipseOneMajorAxis = true, bool UseEllipseTwoMajorAxis = true);
    SmoothConstraint AddSmooth(SketchEntity EntityOne, SketchEntity EntityTwo, object ProximityPoint = Missing);
    SymmetryConstraint AddSymmetry(SketchEntity EntityOne, SketchEntity EntityTwo, SketchLine SymmetryAxis);
    TangentSketchConstraint AddTangent(SketchEntity EntityOne, SketchEntity EntityTwo, object ProximityPoint = Missing);
    VerticalConstraint AddVertical(SketchEntity Entity, bool UseEllipseMajorAxis = true);
    VerticalAlignConstraint AddVerticalAlign(SketchPoint PointOne, SketchPoint PointTwo);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingSketch](../objects/DrawingSketch.md).GeometricConstraints, [PlanarSketch](../objects/PlanarSketch.md).GeometricConstraints, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).GeometricConstraints, [Sketch](../objects/Sketch.md).GeometricConstraints, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).GeometricConstraints, [SketchBlockDefinitionProxy](../objects/SketchBlockDefinitionProxy.md).GeometricConstraints

**Referenced types:** [CoincidentConstraint](../objects/CoincidentConstraint.md), [CollinearConstraint](../objects/CollinearConstraint.md), [ConcentricConstraint](../objects/ConcentricConstraint.md), [EqualLengthConstraint](../objects/EqualLengthConstraint.md), [EqualRadiusConstraint](../objects/EqualRadiusConstraint.md), [GeometricConstraint](../objects/GeometricConstraint.md), [GroundConstraint](../objects/GroundConstraint.md), [HorizontalAlignConstraint](../objects/HorizontalAlignConstraint.md), [HorizontalConstraint](../objects/HorizontalConstraint.md), [MidpointConstraint](../objects/MidpointConstraint.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ParallelConstraint](../objects/ParallelConstraint.md), [PerpendicularConstraint](../objects/PerpendicularConstraint.md), [SketchArc](../objects/SketchArc.md), [SketchEntity](../objects/SketchEntity.md), [SketchLine](../objects/SketchLine.md), [SketchPoint](../objects/SketchPoint.md), [SmoothConstraint](../objects/SmoothConstraint.md), [SymmetryConstraint](../objects/SymmetryConstraint.md), [TangentSketchConstraint](../objects/TangentSketchConstraint.md), [VerticalAlignConstraint](../objects/VerticalAlignConstraint.md), [VerticalConstraint](../objects/VerticalConstraint.md)

