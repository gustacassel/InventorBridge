# FreeDragMoveOperation

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [MoveOperation](../objects/MoveOperation.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.MoveFeatures.Item[…].Definition.MoveOperation[…] → (FreeDragMoveOperation)`

```csharp
interface FreeDragMoveOperation
{
    // Properties
    object Application { get; }
    MoveDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    object XOffset { get; set; }
    object YOffset { get; set; }
    object ZOffset { get; set; }
    // Methods
    void Delete();
}
```

**Returned by:** [MoveDefinition](../objects/MoveDefinition.md).AddFreeDrag

**Referenced types:** [MoveDefinition](../objects/MoveDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

