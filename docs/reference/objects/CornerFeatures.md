# CornerFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features → (SheetMetalFeatures).CornerFeatures`

```csharp
interface CornerFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    CornerFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    CornerFeature Add(CornerDefinition CornerDefinition);
    CornerDefinition CreateCornerDefinition(EdgeCollection Edges, bool RippedCorner);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SheetMetalFeatures](../objects/SheetMetalFeatures.md).CornerFeatures

**Referenced types:** [CornerDefinition](../objects/CornerDefinition.md), [CornerFeature](../objects/CornerFeature.md), [EdgeCollection](../objects/EdgeCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

