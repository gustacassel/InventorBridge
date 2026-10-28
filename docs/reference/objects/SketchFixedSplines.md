# SketchFixedSplines

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].SketchFixedSplines`

```csharp
interface SketchFixedSplines
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchFixedSpline Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchFixedSpline Add(BSplineCurve2d SplineCurve, object StartPoint = Missing, object EndPoint = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingSketch](../objects/DrawingSketch.md).SketchFixedSplines, [PlanarSketch](../objects/PlanarSketch.md).SketchFixedSplines, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).SketchFixedSplines, [Sketch](../objects/Sketch.md).SketchFixedSplines, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).SketchFixedSplines, [SketchBlockDefinitionProxy](../objects/SketchBlockDefinitionProxy.md).SketchFixedSplines

**Referenced types:** [BSplineCurve2d](../objects/BSplineCurve2d.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchFixedSpline](../objects/SketchFixedSpline.md)

