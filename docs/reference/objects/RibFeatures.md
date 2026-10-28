# RibFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.RibFeatures`

```csharp
interface RibFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    RibFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    RibFeature Add(RibDefinition Definition);
    RibDefinition CreateDefinition(ObjectCollection ProfileCurves, bool IsRib, bool DirectionReversed, object Thickness);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).RibFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).RibFeatures

**Referenced types:** [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RibDefinition](../objects/RibDefinition.md), [RibFeature](../objects/RibFeature.md)

