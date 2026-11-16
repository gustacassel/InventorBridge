# HoleFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.HoleFeatures`

```csharp
interface HoleFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    HoleFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    HoleFeature AddCBoreByDistanceExtent(object PlacementDefinition, object DiameterOrTapInfo, object Depth, PartFeatureExtentDirectionEnum ExtentDirection, object CBoreDiameter, object CBoreDepth, bool FlatBottom = true, object BottomTipAngle = Missing); // hidden in 2025, 2026, 2027: there, prefer the newer members
    HoleFeature AddCBoreByDistanceExtent2(object PlacementDefinition, object DiameterOrTapInfo, object Depth, PartFeatureExtentDirectionEnum ExtentDirection, object CBoreDiameter, object CBoreDepth, object DrillPointType = 126977, object BottomTipAngle = Missing); // since 2025
    HoleFeature AddCBoreByThroughAllExtent(object PlacementDefinition, object DiameterOrTapInfo, PartFeatureExtentDirectionEnum ExtentDirection, object CBoreDiameter, object CBoreDepth);
    HoleFeature AddCBoreByToFaceExtent(object PlacementDefinition, object DiameterOrTapInfo, object ToFace, bool ExtendToFace, object CBoreDiameter, object CBoreDepth, bool FlatBottom = true, object BottomTipAngle = Missing); // hidden in 2025, 2026, 2027: there, prefer the newer members
    HoleFeature AddCBoreByToFaceExtent2(object PlacementDefinition, object DiameterOrTapInfo, object ToFace, bool ExtendToFace, object CBoreDiameter, object CBoreDepth, object DrillPointType = 126977, object BottomTipAngle = Missing); // since 2025
    HoleFeature AddCSinkByDistanceExtent(object PlacementDefinition, object DiameterOrTapInfo, object Depth, PartFeatureExtentDirectionEnum ExtentDirection, object CSinkDiameter, object CSinkAngle, bool FlatBottom = true, object BottomTipAngle = Missing); // hidden in 2025, 2026, 2027: there, prefer the newer members
    HoleFeature AddCSinkByDistanceExtent2(object PlacementDefinition, object DiameterOrTapInfo, object Depth, PartFeatureExtentDirectionEnum ExtentDirection, object CSinkDiameter, object CSinkAngle, object DrillPointType = 126977, object BottomTipAngle = Missing); // since 2025
    HoleFeature AddCSinkByThroughAllExtent(object PlacementDefinition, object DiameterOrTapInfo, PartFeatureExtentDirectionEnum ExtentDirection, object CSinkDiameter, object CSinkAngle);
    HoleFeature AddCSinkByToFaceExtent(object PlacementDefinition, object DiameterOrTapInfo, object ToFace, bool ExtendToFace, object CSinkDiameter, object CSinkAngle, bool FlatBottom = true, object BottomTipAngle = Missing); // hidden in 2025, 2026, 2027: there, prefer the newer members
    HoleFeature AddCSinkByToFaceExtent2(object PlacementDefinition, object DiameterOrTapInfo, object ToFace, bool ExtendToFace, object CSinkDiameter, object CSinkAngle, object DrillPointType = 126977, object BottomTipAngle = Missing); // since 2025
    HoleFeature AddDrilledByDistanceExtent(object PlacementDefinition, object DiameterOrTapInfo, object Depth, PartFeatureExtentDirectionEnum ExtentDirection, bool FlatBottom = true, object BottomTipAngle = Missing); // hidden in 2025, 2026, 2027: there, prefer the newer members
    HoleFeature AddDrilledByDistanceExtent2(object PlacementDefinition, object DiameterOrTapInfo, object Depth, PartFeatureExtentDirectionEnum ExtentDirection, object DrillPointType = 126977, object BottomTipAngle = Missing); // since 2025
    HoleFeature AddDrilledByThroughAllExtent(object PlacementDefinition, object DiameterOrTapInfo, PartFeatureExtentDirectionEnum ExtentDirection);
    HoleFeature AddDrilledByToFaceExtent(object PlacementDefinition, object DiameterOrTapInfo, object ToFace, bool ExtendToFace, bool FlatBottom = true, object BottomTipAngle = Missing); // hidden in 2025, 2026, 2027: there, prefer the newer members
    HoleFeature AddDrilledByToFaceExtent2(object PlacementDefinition, object DiameterOrTapInfo, object ToFace, bool ExtendToFace, object DrillPointType = 126977, object BottomTipAngle = Missing); // since 2025
    HoleFeature AddSpotFaceByDistanceExtent(object PlacementDefinition, object DiameterOrTapInfo, object Depth, PartFeatureExtentDirectionEnum ExtentDirection, object SpotFaceDiameter, object SpotFaceDepth, bool FlatBottom = true, object BottomTipAngle = Missing); // hidden in 2025, 2026, 2027: there, prefer the newer members
    HoleFeature AddSpotFaceByDistanceExtent2(object PlacementDefinition, object DiameterOrTapInfo, object Depth, PartFeatureExtentDirectionEnum ExtentDirection, object SpotFaceDiameter, object SpotFaceDepth, object DrillPointType = 126977, object BottomTipAngle = Missing); // since 2025
    HoleFeature AddSpotFaceByThroughAllExtent(object PlacementDefinition, object DiameterOrTapInfo, PartFeatureExtentDirectionEnum ExtentDirection, object SpotFaceDiameter, object SpotFaceDepth);
    HoleFeature AddSpotFaceByToFaceExtent(object PlacementDefinition, object DiameterOrTapInfo, object ToFace, bool ExtendToFace, object SpotFaceDiameter, object SpotFaceDepth, bool FlatBottom = true, object BottomTipAngle = Missing); // hidden in 2025, 2026, 2027: there, prefer the newer members
    HoleFeature AddSpotFaceByToFaceExtent2(object PlacementDefinition, object DiameterOrTapInfo, object ToFace, bool ExtendToFace, object SpotFaceDiameter, object SpotFaceDepth, object DrillPointType = 126977, object BottomTipAngle = Missing); // since 2025
    HoleClearanceInfo CreateClearanceInfo(string FastenerStandard, string FastenerType, string FastenerSize, object FastenerFitType = Missing);
    ConcentricHolePlacementDefinition CreateConcentricPlacementDefinition(object Plane, object ConcentricReference); // hidden in 2025, 2026, 2027: there, prefer the newer members
    LinearHolePlacementDefinition CreateLinearPlacementDefinition(object Plane, object ReferenceEntityOne, object DistanceOne, object ReferenceEntityTwo, object DistanceTwo, Point BiasPoint); // hidden in 2025, 2026, 2027: there, prefer the newer members
    PointHolePlacementDefinition CreatePointPlacementDefinition(object Point, object Direction);
    SketchHolePlacementDefinition CreateSketchPlacementDefinition(ObjectCollection HoleCenterPoints);
    HoleTapInfo CreateTapInfo(bool RightHanded, string ThreadType, string ThreadDesignation, string Class, bool FullTapDepth, object ThreadDepth = Missing);
    TaperedThreadInfo CreateTaperedTapInfo(bool RightHanded, string ThreadType, string ThreadDesignation);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Features](../objects/Features.md).HoleFeatures, [FlatPatternFeatures](../objects/FlatPatternFeatures.md).HoleFeatures, [PartFeatures](../objects/PartFeatures.md).HoleFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).HoleFeatures

**Referenced types:** [ConcentricHolePlacementDefinition](../objects/ConcentricHolePlacementDefinition.md), [HoleClearanceInfo](../objects/HoleClearanceInfo.md), [HoleFeature](../objects/HoleFeature.md), [HoleTapInfo](../objects/HoleTapInfo.md), [LinearHolePlacementDefinition](../objects/LinearHolePlacementDefinition.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureExtentDirectionEnum](../enums/PartFeatureExtentDirectionEnum.md), [Point](../objects/Point.md), [PointHolePlacementDefinition](../objects/PointHolePlacementDefinition.md), [SketchHolePlacementDefinition](../objects/SketchHolePlacementDefinition.md), [TaperedThreadInfo](../objects/TaperedThreadInfo.md)

