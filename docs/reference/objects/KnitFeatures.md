# KnitFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.KnitFeatures`

```csharp
interface KnitFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    KnitFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    KnitFeature Add(ObjectCollection Surfaces, double MaximumTolerance = 0.02539999969303608, bool MaintainAsSurface = false);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).KnitFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).KnitFeatures

**Referenced types:** [KnitFeature](../objects/KnitFeature.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

