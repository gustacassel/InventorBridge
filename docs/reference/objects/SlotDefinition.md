# SlotDefinition

Inventor API object · versions: 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.SlotFeatures.Item[…].Definition`

```csharp
interface SlotDefinition
{
    // Properties
    bool AddiMate { get; set; } // since 2027
    ObjectCollection AffectedBodies { get; set; } // since 2027
    ObjectCollection AffectedOccurrences { get; set; } // since 2027
    object Application { get; } // since 2027
    SlotCenterMarksTypeEnum CenterMarksType { get; set; } // since 2027
    HoleClearanceInfo ClearanceInfo { get; set; } // since 2027
    object CounterboreDepth { get; set; } // since 2027
    object CounterboreWidth { get; set; } // since 2027
    object CountersinkAngle { get; set; } // since 2027
    object CountersinkWidth { get; set; } // since 2027
    object Depth { get; set; } // since 2027
    object EndMillAngle { get; set; } // since 2027
    SlotEndMillTypeEnum EndMillType { get; set; } // since 2027
    bool ExtendStart { get; set; } // since 2027
    PartFeatureExtent Extent { get; } // since 2027
    PartFeatureExtentDirectionEnum ExtentDirection { get; set; } // since 2027
    PartFeatureExtentEnum ExtentType { get; } // since 2027
    SlotFilletTypeEnum FilletType { get; set; } // since 2027
    bool IsClearanceHole { get; set; } // since 2027
    object Length { get; set; } // since 2027
    SlotFeature Parent { get; } // since 2027
    SlotPlacementDefinition PlacementDefinition { get; set; } // since 2027
    SeatTypeEnum SeatType { get; } // since 2027
    PlanarSketch Sketch { get; } // since 2027
    object SpotFaceDepth { get; set; } // since 2027
    object SpotfaceWidth { get; set; } // since 2027
    ObjectTypeEnum Type { get; } // since 2027
    object Width { get; set; } // since 2027
    // Methods
    SlotDefinition Copy(); // since 2027
    void SetDistanceExtent(object Distance, PartFeatureExtentDirectionEnum ExtentDirection, object EndMillType = Missing, object BottomTipAngle = Missing); // since 2027
    void SetThroughAllExtent(PartFeatureExtentDirectionEnum ExtentDirection); // since 2027
    void SetToCounterboreSeat(object CounterboreWidth, object CounterboreDepth); // since 2027
    void SetToCountersinkSeat(object CountersinkWidth, object CountersinkAngle); // since 2027
    void SetToFaceExtent(object ToFace, bool ExtendToFace, object EndMillType = Missing, object BottomTipAngle = Missing); // since 2027
    void SetToNoneSeat(); // since 2027
    void SetToSpotfaceSeat(object SpotfaceWidth, object SpotFaceDepth); // since 2027
}
```

**Returned by:** [SlotDefinition](../objects/SlotDefinition.md).Copy, [SlotFeature](../objects/SlotFeature.md).Definition, [SlotFeatureProxy](../objects/SlotFeatureProxy.md).Definition, [SlotFeatures](../objects/SlotFeatures.md).CreateSlotDefinition

**Referenced types:** [HoleClearanceInfo](../objects/HoleClearanceInfo.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureExtent](../objects/PartFeatureExtent.md), [PartFeatureExtentDirectionEnum](../enums/PartFeatureExtentDirectionEnum.md), [PartFeatureExtentEnum](../enums/PartFeatureExtentEnum.md), [PlanarSketch](../objects/PlanarSketch.md), [SeatTypeEnum](../enums/SeatTypeEnum.md), [SlotCenterMarksTypeEnum](../enums/SlotCenterMarksTypeEnum.md), [SlotEndMillTypeEnum](../enums/SlotEndMillTypeEnum.md), [SlotFeature](../objects/SlotFeature.md), [SlotFilletTypeEnum](../enums/SlotFilletTypeEnum.md), [SlotPlacementDefinition](../objects/SlotPlacementDefinition.md)

