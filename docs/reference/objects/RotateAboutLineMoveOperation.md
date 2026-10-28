# RotateAboutLineMoveOperation

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [MoveOperation](../objects/MoveOperation.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.MoveFeatures.Item[…].Definition.MoveOperation[…] → (RotateAboutLineMoveOperation)`

```csharp
interface RotateAboutLineMoveOperation
{
    // Properties
    object Angle { get; set; }
    object Application { get; }
    object AxisEntity { get; set; }
    MoveDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    bool UseEntityNaturalDirection { get; set; }
    // Methods
    void Delete();
}
```

**Returned by:** [MoveDefinition](../objects/MoveDefinition.md).AddRotateAboutAxis

**Referenced types:** [MoveDefinition](../objects/MoveDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

