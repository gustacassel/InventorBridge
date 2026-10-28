# SketchEllipticalArcs

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].SketchEllipticalArcs`

```csharp
interface SketchEllipticalArcs
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchEllipticalArc Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchEllipticalArc Add(object CenterPoint, UnitVector2d MajorAxisVector, double MajorRadius, double MinorRadius, double StartAngle, double SweepAngle);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingSketch](../objects/DrawingSketch.md).SketchEllipticalArcs, [PlanarSketch](../objects/PlanarSketch.md).SketchEllipticalArcs, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).SketchEllipticalArcs, [Sketch](../objects/Sketch.md).SketchEllipticalArcs, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).SketchEllipticalArcs, [SketchBlockDefinitionProxy](../objects/SketchBlockDefinitionProxy.md).SketchEllipticalArcs

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchEllipticalArc](../objects/SketchEllipticalArc.md), [UnitVector2d](../objects/UnitVector2d.md)

