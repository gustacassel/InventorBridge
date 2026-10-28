# TrimFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.TrimFeatures`

```csharp
interface TrimFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    TrimFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).TrimFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).TrimFeatures

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [TrimFeature](../objects/TrimFeature.md)

