# RestFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.RestFeatures`

```csharp
interface RestFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    RestFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).RestFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).RestFeatures

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RestFeature](../objects/RestFeature.md)

