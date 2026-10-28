# DerivedAssemblyOccurrences

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.DerivedAssemblyComponents.Item[…].Definition.Occurrences`

```csharp
interface DerivedAssemblyOccurrences
{
    // Properties
    object Application { get; }
    int Count { get; }
    DerivedAssemblyOccurrence Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DerivedAssemblyDefinition](../objects/DerivedAssemblyDefinition.md).Occurrences, [DerivedAssemblyOccurrence](../objects/DerivedAssemblyOccurrence.md).SubOccurrences

**Referenced types:** [DerivedAssemblyOccurrence](../objects/DerivedAssemblyOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

