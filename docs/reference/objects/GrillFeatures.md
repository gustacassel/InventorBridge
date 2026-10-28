# GrillFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.GrillFeatures`

```csharp
interface GrillFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    GrillFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).GrillFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).GrillFeatures

**Referenced types:** [GrillFeature](../objects/GrillFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

