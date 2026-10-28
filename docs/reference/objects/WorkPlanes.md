# WorkPlanes

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.WorkPlanes`

```csharp
interface WorkPlanes
{
    // Properties
    object Application { get; }
    int Count { get; }
    WorkPlane Item[object Index] { get; }
    ComponentDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    WorkPlane AddByLineAndTangent(object Line, Face Face, Point ProximityPoint, bool Construction = false);
    WorkPlane AddByLinePlaneAndAngle(object Line, object Plane, object Angle, bool Construction = false);
    WorkPlane AddByNormalToCurve(object CurveEntity, object Point, bool Construction = false);
    WorkPlane AddByPlaneAndOffset(object Plane, object Offset, bool Construction = false);
    WorkPlane AddByPlaneAndPoint(object Plane, object Point, bool Construction = false);
    WorkPlane AddByPlaneAndTangent(object Plane, Face Face, Point ProximityPoint, bool Construction = false);
    WorkPlane AddByPointAndTangent(object Point, Face Face, bool Construction = false);
    WorkPlane AddByThreePoints(object Point1, object Point2, object Point3, bool Construction = false);
    WorkPlane AddByTorusMidPlane(Face Face, bool Construction = false);
    WorkPlane AddByTwoLines(object Line1, object Line2, bool Construction = false);
    WorkPlane AddByTwoPlanes(object Plane1, object Plane2, object QuadrantPoint = Missing, bool Construction = false);
    WorkPlane AddFixed(Point OriginPoint, UnitVector XAxis, UnitVector YAxis, bool Construction = false);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).WorkPlanes, [FlatPattern](../objects/FlatPattern.md).WorkPlanes, [PartComponentDefinition](../objects/PartComponentDefinition.md).WorkPlanes, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).WorkPlanes, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).WorkPlanes

**Referenced types:** [ComponentDefinition](../objects/ComponentDefinition.md), [Face](../objects/Face.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [UnitVector](../objects/UnitVector.md), [WorkPlane](../objects/WorkPlane.md)

