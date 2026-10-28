# SheetMetalStyles

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition → (SheetMetalComponentDefinition).SheetMetalStyles`

```csharp
interface SheetMetalStyles
{
    // Properties
    object Application { get; }
    int Count { get; }
    SheetMetalStyle Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).SheetMetalStyles

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SheetMetalStyle](../objects/SheetMetalStyle.md)

