# WorkPlaneProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [WorkPlane](../objects/WorkPlane.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.WorkPlanes.Item[…] → (WorkPlaneProxy)`

```csharp
interface WorkPlaneProxy
{
    // Properties
    bool Adaptive { get; set; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool AutoResize { get; set; }
    bool Construction { get; }
    bool ConsumeInputs { get; set; }
    bool Consumed { get; }
    ComponentOccurrence ContainingOccurrence { get; }
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
    WorkPlane NativeObject { get; }
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

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [Face](../objects/Face.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeature](../objects/PartFeature.md), [Plane](../objects/Plane.md), [Point](../objects/Point.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch3D](../objects/Sketch3D.md), [UnitVector](../objects/UnitVector.md), [WorkPlane](../objects/WorkPlane.md), [WorkPlaneDefinitionEnum](../enums/WorkPlaneDefinitionEnum.md)

