# SketchRectangularPattern

Inventor API object · versions: 2025, 2026, 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].RectangularPatterns.Item[…]`

```csharp
interface SketchRectangularPattern
{
    // Properties
    object Application { get; } // since 2025
    AttributeSets AttributeSets { get; } // since 2025
    ConstraintStatusEnum ConstraintStatus { get; } // since 2025
    SketchConstraintsEnumerator Constraints { get; } // since 2025
    SketchRectangularPatternDefinition Definition { get; set; } // since 2025
    SketchPatternElements Elements { get; } // since 2025
    Sketch Parent { get; } // since 2025
    Box2d RangeBox { get; } // since 2025
    ObjectTypeEnum Type { get; } // since 2025
    // Methods
    void Delete(); // since 2025
}
```

**Returned by:** [SketchRectangularPatterns](../objects/SketchRectangularPatterns.md).Add, [SketchRectangularPatterns](../objects/SketchRectangularPatterns.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box2d](../objects/Box2d.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch](../objects/Sketch.md), [SketchConstraintsEnumerator](../objects/SketchConstraintsEnumerator.md), [SketchPatternElements](../objects/SketchPatternElements.md), [SketchRectangularPatternDefinition](../objects/SketchRectangularPatternDefinition.md)

