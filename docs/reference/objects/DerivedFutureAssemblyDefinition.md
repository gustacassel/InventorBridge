# DerivedFutureAssemblyDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.DerivedFutureAssemblyComponents.Item[…].Definition`

```csharp
interface DerivedFutureAssemblyDefinition
{
    // Properties
    string ActiveDesignViewRepresentation { get; set; }
    string ActivePositionalRepresentation { get; set; }
    object Application { get; }
    string FullFileName { get; }
    bool IsAssociativeDesignView { get; set; }
    DerivedFutureAssemblyOccurrences Occurrences { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [DerivedFutureAssemblyComponent](../objects/DerivedFutureAssemblyComponent.md).Definition, [DerivedFutureAssemblyComponentProxy](../objects/DerivedFutureAssemblyComponentProxy.md).Definition

**Referenced types:** [DerivedFutureAssemblyOccurrences](../objects/DerivedFutureAssemblyOccurrences.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

