# ASideDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition → (SheetMetalComponentDefinition).ASideDefinitions.Item[…]`

```csharp
interface ASideDefinition
{
    // Properties
    Face ASideFace { get; }
    object Application { get; }
    Faces Faces { get; }
    SheetMetalComponentDefinition Parent { get; }
    ASideFaceStatusEnum Status { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
}
```

**Returned by:** [ASideDefinitions](../objects/ASideDefinitions.md).Add, [ASideDefinitions](../objects/ASideDefinitions.md).Item, [FlatPattern](../objects/FlatPattern.md).ASideFace

**Referenced types:** [ASideFaceStatusEnum](../enums/ASideFaceStatusEnum.md), [Face](../objects/Face.md), [Faces](../objects/Faces.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md)

