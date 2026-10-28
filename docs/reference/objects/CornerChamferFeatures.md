# CornerChamferFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features → (SheetMetalFeatures).CornerChamferFeatures`

```csharp
interface CornerChamferFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    CornerChamferFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    CornerChamferFeature Add(CornerChamferDefinition CornerChamferDefinition);
    CornerChamferDefinition CreateCornerChamferDefinition(object CornerEdges, object Distance);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FlatPatternFeatures](../objects/FlatPatternFeatures.md).CornerChamferFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).CornerChamferFeatures

**Referenced types:** [CornerChamferDefinition](../objects/CornerChamferDefinition.md), [CornerChamferFeature](../objects/CornerChamferFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

