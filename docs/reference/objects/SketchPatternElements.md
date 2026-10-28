# SketchPatternElements

Inventor API object · versions: 2025, 2026, 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].CircularPatterns.Item[…].Elements`

```csharp
interface SketchPatternElements
{
    // Properties
    object Application { get; } // since 2025
    int Count { get; } // since 2025
    SketchPatternElement Item[int Index] { get; } // since 2025
    ObjectTypeEnum Type { get; } // since 2025
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SketchCircularPattern](../objects/SketchCircularPattern.md).Elements, [SketchRectangularPattern](../objects/SketchRectangularPattern.md).Elements

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchPatternElement](../objects/SketchPatternElement.md)

