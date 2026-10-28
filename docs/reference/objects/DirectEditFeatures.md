# DirectEditFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.DirectEditFeatures`

```csharp
interface DirectEditFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    DirectEditFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).DirectEditFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).DirectEditFeatures

**Referenced types:** [DirectEditFeature](../objects/DirectEditFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

