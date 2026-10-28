# ASideDefinitions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition → (SheetMetalComponentDefinition).ASideDefinitions`

```csharp
interface ASideDefinitions
{
    // Properties
    object Application { get; }
    int Count { get; }
    ASideDefinition Item[object Index] { get; }
    SheetMetalComponentDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ASideDefinition Add(Face pInput);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).ASideDefinitions

**Referenced types:** [ASideDefinition](../objects/ASideDefinition.md), [Face](../objects/Face.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md)

