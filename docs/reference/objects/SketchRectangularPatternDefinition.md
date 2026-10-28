# SketchRectangularPatternDefinition

Inventor API object · versions: 2025, 2026, 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].RectangularPatterns.Item[…].Definition`

```csharp
interface SketchRectangularPatternDefinition
{
    // Properties
    object Application { get; } // since 2025
    bool Associative { get; set; } // since 2025
    PatternBoundarySetting BoundarySetting { get; set; } // since 2025
    bool Fitted { get; set; } // since 2025
    ObjectCollection Geometries { get; set; } // since 2025
    bool HasBoundarySettingConfigured { get; set; } // since 2025
    bool NaturalXDirection { get; set; } // since 2025
    bool NaturalYDirection { get; set; } // since 2025
    int[] SuppressedElements { get; set; } // since 2025
    ObjectTypeEnum Type { get; } // since 2025
    object XCount { get; set; } // since 2025
    object XDirectionEntity { get; set; } // since 2025
    bool XDirectionSymmetric { get; set; } // since 2025
    object XSpacing { get; set; } // since 2025
    object YCount { get; set; } // since 2025
    object YDirectionEntity { get; set; } // since 2025
    bool YDirectionSymmetric { get; set; } // since 2025
    object YSpacing { get; set; } // since 2025
    // Methods
    SketchRectangularPatternDefinition Copy(); // since 2025
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SketchRectangularPattern](../objects/SketchRectangularPattern.md).Definition, [SketchRectangularPatternDefinition](../objects/SketchRectangularPatternDefinition.md).Copy, [SketchRectangularPatterns](../objects/SketchRectangularPatterns.md).CreateDefinition

**Referenced types:** [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PatternBoundarySetting](../objects/PatternBoundarySetting.md)

