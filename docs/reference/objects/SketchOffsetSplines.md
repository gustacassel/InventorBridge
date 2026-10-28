# SketchOffsetSplines

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].SketchOffsetSplines`

```csharp
interface SketchOffsetSplines
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchOffsetSpline Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingSketch](../objects/DrawingSketch.md).SketchOffsetSplines, [PlanarSketch](../objects/PlanarSketch.md).SketchOffsetSplines, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).SketchOffsetSplines, [Sketch](../objects/Sketch.md).SketchOffsetSplines, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).SketchOffsetSplines, [SketchBlockDefinitionProxy](../objects/SketchBlockDefinitionProxy.md).SketchOffsetSplines

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchOffsetSpline](../objects/SketchOffsetSpline.md)

