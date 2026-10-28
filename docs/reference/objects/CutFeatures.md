# CutFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features → (SheetMetalFeatures).CutFeatures`

```csharp
interface CutFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    CutFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    CutFeature Add(CutDefinition CutDefinition);
    CutDefinition CreateCutDefinition(Profile Profile);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FlatPatternFeatures](../objects/FlatPatternFeatures.md).CutFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).CutFeatures

**Referenced types:** [CutDefinition](../objects/CutDefinition.md), [CutFeature](../objects/CutFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Profile](../objects/Profile.md)

