# AliasFreeformFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.AliasFreeformFeatures`

```csharp
interface AliasFreeformFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    AliasFreeformFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).AliasFreeformFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).AliasFreeformFeatures

**Referenced types:** [AliasFreeformFeature](../objects/AliasFreeformFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

