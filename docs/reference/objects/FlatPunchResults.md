# FlatPunchResults

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition → (SheetMetalComponentDefinition).FlatPattern.FlatPunchResults`

```csharp
interface FlatPunchResults
{
    // Properties
    object Application { get; }
    int Count { get; }
    FlatPunchResult Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FlatPattern](../objects/FlatPattern.md).FlatPunchResults

**Referenced types:** [FlatPunchResult](../objects/FlatPunchResult.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

