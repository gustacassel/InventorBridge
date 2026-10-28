# FlatPatternOrientations

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition → (SheetMetalComponentDefinition).FlatPattern.FlatPatternOrientations`

```csharp
interface FlatPatternOrientations
{
    // Properties
    FlatPatternOrientation ActiveFlatPatternOrientation { get; }
    object Application { get; }
    int Count { get; }
    FlatPatternOrientation Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FlatPattern](../objects/FlatPattern.md).FlatPatternOrientations

**Referenced types:** [FlatPatternOrientation](../objects/FlatPatternOrientation.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

