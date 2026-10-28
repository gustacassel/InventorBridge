# FinishFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.FinishFeatures`

```csharp
interface FinishFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    FinishFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    FinishFeature Add(FinishDefinition pDefinition);
    FinishDefinition CreateDefinition(ObjectCollection pIncludedEntities, object vtExcludedEntities = Missing, FinishTypeEnum FinishType = FinishTypeEnum.kAppearanceFinishType, object vtProcessName = Missing, object vtAppearance = Missing, object vtMoreOptions = Missing); // since 2025
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Features](../objects/Features.md).FinishFeatures, [PartFeatures](../objects/PartFeatures.md).FinishFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).FinishFeatures

**Referenced types:** [FinishDefinition](../objects/FinishDefinition.md), [FinishFeature](../objects/FinishFeature.md), [FinishTypeEnum](../enums/FinishTypeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

