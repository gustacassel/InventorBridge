# MarkFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.MarkFeatures`

```csharp
interface MarkFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    MarkFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    MarkFeature Add(MarkDefinition pDefinition);
    MarkDefinition CreateMarkDefinition(ObjectCollection pGeoms, MarkStyle pStyle);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FlatPatternFeatures](../objects/FlatPatternFeatures.md).MarkFeatures, [PartFeatures](../objects/PartFeatures.md).MarkFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).MarkFeatures

**Referenced types:** [MarkDefinition](../objects/MarkDefinition.md), [MarkFeature](../objects/MarkFeature.md), [MarkStyle](../objects/MarkStyle.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

