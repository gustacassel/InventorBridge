# OccurrencePatternElement

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Occurrences.Item[…].PatternElement`

```csharp
interface OccurrencePatternElement
{
    // Properties
    object Application { get; }
    ObjectsEnumerator Components { get; }
    bool Independent { get; set; }
    int Index { get; }
    string Name { get; }
    ComponentOccurrencesEnumerator Occurrences { get; }
    object Parent { get; }
    bool Suppressed { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [CircularOccurrencePattern](../objects/CircularOccurrencePattern.md).PatternElement, [CircularOccurrencePatternProxy](../objects/CircularOccurrencePatternProxy.md).PatternElement, [ComponentOccurrence](../objects/ComponentOccurrence.md).PatternElement, [ComponentOccurrenceProxy](../objects/ComponentOccurrenceProxy.md).PatternElement, [FeatureBasedOccurrencePattern](../objects/FeatureBasedOccurrencePattern.md).PatternElement, [FeatureBasedOccurrencePatternProxy](../objects/FeatureBasedOccurrencePatternProxy.md).PatternElement, [OccurrencePattern](../objects/OccurrencePattern.md).PatternElement, [OccurrencePatternElementProxy](../objects/OccurrencePatternElementProxy.md).NativeObject, [OccurrencePatternElements](../objects/OccurrencePatternElements.md).Item, [RectangularOccurrencePattern](../objects/RectangularOccurrencePattern.md).OccurrencePatternElement, [RectangularOccurrencePattern](../objects/RectangularOccurrencePattern.md).PatternElement, [RectangularOccurrencePatternProxy](../objects/RectangularOccurrencePatternProxy.md).OccurrencePatternElement, [RectangularOccurrencePatternProxy](../objects/RectangularOccurrencePatternProxy.md).PatternElement

**Referenced types:** [ComponentOccurrencesEnumerator](../objects/ComponentOccurrencesEnumerator.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md)

