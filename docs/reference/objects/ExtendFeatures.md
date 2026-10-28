# ExtendFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.ExtendFeatures`

```csharp
interface ExtendFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    ExtendFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).ExtendFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).ExtendFeatures

**Referenced types:** [ExtendFeature](../objects/ExtendFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

