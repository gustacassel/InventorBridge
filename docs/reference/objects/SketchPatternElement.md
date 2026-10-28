# SketchPatternElement

Inventor API object · versions: 2025, 2026, 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].CircularPatterns.Item[…].Elements.Item[…]`

```csharp
interface SketchPatternElement
{
    // Properties
    object Application { get; } // since 2025
    int Index { get; } // since 2025
    object Parent { get; } // since 2025
    bool Suppressed { get; set; } // since 2025
    ObjectTypeEnum Type { get; } // since 2025
}
```

**Returned by:** [SketchPatternElements](../objects/SketchPatternElements.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

