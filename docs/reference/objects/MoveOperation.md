# MoveOperation

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.MoveFeatures.Item[…].Definition.MoveOperation[…]`

```csharp
interface MoveOperation
{
    // Properties
    object Application { get; }
    MoveDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
}
```

**Returned by:** [MoveDefinition](../objects/MoveDefinition.md).MoveOperation

**Referenced types:** [MoveDefinition](../objects/MoveDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

