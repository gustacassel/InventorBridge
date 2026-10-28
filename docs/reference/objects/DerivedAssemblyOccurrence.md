# DerivedAssemblyOccurrence

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.DerivedAssemblyComponents.Item[…].Definition.Occurrences.Item[…]`

```csharp
interface DerivedAssemblyOccurrence
{
    // Properties
    object Application { get; }
    bool FailedBooleanOperation { get; }
    DerivedComponentOptionEnum InclusionOption { get; set; }
    bool IsAssembly { get; }
    string Name { get; }
    ComponentOccurrence ReferencedOccurrence { get; }
    DerivedAssemblyOccurrences SubOccurrences { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [DerivedAssemblyOccurrences](../objects/DerivedAssemblyOccurrences.md).Item

**Referenced types:** [ComponentOccurrence](../objects/ComponentOccurrence.md), [DerivedAssemblyOccurrences](../objects/DerivedAssemblyOccurrences.md), [DerivedComponentOptionEnum](../enums/DerivedComponentOptionEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

