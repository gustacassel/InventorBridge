# BendFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features → (SheetMetalFeatures).BendFeatures`

```csharp
interface BendFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    BendFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    BendFeature Add(BendDefinition BendDefinition);
    BendDefinition CreateBendDefinition(EdgeCollection Edges);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SheetMetalFeatures](../objects/SheetMetalFeatures.md).BendFeatures

**Referenced types:** [BendDefinition](../objects/BendDefinition.md), [BendFeature](../objects/BendFeature.md), [EdgeCollection](../objects/EdgeCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

