# OccurrencePatternElementProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface OccurrencePatternElementProxy
{
    // Properties
    object Application { get; }
    ObjectsEnumerator Components { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    bool Independent { get; set; }
    int Index { get; }
    string Name { get; }
    OccurrencePatternElement NativeObject { get; }
    ComponentOccurrencesEnumerator Occurrences { get; }
    object Parent { get; }
    bool Suppressed { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Referenced types:** [ComponentOccurrence](../objects/ComponentOccurrence.md), [ComponentOccurrencesEnumerator](../objects/ComponentOccurrencesEnumerator.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [OccurrencePatternElement](../objects/OccurrencePatternElement.md)

