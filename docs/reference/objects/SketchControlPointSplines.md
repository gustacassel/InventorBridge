# SketchControlPointSplines

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].SketchControlPointSplines`

```csharp
interface SketchControlPointSplines
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchControlPointSpline Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchControlPointSpline Add(ObjectCollection ControlPoints);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingSketch](../objects/DrawingSketch.md).SketchControlPointSplines, [PlanarSketch](../objects/PlanarSketch.md).SketchControlPointSplines, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).SketchControlPointSplines, [Sketch](../objects/Sketch.md).SketchControlPointSplines, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).SketchControlPointSplines, [SketchBlockDefinitionProxy](../objects/SketchBlockDefinitionProxy.md).SketchControlPointSplines

**Referenced types:** [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchControlPointSpline](../objects/SketchControlPointSpline.md)

