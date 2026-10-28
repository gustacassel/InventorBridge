# CosmeticBendFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition → (SheetMetalComponentDefinition).FlatPattern.Features.CosmeticBendFeatures`

```csharp
interface CosmeticBendFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    CosmeticBendFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FlatPatternFeatures](../objects/FlatPatternFeatures.md).CosmeticBendFeatures

**Referenced types:** [CosmeticBendFeature](../objects/CosmeticBendFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

