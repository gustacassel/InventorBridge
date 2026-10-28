# DerivedFutureAssemblyOccurrence

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.DerivedFutureAssemblyComponents.Item[…].Definition.Occurrences.Item[…]`

```csharp
interface DerivedFutureAssemblyOccurrence
{
    // Properties
    object Application { get; }
    DerivedComponentOptionEnum InclusionOption { get; set; }
    bool IsAssembly { get; }
    string Name { get; }
    DerivedFutureAssemblyOccurrences SubOccurrences { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [DerivedFutureAssemblyOccurrences](../objects/DerivedFutureAssemblyOccurrences.md).Item

**Referenced types:** [DerivedComponentOptionEnum](../enums/DerivedComponentOptionEnum.md), [DerivedFutureAssemblyOccurrences](../objects/DerivedFutureAssemblyOccurrences.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

