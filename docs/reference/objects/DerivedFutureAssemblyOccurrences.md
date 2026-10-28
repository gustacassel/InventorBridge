# DerivedFutureAssemblyOccurrences

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.DerivedFutureAssemblyComponents.Item[…].Definition.Occurrences`

```csharp
interface DerivedFutureAssemblyOccurrences
{
    // Properties
    object Application { get; }
    int Count { get; }
    DerivedFutureAssemblyOccurrence Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DerivedFutureAssemblyDefinition](../objects/DerivedFutureAssemblyDefinition.md).Occurrences, [DerivedFutureAssemblyOccurrence](../objects/DerivedFutureAssemblyOccurrence.md).SubOccurrences

**Referenced types:** [DerivedFutureAssemblyOccurrence](../objects/DerivedFutureAssemblyOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

