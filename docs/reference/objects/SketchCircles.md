# SketchCircles

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].SketchCircles`

```csharp
interface SketchCircles
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchCircle Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchCircle AddByCenterRadius(object CenterPoint, double Radius);
    SketchCircle AddByThreePoints(Point2d PointOne, Point2d PointTwo, Point2d PointThree);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingSketch](../objects/DrawingSketch.md).SketchCircles, [PlanarSketch](../objects/PlanarSketch.md).SketchCircles, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).SketchCircles, [Sketch](../objects/Sketch.md).SketchCircles, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).SketchCircles, [SketchBlockDefinitionProxy](../objects/SketchBlockDefinitionProxy.md).SketchCircles

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [SketchCircle](../objects/SketchCircle.md)

