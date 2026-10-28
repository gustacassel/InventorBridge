# LoftedFlangeFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features → (SheetMetalFeatures).LoftedFlangeFeatures`

```csharp
interface LoftedFlangeFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    LoftedFlangeFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    LoftedFlangeFeature Add(LoftedFlangeDefinition LoftedFlangeDefinition);
    LoftedFlangeDefinition CreateLoftedFlangeDefinition(Path ProfileOne, Path ProfileTwo);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SheetMetalFeatures](../objects/SheetMetalFeatures.md).LoftedFlangeFeatures

**Referenced types:** [LoftedFlangeDefinition](../objects/LoftedFlangeDefinition.md), [LoftedFlangeFeature](../objects/LoftedFlangeFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Path](../objects/Path.md)

