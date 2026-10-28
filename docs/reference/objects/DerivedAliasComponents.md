# DerivedAliasComponents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.DerivedAliasComponents`

```csharp
interface DerivedAliasComponents
{
    // Properties
    object Application { get; }
    int Count { get; }
    DerivedAliasComponent Item[object Value] { get; }
    ComponentDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ReferenceComponents](../objects/ReferenceComponents.md).DerivedAliasComponents

**Referenced types:** [ComponentDefinition](../objects/ComponentDefinition.md), [DerivedAliasComponent](../objects/DerivedAliasComponent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

