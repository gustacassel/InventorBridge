# SketchImages

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].SketchImages`

```csharp
interface SketchImages
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchImage Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchImage Add(string FullFileName, Point2d Position, bool Link = true);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingSketch](../objects/DrawingSketch.md).SketchImages, [PlanarSketch](../objects/PlanarSketch.md).SketchImages, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).SketchImages, [Sketch](../objects/Sketch.md).SketchImages, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).SketchImages, [SketchBlockDefinitionProxy](../objects/SketchBlockDefinitionProxy.md).SketchImages

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [SketchImage](../objects/SketchImage.md)

