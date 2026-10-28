# SketchBlockDefinitions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SketchBlockDefinitions`

```csharp
interface SketchBlockDefinitions
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchBlockDefinition Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchBlockDefinition Add(string Name = "", object InsertionPoint = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FlatPattern](../objects/FlatPattern.md).SketchBlockDefinitions, [PartComponentDefinition](../objects/PartComponentDefinition.md).SketchBlockDefinitions, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).SketchBlockDefinitions

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchBlockDefinition](../objects/SketchBlockDefinition.md)

