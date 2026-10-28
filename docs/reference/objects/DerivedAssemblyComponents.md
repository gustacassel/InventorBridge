# DerivedAssemblyComponents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.DerivedAssemblyComponents`

```csharp
interface DerivedAssemblyComponents
{
    // Properties
    object Application { get; }
    int Count { get; }
    DerivedAssemblyComponent Item[int Index] { get; }
    ComponentDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    DerivedAssemblyComponent Add(DerivedAssemblyDefinition Definition);
    DerivedAssemblyDefinition CreateDefinition(string FullDocumentName);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ReferenceComponents](../objects/ReferenceComponents.md).DerivedAssemblyComponents

**Referenced types:** [ComponentDefinition](../objects/ComponentDefinition.md), [DerivedAssemblyComponent](../objects/DerivedAssemblyComponent.md), [DerivedAssemblyDefinition](../objects/DerivedAssemblyDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

