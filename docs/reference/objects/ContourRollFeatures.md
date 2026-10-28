# ContourRollFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features → (SheetMetalFeatures).ContourRollFeatures`

```csharp
interface ContourRollFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    ContourRollFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SheetMetalFeatures](../objects/SheetMetalFeatures.md).ContourRollFeatures

**Referenced types:** [ContourRollFeature](../objects/ContourRollFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

