# SketchCircularPatternDefinition

Inventor API object · versions: 2025, 2026, 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].CircularPatterns.Item[…].Definition`

```csharp
interface SketchCircularPatternDefinition
{
    // Properties
    object Angle { get; set; } // since 2025
    object Application { get; } // since 2025
    bool Associative { get; set; } // since 2025
    object AxisEntity { get; set; } // since 2025
    PatternBoundarySetting BoundarySetting { get; set; } // since 2025
    object Count { get; set; } // since 2025
    bool Fitted { get; set; } // since 2025
    ObjectCollection Geometries { get; set; } // since 2025
    bool HasBoundarySettingConfigured { get; set; } // since 2025
    bool NaturalAxisDirection { get; set; } // since 2025
    int[] SuppressedElements { get; set; } // since 2025
    bool Symmetric { get; set; } // since 2025
    ObjectTypeEnum Type { get; } // since 2025
    // Methods
    SketchCircularPatternDefinition Copy(); // since 2025
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SketchCircularPattern](../objects/SketchCircularPattern.md).Definition, [SketchCircularPatternDefinition](../objects/SketchCircularPatternDefinition.md).Copy, [SketchCircularPatterns](../objects/SketchCircularPatterns.md).CreateDefinition

**Referenced types:** [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PatternBoundarySetting](../objects/PatternBoundarySetting.md)

