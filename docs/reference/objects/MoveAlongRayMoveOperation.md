# MoveAlongRayMoveOperation

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [MoveOperation](../objects/MoveOperation.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.MoveFeatures.Item[…].Definition.MoveOperation[…] → (MoveAlongRayMoveOperation)`

```csharp
interface MoveAlongRayMoveOperation
{
    // Properties
    object Application { get; }
    object DirectionEntity { get; set; }
    bool EntityNaturalDirection { get; set; }
    object Offset { get; set; }
    MoveDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
}
```

**Returned by:** [MoveDefinition](../objects/MoveDefinition.md).AddMoveAlongRay

**Referenced types:** [MoveDefinition](../objects/MoveDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

