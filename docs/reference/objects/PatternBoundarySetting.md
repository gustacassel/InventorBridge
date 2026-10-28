# PatternBoundarySetting

Inventor API object · versions: 2025, 2026, 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.CircularPatternFeatures.Item[…].Definition.BoundarySetting`

```csharp
interface PatternBoundarySetting
{
    // Properties
    object Application { get; } // since 2025
    object Boundary { get; set; } // since 2025
    PatternBoundaryInclusionEnum BoundaryInclusionType { get; set; } // since 2025
    object OccurrenceBasePoint { get; set; } // since 2025
    object Offset { get; set; } // since 2025
    bool OffsetFlipped { get; set; } // since 2025
    ObjectTypeEnum Type { get; } // since 2025
    // Methods
    PatternBoundarySetting Copy(); // since 2025
    void GetBoundarySettingData(out object Boundary, out PatternBoundaryInclusionEnum BoundaryInclusionType, out object OccurrenceBasePoint, out double Offset, out bool OffsetFlipped, out object Reserved); // since 2025
    void SetBoundarySettingData(object Boundary, object BoundaryInclusionType = Missing, object OccurrenceBasePoint = Missing, object Offset = Missing, object OffsetFlipped = Missing, object Reserved = Missing); // since 2025
}
```

**Returned by:** [CircularPatternFeatureDefinition](../objects/CircularPatternFeatureDefinition.md).BoundarySetting, [PatternBoundarySetting](../objects/PatternBoundarySetting.md).Copy, [RectangularPatternFeatureDefinition](../objects/RectangularPatternFeatureDefinition.md).BoundarySetting, [SketchCircularPatternDefinition](../objects/SketchCircularPatternDefinition.md).BoundarySetting, [SketchRectangularPatternDefinition](../objects/SketchRectangularPatternDefinition.md).BoundarySetting

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PatternBoundaryInclusionEnum](../enums/PatternBoundaryInclusionEnum.md)

