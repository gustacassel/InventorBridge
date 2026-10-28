# OrientedBox

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateOrientedBox(…)`

```csharp
interface OrientedBox
{
    // Properties
    Point CornerPoint { get; set; }
    Vector DirectionOne { get; set; }
    Vector DirectionThree { get; set; }
    Vector DirectionTwo { get; set; }
    // Methods
    bool Contains(Point Point);
    OrientedBox Copy();
    void GetOrientedBoxData(out Point CornerPoint, out Vector DirectionOne, out Vector DirectionTwo, out Vector DirectionThree);
    bool IsDisjoint(OrientedBox OrientedBox);
    void PutOrientedBoxData(Point CornerPoint, Vector DirectionOne, Vector DirectionTwo, Vector DirectionThree);
}
```

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).OrientedMinimumRangeBox, [ComponentDefinition](../objects/ComponentDefinition.md).OrientedMinimumRangeBox, [ComponentOccurrence](../objects/ComponentOccurrence.md).OrientedMinimumRangeBox, [ComponentOccurrenceProxy](../objects/ComponentOccurrenceProxy.md).OrientedMinimumRangeBox, [FlatPattern](../objects/FlatPattern.md).OrientedMinimumRangeBox, [OrientedBox](../objects/OrientedBox.md).Copy, [PartComponentDefinition](../objects/PartComponentDefinition.md).OrientedMinimumRangeBox, [PointCloudCrop](../objects/PointCloudCrop.md).BoundingBox, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).OrientedMinimumRangeBox, [SurfaceBody](../objects/SurfaceBody.md).OrientedMinimumRangeBox, [SurfaceBodyProxy](../objects/SurfaceBodyProxy.md).OrientedMinimumRangeBox, [TransientGeometry](../objects/TransientGeometry.md).CreateOrientedBox, [VirtualComponentDefinition](../objects/VirtualComponentDefinition.md).OrientedMinimumRangeBox, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).OrientedMinimumRangeBox, [WeldsComponentDefinition](../objects/WeldsComponentDefinition.md).OrientedMinimumRangeBox

**Referenced types:** [Point](../objects/Point.md), [Vector](../objects/Vector.md)

