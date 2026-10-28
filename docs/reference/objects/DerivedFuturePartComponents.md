# DerivedFuturePartComponents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.DerivedFuturePartComponents`

```csharp
interface DerivedFuturePartComponents
{
    // Properties
    object Application { get; }
    int Count { get; }
    DerivedFuturePartComponent Item[int Value] { get; }
    ComponentDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    DerivedFuturePartComponent Add(DerivedFuturePartDefinition Definition);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ReferenceComponents](../objects/ReferenceComponents.md).DerivedFuturePartComponents

**Referenced types:** [ComponentDefinition](../objects/ComponentDefinition.md), [DerivedFuturePartComponent](../objects/DerivedFuturePartComponent.md), [DerivedFuturePartDefinition](../objects/DerivedFuturePartDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

