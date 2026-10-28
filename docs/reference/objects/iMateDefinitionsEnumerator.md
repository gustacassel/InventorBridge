# iMateDefinitionsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Occurrences.Item[…].iMateDefinitions`

```csharp
interface iMateDefinitionsEnumerator
{
    // Properties
    int Count { get; }
    iMateDefinition Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ComponentOccurrence](../objects/ComponentOccurrence.md).iMateDefinitions, [ComponentOccurrenceProxy](../objects/ComponentOccurrenceProxy.md).iMateDefinitions, [DerivedPartComponent](../objects/DerivedPartComponent.md).iMateDefinitions, [DerivedPartComponentProxy](../objects/DerivedPartComponentProxy.md).iMateDefinitions

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iMateDefinition](../objects/iMateDefinition.md)

