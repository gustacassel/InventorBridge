# CornerRoundFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features → (SheetMetalFeatures).CornerRoundFeatures`

```csharp
interface CornerRoundFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    CornerRoundFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    CornerRoundFeature Add(CornerRoundDefinition CornerRoundDefinition);
    CornerRoundDefinition CreateCornerRoundDefinition(EdgeCollection CornerEdges, object Radius);
    EdgeCollection GetEdgesFromFeature(PartFeature Feature); // since 2025
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FlatPatternFeatures](../objects/FlatPatternFeatures.md).CornerRoundFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).CornerRoundFeatures

**Referenced types:** [CornerRoundDefinition](../objects/CornerRoundDefinition.md), [CornerRoundFeature](../objects/CornerRoundFeature.md), [EdgeCollection](../objects/EdgeCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeature](../objects/PartFeature.md)

