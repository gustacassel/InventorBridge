# HoleFeatureProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [HoleFeature](../objects/HoleFeature.md) → [PartFeature](../objects/PartFeature.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.HoleFeatures.Item[…] → (HoleFeatureProxy)`

```csharp
interface HoleFeatureProxy
{
    // Properties
    bool Adaptive { get; set; }
    Asset Appearance { get; set; }
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    Parameter BottomTipAngle { get; }
    Parameter CBoreDepth { get; }
    Parameter CBoreDiameter { get; }
    Parameter CSinkAngle { get; }
    double CSinkDepth { get; }
    Parameter CSinkDiameter { get; }
    HoleClearanceInfo ClearanceInfo { get; set; }
    bool ConsumeInputs { get; set; }
    ComponentOccurrence ContainingOccurrence { get; }
    double Depth { get; }
    HoleDrillPointTypeEnum DrillPointType { get; set; } // since 2025
    Faces EndFaces { get; }
    bool ExtendStart { get; set; }
    string ExtendedName { get; }
    PartFeatureExtent Extent { get; }
    PartFeatureExtentEnum ExtentType { get; }
    Faces Faces { get; }
    FeatureDimensions FeatureDimensions { get; }
    HealthStatusEnum HealthStatus { get; }
    ObjectCollection HoleCenterPoints { get; set; }
    Parameter HoleDiameter { get; }
    HoleTypeEnum HoleType { get; }
    bool IsClearanceHole { get; }
    bool IsOwnedByFeature { get; }
    string Name { get; set; }
    HoleFeature NativeObject { get; }
    PartFeature OwnedBy { get; }
    ParametersEnumerator Parameters { get; }
    ComponentDefinition Parent { get; }
    ComponentOccurrencesEnumerator Participants { get; }
    HolePlacementDefinition PlacementDefinition { get; set; }
    HolePlacementTypeEnum PlacementType { get; }
    Box RangeBox { get; }
    bool Shared { get; set; }
    Faces SideFaces { get; }
    PlanarSketch Sketch { get; }
    Parameter SpotFaceDepth { get; }
    Parameter SpotFaceDiameter { get; }
    bool Suppressed { get; set; }
    SurfaceBodies SurfaceBodies { get; }
    object TapInfo { get; set; }
    bool Tapped { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void AddParticipant(ComponentOccurrence Occurrence);
    void Delete(bool RetainConsumedSketches = false, bool RetainDependentFeaturesAndSketches = false, bool RetainDependentWorkFeatures = false);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    bool GetSuppressionCondition(out Parameter Parameter, out ComparisonTypeEnum ComparisonType, out object Expression);
    void RemoveParticipant(ComponentOccurrence Occurrence);
    void SetAffectedBodies(ObjectCollection Bodies);
    void SetCBore(object CBoreDiameter, object CBoreDepth);
    void SetCSink(object CSinkDiameter, object CSinkAngle);
    void SetDistanceExtent2(object Depth, PartFeatureExtentDirectionEnum ExtentDirection, object DrillPointType = 126977, object BottomTipAngle = Missing); // since 2025
    void SetDrilled();
    void SetEndOfPart(bool Before);
    void SetSpotFace(object SpotFaceDiameter, object SpotFaceDepth);
    void SetSuppressionCondition(Parameter Parameter, ComparisonTypeEnum ComparisonType, object Expression);
    void SetThroughAllExtent(PartFeatureExtentDirectionEnum ExtentDirection);
    void SetToFaceExtent2(object ToFace, bool ExtendToFace, object DrillPointType = 126977, object BottomTipAngle = Missing); // since 2025
}
```

6 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AppearanceSourceTypeEnum](../enums/AppearanceSourceTypeEnum.md), [Asset](../objects/Asset.md), [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ComparisonTypeEnum](../enums/ComparisonTypeEnum.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ComponentOccurrencesEnumerator](../objects/ComponentOccurrencesEnumerator.md), [Faces](../objects/Faces.md), [FeatureDimensions](../objects/FeatureDimensions.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [HoleClearanceInfo](../objects/HoleClearanceInfo.md), [HoleDrillPointTypeEnum](../enums/HoleDrillPointTypeEnum.md), [HoleFeature](../objects/HoleFeature.md), [HolePlacementDefinition](../objects/HolePlacementDefinition.md), [HolePlacementTypeEnum](../enums/HolePlacementTypeEnum.md), [HoleTypeEnum](../enums/HoleTypeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [ParametersEnumerator](../objects/ParametersEnumerator.md), [PartFeature](../objects/PartFeature.md), [PartFeatureExtent](../objects/PartFeatureExtent.md), [PartFeatureExtentDirectionEnum](../enums/PartFeatureExtentDirectionEnum.md), [PartFeatureExtentEnum](../enums/PartFeatureExtentEnum.md), [PlanarSketch](../objects/PlanarSketch.md), [SurfaceBodies](../objects/SurfaceBodies.md)

