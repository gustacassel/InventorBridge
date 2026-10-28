# SketchRectangularPatterns

Inventor API object · versions: 2025, 2026, 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].RectangularPatterns`

```csharp
interface SketchRectangularPatterns
{
    // Properties
    object Application { get; } // since 2025
    int Count { get; } // since 2025
    SketchRectangularPattern Item[int Index] { get; } // since 2025
    ObjectTypeEnum Type { get; } // since 2025
    // Methods
    SketchRectangularPattern Add(SketchRectangularPatternDefinition Definition); // since 2025
    SketchRectangularPatternDefinition CreateDefinition(ObjectCollection Geometries, object XDirectionEntity, object XCount, object NaturalXDirection = Missing, object XDirectionSymmetric = Missing, object XSpacing = Missing, object YDirectionEntity = Missing, object YCount = Missing, object NaturalYDirection = Missing, object YDirectionSymmetric = Missing, object YSpacing = Missing, object Associative = Missing, object Fitted = Missing, object SuppressedElements = Missing, object Reserved = Missing); // since 2025
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingSketch](../objects/DrawingSketch.md).RectangularPatterns, [PlanarSketch](../objects/PlanarSketch.md).RectangularPatterns, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).RectangularPatterns, [Sketch](../objects/Sketch.md).RectangularPatterns, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).RectangularPatterns, [SketchBlockDefinitionProxy](../objects/SketchBlockDefinitionProxy.md).RectangularPatterns

**Referenced types:** [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchRectangularPattern](../objects/SketchRectangularPattern.md), [SketchRectangularPatternDefinition](../objects/SketchRectangularPatternDefinition.md)

