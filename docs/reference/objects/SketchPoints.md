# SketchPoints

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].SketchPoints`

```csharp
interface SketchPoints
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchPoint Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchPoint Add(Point2d Point, bool HoleCenter = true);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingSketch](../objects/DrawingSketch.md).SketchPoints, [PlanarSketch](../objects/PlanarSketch.md).SketchPoints, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).SketchPoints, [Sketch](../objects/Sketch.md).SketchPoints, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).SketchPoints, [SketchBlockDefinitionProxy](../objects/SketchBlockDefinitionProxy.md).SketchPoints

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [SketchPoint](../objects/SketchPoint.md)

