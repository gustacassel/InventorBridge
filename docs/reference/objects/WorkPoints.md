# WorkPoints

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.WorkPoints`

```csharp
interface WorkPoints
{
    // Properties
    object Application { get; }
    int Count { get; }
    WorkPoint Item[object Index] { get; }
    ComponentDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    WorkPoint AddAtCentroid(object Entities, bool Construction = false);
    WorkPoint AddByCurveAndEntity(object Curve, object Entity, object ProximityPoint = Missing, bool Construction = false);
    WorkPoint AddByMidPoint(Edge Edge, bool Construction = false);
    WorkPoint AddByPoint(object Point, bool Construction = false);
    WorkPoint AddBySphereCenterPoint(Face Face, bool Construction = false);
    WorkPoint AddByThreePlanes(object Plane1, object Plane2, object Plane3, bool Construction = false);
    WorkPoint AddByTorusCenterPoint(Face Face, bool Construction = false);
    WorkPoint AddByTwoLines(object Line1, object Line2, bool Construction = false);
    WorkPoint AddFixed(Point Point, bool Construction = false);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).WorkPoints, [FlatPattern](../objects/FlatPattern.md).WorkPoints, [PartComponentDefinition](../objects/PartComponentDefinition.md).WorkPoints, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).WorkPoints, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).WorkPoints

**Referenced types:** [ComponentDefinition](../objects/ComponentDefinition.md), [Edge](../objects/Edge.md), [Face](../objects/Face.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [WorkPoint](../objects/WorkPoint.md)

