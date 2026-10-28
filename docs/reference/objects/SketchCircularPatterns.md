# SketchCircularPatterns

Inventor API object · versions: 2025, 2026, 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].CircularPatterns`

```csharp
interface SketchCircularPatterns
{
    // Properties
    object Application { get; } // since 2025
    int Count { get; } // since 2025
    SketchCircularPattern Item[int Index] { get; } // since 2025
    ObjectTypeEnum Type { get; } // since 2025
    // Methods
    SketchCircularPattern Add(SketchCircularPatternDefinition Definition); // since 2025
    SketchCircularPatternDefinition CreateDefinition(ObjectCollection Geometries, object AxisEntity, object NaturalAxisDirection = Missing, object Count = Missing, object Angle = Missing, object Symmetric = Missing, object Associative = Missing, object Fitted = Missing, object SuppressedElements = Missing, object Reserved = Missing); // since 2025
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingSketch](../objects/DrawingSketch.md).CircularPatterns, [PlanarSketch](../objects/PlanarSketch.md).CircularPatterns, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).CircularPatterns, [Sketch](../objects/Sketch.md).CircularPatterns, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).CircularPatterns, [SketchBlockDefinitionProxy](../objects/SketchBlockDefinitionProxy.md).CircularPatterns

**Referenced types:** [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchCircularPattern](../objects/SketchCircularPattern.md), [SketchCircularPatternDefinition](../objects/SketchCircularPatternDefinition.md)

