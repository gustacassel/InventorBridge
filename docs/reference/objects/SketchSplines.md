# SketchSplines

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].SketchSplines`

```csharp
interface SketchSplines
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchSpline Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchSpline Add(ObjectCollection FitPoints, SplineFitMethodEnum FitMethod = SplineFitMethodEnum.kSweetSplineFit);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingSketch](../objects/DrawingSketch.md).SketchSplines, [PlanarSketch](../objects/PlanarSketch.md).SketchSplines, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).SketchSplines, [Sketch](../objects/Sketch.md).SketchSplines, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).SketchSplines, [SketchBlockDefinitionProxy](../objects/SketchBlockDefinitionProxy.md).SketchSplines

**Referenced types:** [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchSpline](../objects/SketchSpline.md), [SplineFitMethodEnum](../enums/SplineFitMethodEnum.md)

