# WorkPlane

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.WorkPlanes.Item[…]`

```csharp
interface WorkPlane
{
    // Properties
    bool Adaptive { get; set; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool AutoResize { get; set; }
    bool Construction { get; }
    bool ConsumeInputs { get; set; }
    bool Consumed { get; }
    object Definition { get; }
    WorkPlaneDefinitionEnum DefinitionType { get; }
    ObjectCollection Dependents { get; }
    ObjectCollection DrivenBy { get; }
    bool Exported { get; set; }
    bool Grounded { get; set; }
    bool HasReferenceComponent { get; }
    HealthStatusEnum HealthStatus { get; }
    bool IsCoordinateSystemElement { get; }
    bool IsOwnedByFeature { get; }
    bool IsParentSketch { get; }
    bool IsPatternElement { get; }
    string Name { get; set; }
    PartFeature OwnedBy { get; }
    ComponentDefinition Parent { get; }
    Sketch3D ParentSketch { get; }
    Plane Plane { get; }
    ReferenceComponent ReferenceComponent { get; }
    WorkPlane ReferencedEntity { get; }
    bool Shared { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void Delete(bool RetainDependents = false);
    void FlipNormal();
    void GetPosition(out Point Origin, out UnitVector XAxis, out UnitVector YAxis);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void GetSize(out Point Point1, out Point Point2);
    void SetByLineAndTangent(object Line, Face Face, Point ProximityPoint);
    void SetByLinePlaneAndAngle(object Line, object Plane, object Angle);
    void SetByNormalToCurve(object CurveEntity, object Point);
    void SetByPlaneAndOffset(object Plane, object Offset);
    void SetByPlaneAndPoint(object Plane, object Point);
    void SetByPlaneAndTangent(object Plane, Face Face, Point ProximityPoint);
    void SetByPointAndTangent(object Point, Face Face);
    void SetByThreePoints(object Point1, object Point2, object Point3);
    void SetByTorusMidPlane(Face Face);
    void SetByTwoLines(object Line1, object Line2);
    void SetByTwoPlanes(object Plane1, object Plane2, object QuadrantPoint = Missing);
    void SetEndOfPart(bool Before);
    void SetFixed(Point OriginPoint, UnitVector XAxis, UnitVector YAxis);
    void SetSize(Point Point1, Point Point2);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyWorkPlaneDef](../objects/AssemblyWorkPlaneDef.md).Parent, [FixedWorkPlaneDef](../objects/FixedWorkPlaneDef.md).Parent, [LineAndTangentWorkPlaneDef](../objects/LineAndTangentWorkPlaneDef.md).Parent, [LinePlaneAndAngleWorkPlaneDef](../objects/LinePlaneAndAngleWorkPlaneDef.md).Parent, [NormalToCurveWorkPlaneDef](../objects/NormalToCurveWorkPlaneDef.md).Parent, [PlaneAndOffsetWorkPlaneDef](../objects/PlaneAndOffsetWorkPlaneDef.md).Parent, [PlaneAndPointWorkPlaneDef](../objects/PlaneAndPointWorkPlaneDef.md).Parent, [PlaneAndTangentWorkPlaneDef](../objects/PlaneAndTangentWorkPlaneDef.md).Parent, [PointAndTangentWorkPlaneDef](../objects/PointAndTangentWorkPlaneDef.md).Parent, [ThreePointsWorkPlaneDef](../objects/ThreePointsWorkPlaneDef.md).Parent, [TorusMidPlaneWorkPlaneDef](../objects/TorusMidPlaneWorkPlaneDef.md).Parent, [TwoLinesWorkPlaneDef](../objects/TwoLinesWorkPlaneDef.md).Parent, [TwoPlanesWorkPlaneDef](../objects/TwoPlanesWorkPlaneDef.md).Parent, [UserCoordinateSystem](../objects/UserCoordinateSystem.md).XYPlane, [UserCoordinateSystem](../objects/UserCoordinateSystem.md).XZPlane, [UserCoordinateSystem](../objects/UserCoordinateSystem.md).YZPlane, [UserCoordinateSystemProxy](../objects/UserCoordinateSystemProxy.md).XYPlane, [UserCoordinateSystemProxy](../objects/UserCoordinateSystemProxy.md).XZPlane, [UserCoordinateSystemProxy](../objects/UserCoordinateSystemProxy.md).YZPlane, [WorkPlane](../objects/WorkPlane.md).ReferencedEntity, [WorkPlaneProxy](../objects/WorkPlaneProxy.md).NativeObject, [WorkPlaneProxy](../objects/WorkPlaneProxy.md).ReferencedEntity, [WorkPlanes](../objects/WorkPlanes.md).AddByLineAndTangent, [WorkPlanes](../objects/WorkPlanes.md).AddByLinePlaneAndAngle, [WorkPlanes](../objects/WorkPlanes.md).AddByNormalToCurve, [WorkPlanes](../objects/WorkPlanes.md).AddByPlaneAndOffset, [WorkPlanes](../objects/WorkPlanes.md).AddByPlaneAndPoint, [WorkPlanes](../objects/WorkPlanes.md).AddByPlaneAndTangent, [WorkPlanes](../objects/WorkPlanes.md).AddByPointAndTangent, [WorkPlanes](../objects/WorkPlanes.md).AddByThreePoints, [WorkPlanes](../objects/WorkPlanes.md).AddByTorusMidPlane, [WorkPlanes](../objects/WorkPlanes.md).AddByTwoLines, [WorkPlanes](../objects/WorkPlanes.md).AddByTwoPlanes, [WorkPlanes](../objects/WorkPlanes.md).AddFixed, [WorkPlanes](../objects/WorkPlanes.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentDefinition](../objects/ComponentDefinition.md), [Face](../objects/Face.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeature](../objects/PartFeature.md), [Plane](../objects/Plane.md), [Point](../objects/Point.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch3D](../objects/Sketch3D.md), [UnitVector](../objects/UnitVector.md), [WorkPlaneDefinitionEnum](../enums/WorkPlaneDefinitionEnum.md)

