# LipFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.LipFeatures`

```csharp
interface LipFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    LipFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).LipFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).LipFeatures

**Referenced types:** [LipFeature](../objects/LipFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

