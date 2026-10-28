# ShrinkwrapComponents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.ShrinkwrapComponents`

```csharp
interface ShrinkwrapComponents
{
    // Properties
    object Application { get; }
    int Count { get; }
    ShrinkwrapComponent Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ShrinkwrapComponent Add(ShrinkwrapDefinition Definition);
    ShrinkwrapDefinition CreateDefinition(string FullDocumentName);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ReferenceComponents](../objects/ReferenceComponents.md).ShrinkwrapComponents

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ShrinkwrapComponent](../objects/ShrinkwrapComponent.md), [ShrinkwrapDefinition](../objects/ShrinkwrapDefinition.md)

