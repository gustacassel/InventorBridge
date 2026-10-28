# DerivedFutureAssemblyComponents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.DerivedFutureAssemblyComponents`

```csharp
interface DerivedFutureAssemblyComponents
{
    // Properties
    object Application { get; }
    int Count { get; }
    DerivedFutureAssemblyComponent Item[int Value] { get; }
    ComponentDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    DerivedFutureAssemblyComponent Add(DerivedFutureAssemblyDefinition Definition);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ReferenceComponents](../objects/ReferenceComponents.md).DerivedFutureAssemblyComponents

**Referenced types:** [ComponentDefinition](../objects/ComponentDefinition.md), [DerivedFutureAssemblyComponent](../objects/DerivedFutureAssemblyComponent.md), [DerivedFutureAssemblyDefinition](../objects/DerivedFutureAssemblyDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

