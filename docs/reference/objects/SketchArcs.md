# SketchArcs

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].SketchArcs`

```csharp
interface SketchArcs
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchArc Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchArc AddByCenterStartEndPoint(object CenterPoint, object StartPoint, object EndPoint, bool CounterClockwise = true);
    SketchArc AddByCenterStartSweepAngle(object CenterPoint, double Radius, double StartAngle, double SweepAngle);
    SketchArc AddByFillet(SketchEntity EntityOne, SketchEntity EntityTwo, object Radius, Point2d PointOnEntityOne, Point2d PointOnEntityTwo);
    SketchArc AddByThreePoints(object StartPoint, Point2d MidPoint, object EndPoint);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingSketch](../objects/DrawingSketch.md).SketchArcs, [PlanarSketch](../objects/PlanarSketch.md).SketchArcs, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).SketchArcs, [Sketch](../objects/Sketch.md).SketchArcs, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).SketchArcs, [SketchBlockDefinitionProxy](../objects/SketchBlockDefinitionProxy.md).SketchArcs

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [SketchArc](../objects/SketchArc.md), [SketchEntity](../objects/SketchEntity.md)

