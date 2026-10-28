# SlotFeatures

Inventor API object · versions: 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.SlotFeatures`

```csharp
interface SlotFeatures
{
    // Properties
    object Application { get; } // since 2027
    int Count { get; } // since 2027
    SlotFeature Item[object Index] { get; } // since 2027
    ObjectTypeEnum Type { get; } // since 2027
    // Methods
    SlotFeature Add(SlotDefinition pDefinition); // since 2027
    HoleClearanceInfo CreateClearanceInfo(string FastenerStandard, string FastenerType, string FastenerSize, object FastenerFitType = Missing); // since 2027
    HoleSlotPlacementDefinition CreateHolePlacementDefinition(HoleFeature HoleFeature, object SlotDirectionType = Missing, object SlotDirectionEntity = Missing, object Rotation = Missing, object FlipRotation = Missing); // since 2027
    SketchSlotPlacementDefinition CreateSketchPlacementDefinition(ObjectCollection SlotCenterPoints, object SlotDirectionType = Missing, object SlotDirectionEntity = Missing, object Rotation = Missing, object FlipRotation = Missing); // since 2027
    SlotDefinition CreateSlotDefinition(SlotPlacementDefinition PlacementDefinition, SlotFilletTypeEnum FilletType, object Width, object Length, object SeatType = Missing, object MoreShapeInfo = Missing); // since 2027
    IEnumerator GetEnumerator(); // since 2027
}
```

**Returned by:** [Features](../objects/Features.md).SlotFeatures, [FlatPatternFeatures](../objects/FlatPatternFeatures.md).SlotFeatures, [PartFeatures](../objects/PartFeatures.md).SlotFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).SlotFeatures

**Referenced types:** [HoleClearanceInfo](../objects/HoleClearanceInfo.md), [HoleFeature](../objects/HoleFeature.md), [HoleSlotPlacementDefinition](../objects/HoleSlotPlacementDefinition.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchSlotPlacementDefinition](../objects/SketchSlotPlacementDefinition.md), [SlotDefinition](../objects/SlotDefinition.md), [SlotFeature](../objects/SlotFeature.md), [SlotFilletTypeEnum](../enums/SlotFilletTypeEnum.md), [SlotPlacementDefinition](../objects/SlotPlacementDefinition.md)

