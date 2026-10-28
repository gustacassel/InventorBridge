# SketchEllipses

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].SketchEllipses`

```csharp
interface SketchEllipses
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchEllipse Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchEllipse Add(object CenterPoint, UnitVector2d MajorAxisVector, double MajorRadius, double MinorRadius);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingSketch](../objects/DrawingSketch.md).SketchEllipses, [PlanarSketch](../objects/PlanarSketch.md).SketchEllipses, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).SketchEllipses, [Sketch](../objects/Sketch.md).SketchEllipses, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).SketchEllipses, [SketchBlockDefinitionProxy](../objects/SketchBlockDefinitionProxy.md).SketchEllipses

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchEllipse](../objects/SketchEllipse.md), [UnitVector2d](../objects/UnitVector2d.md)

