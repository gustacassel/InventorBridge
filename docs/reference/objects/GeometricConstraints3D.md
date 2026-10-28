# GeometricConstraints3D

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].GeometricConstraints3D`

```csharp
interface GeometricConstraints3D
{
    // Properties
    object Application { get; }
    int Count { get; }
    GeometricConstraint3D Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    CoincidentConstraint3D AddCoincident(SketchEntity3D EntityOne, SketchEntity3D EntityTwo);
    CollinearConstraint3D AddCollinear(object EntityOne, object EntityTwo, bool Reserved1 = true, bool Reserved2 = true);
    CustomConstraint3D AddCustom(SketchEntity3D Entity, string ClientId);
    EqualConstraint3D AddEqual(SketchEntity3D EntityOne, SketchEntity3D EntityTwo);
    GroundConstraint3D AddGround(SketchEntity3D Entity);
    MidpointConstraint3D AddMidpoint(SketchPoint3D Point, SketchLine3D Line);
    OnFaceConstraint3D AddOnFace(SketchEntity3D Entity, object Face);
    ParallelConstraint3D AddParallel(object EntityOne, object EntityTwo, bool Reserved1 = true, bool Reserved2 = true);
    ParallelToXAxisConstraint3D AddParallelToXAxis(SketchLine3D Line);
    ParallelToXYPlaneConstraint3D AddParallelToXYPlane(SketchEntity3D Entity);
    ParallelToXZPlaneConstraint3D AddParallelToXZPlane(SketchEntity3D Entity);
    ParallelToYAxisConstraint3D AddParallelToYAxis(SketchLine3D Line);
    ParallelToYZPlaneConstraint3D AddParallelToYZPlane(SketchEntity3D Entity);
    ParallelToZAxisConstraint3D AddParallelToZAxis(SketchLine3D Line);
    PerpendicularConstraint3D AddPerpendicular(object EntityOne, object EntityTwo, bool Reserved1 = true, bool Reserved2 = true);
    SmoothConstraint3D AddSmooth(SketchEntity3D EntityOne, SketchEntity3D EntityTwo, object ProximityPoint = Missing);
    TangentConstraint3D AddTangent(SketchEntity3D EntityOne, object EntityTwo, object ProximityPoint = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sketch3D](../objects/Sketch3D.md).GeometricConstraints3D, [Sketch3DProxy](../objects/Sketch3DProxy.md).GeometricConstraints3D

**Referenced types:** [CoincidentConstraint3D](../objects/CoincidentConstraint3D.md), [CollinearConstraint3D](../objects/CollinearConstraint3D.md), [CustomConstraint3D](../objects/CustomConstraint3D.md), [EqualConstraint3D](../objects/EqualConstraint3D.md), [GeometricConstraint3D](../objects/GeometricConstraint3D.md), [GroundConstraint3D](../objects/GroundConstraint3D.md), [MidpointConstraint3D](../objects/MidpointConstraint3D.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [OnFaceConstraint3D](../objects/OnFaceConstraint3D.md), [ParallelConstraint3D](../objects/ParallelConstraint3D.md), [ParallelToXAxisConstraint3D](../objects/ParallelToXAxisConstraint3D.md), [ParallelToXYPlaneConstraint3D](../objects/ParallelToXYPlaneConstraint3D.md), [ParallelToXZPlaneConstraint3D](../objects/ParallelToXZPlaneConstraint3D.md), [ParallelToYAxisConstraint3D](../objects/ParallelToYAxisConstraint3D.md), [ParallelToYZPlaneConstraint3D](../objects/ParallelToYZPlaneConstraint3D.md), [ParallelToZAxisConstraint3D](../objects/ParallelToZAxisConstraint3D.md), [PerpendicularConstraint3D](../objects/PerpendicularConstraint3D.md), [SketchEntity3D](../objects/SketchEntity3D.md), [SketchLine3D](../objects/SketchLine3D.md), [SketchPoint3D](../objects/SketchPoint3D.md), [SmoothConstraint3D](../objects/SmoothConstraint3D.md), [TangentConstraint3D](../objects/TangentConstraint3D.md)

