# BossFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.BossFeatures`

```csharp
interface BossFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    BossFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).BossFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).BossFeatures

**Referenced types:** [BossFeature](../objects/BossFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

