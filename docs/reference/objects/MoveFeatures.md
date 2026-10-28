# MoveFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.MoveFeatures`

```csharp
interface MoveFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    MoveFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    MoveFeature Add(MoveDefinition MoveDefinition);
    MoveDefinition CreateMoveDefinition(ObjectCollection Bodies);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).MoveFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).MoveFeatures

**Referenced types:** [MoveDefinition](../objects/MoveDefinition.md), [MoveFeature](../objects/MoveFeature.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

