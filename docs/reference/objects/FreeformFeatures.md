# FreeformFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.FreeformFeatures`

```csharp
interface FreeformFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    FreeformFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).FreeformFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).FreeformFeatures

**Referenced types:** [FreeformFeature](../objects/FreeformFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

