# WorkAxes

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.WorkAxes`

```csharp
interface WorkAxes
{
    // Properties
    object Application { get; }
    int Count { get; }
    WorkAxis Item[object Index] { get; }
    ComponentDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    WorkAxis AddByAnalyticEdge(Edge Edge, bool Construction = false);
    WorkAxis AddByLine(object Line, bool Construction = false);
    WorkAxis AddByLineAndPlane(object Line, object Plane, bool Construction = false);
    WorkAxis AddByLineAndPoint(object Line, object Point, bool Construction = false);
    WorkAxis AddByNormalToSurface(object Surface, object Point, bool Construction = false);
    WorkAxis AddByRevolvedFace(Face Face, bool Construction = false);
    WorkAxis AddByTwoPlanes(object Plane1, object Plane2, bool Construction = false);
    WorkAxis AddByTwoPoints(object Point1, object Point2, bool Construction = false);
    WorkAxis AddFixed(Point Point, UnitVector Axis, bool Construction = false);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).WorkAxes, [FlatPattern](../objects/FlatPattern.md).WorkAxes, [PartComponentDefinition](../objects/PartComponentDefinition.md).WorkAxes, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).WorkAxes, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).WorkAxes

**Referenced types:** [ComponentDefinition](../objects/ComponentDefinition.md), [Edge](../objects/Edge.md), [Face](../objects/Face.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [UnitVector](../objects/UnitVector.md), [WorkAxis](../objects/WorkAxis.md)

