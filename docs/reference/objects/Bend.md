# Bend

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition → (SheetMetalComponentDefinition).Bends.Item[…]`

```csharp
interface Bend
{
    // Properties
    object Application { get; }
    Faces BackFaces { get; }
    Faces FrontFaces { get; }
    bool IsFlat { get; }
    SheetMetalComponentDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [BendsEnumerator](../objects/BendsEnumerator.md).Item, [FlatBendResult](../objects/FlatBendResult.md).Bend

**Referenced types:** [Faces](../objects/Faces.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md)

