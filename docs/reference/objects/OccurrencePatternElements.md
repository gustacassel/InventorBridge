# OccurrencePatternElements

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.OccurrencePatterns.Item[…].OccurrencePatternElements`

```csharp
interface OccurrencePatternElements
{
    // Properties
    object Application { get; }
    int Count { get; }
    OccurrencePatternElement Item[object Index] { get; }
    OccurrencePattern Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [CircularOccurrencePattern](../objects/CircularOccurrencePattern.md).OccurrencePatternElements, [CircularOccurrencePatternProxy](../objects/CircularOccurrencePatternProxy.md).OccurrencePatternElements, [FeatureBasedOccurrencePattern](../objects/FeatureBasedOccurrencePattern.md).OccurrencePatternElements, [FeatureBasedOccurrencePatternProxy](../objects/FeatureBasedOccurrencePatternProxy.md).OccurrencePatternElements, [OccurrencePattern](../objects/OccurrencePattern.md).OccurrencePatternElements, [RectangularOccurrencePattern](../objects/RectangularOccurrencePattern.md).OccurrencePatternElements, [RectangularOccurrencePatternProxy](../objects/RectangularOccurrencePatternProxy.md).OccurrencePatternElements

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [OccurrencePattern](../objects/OccurrencePattern.md), [OccurrencePatternElement](../objects/OccurrencePatternElement.md)

