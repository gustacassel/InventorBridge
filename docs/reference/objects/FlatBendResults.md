# FlatBendResults

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition → (SheetMetalComponentDefinition).FlatPattern.FlatBendResults`

```csharp
interface FlatBendResults
{
    // Properties
    object Application { get; }
    int Count { get; }
    FlatBendResult Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FlatPattern](../objects/FlatPattern.md).FlatBendResults

**Referenced types:** [FlatBendResult](../objects/FlatBendResult.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

