# FlangeDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.Item[…] → (FlangeFeature).Definition`

```csharp
interface FlangeDefinition
{
    // Properties
    object Application { get; }
    bool ApplyAutoMitering { get; set; }
    BendOptions BendOptions { get; set; }
    BendPositionEnum BendPosition { get; set; } // hidden in 2025, 2026, 2027: there, prefer the newer members
    object BendRadius { get; set; }
    CornerOptions CornerOptions { get; set; }
    PartFeatureExtent DefaultWidthExtent { get; } // hidden in 2025, 2026, 2027: there, prefer the newer members
    PartFeatureExtentEnum DefaultWidthExtentType { get; } // hidden in 2025, 2026, 2027: there, prefer the newer members
    int EdgeSetCount { get; } // since 2025
    EdgeCollection Edges { get; set; } // hidden in 2025, 2026, 2027: there, prefer the newer members
    object FlangeAngle { get; set; }
    object FlangeAngleReferencePlane { get; set; }
    FlangeReferenceTypeEnum FlangeAngleReferenceType { get; set; } // since 2025
    DirectionEnum FlangePlacementType { get; set; } // since 2025
    PartFeatureExtent HeightExtent { get; }
    PartFeatureExtentEnum HeightExtentType { get; }
    bool IsUnfoldMethodOverridden { get; set; }
    object MiterGap { get; set; }
    FlangeFeature Parent { get; }
    ObjectTypeEnum Type { get; }
    UnfoldMethod UnfoldMethod { get; set; }
    // Methods
    FlangeEdgeSet AddFlangeEdgeSet(EdgeCollection Edges); // since 2025
    FlangeDefinition Copy();
    FlangeEdgeSet EdgeSetItem(int Index); // since 2025
    PartFeatureExtent GetWidthExtent(Edge Edge); // hidden in 2025, 2026, 2027: there, prefer the newer members
    PartFeatureExtentEnum GetWidthExtentType(Edge Edge, out bool HasOverride); // hidden in 2025, 2026, 2027: there, prefer the newer members
    void RemoveOverrideWidthExtent(Edge Edge); // hidden in 2025, 2026, 2027: there, prefer the newer members
    void SetCenteredDefaultWidthExtent(object Width); // hidden in 2025, 2026, 2027: there, prefer the newer members
    void SetCenteredWidthExtent(Edge Edge, object Width); // hidden in 2025, 2026, 2027: there, prefer the newer members
    void SetDistanceHeightExtent(object Distance, PartFeatureExtentDirectionEnum ExtentDirection, HeightDatumTypeEnum HeightDatumType);
    void SetEdgeDefaultWidthExtent(); // hidden in 2025, 2026, 2027: there, prefer the newer members
    void SetEdgeWidthExtent(Edge Edge); // hidden in 2025, 2026, 2027: there, prefer the newer members
    void SetFlangeAngleReferenceType(FlangeReferenceTypeEnum ReferenceType, object FlangeAngleOrReferencePlane = Missing, object PlancementType = Missing); // since 2025
    void SetFromToDefaultWidthExtent(object FromEntity, object ToEntity); // hidden in 2025, 2026, 2027: there, prefer the newer members
    void SetFromToWidthExtent(Edge Edge, object FromEntity, object ToEntity); // hidden in 2025, 2026, 2027: there, prefer the newer members
    void SetLegacyDistanceHeightExtent(object Distance, PartFeatureExtentDirectionEnum ExtentDirection, HeightDatumTypeEnum HeightDatumType);
    void SetOffsetDefaultWidthExtent(object OffsetEntityOne, object OffsetDistanceOne, object OffsetEntityTwo, object OffsetDistanceTwo); // hidden in 2025, 2026, 2027: there, prefer the newer members
    void SetOffsetWidthExtent(Edge Edge, object OffsetEntityOne, object OffsetDistanceOne, object OffsetEntityTwo, object OffsetDistanceTwo); // hidden in 2025, 2026, 2027: there, prefer the newer members
    void SetToHeightExtent(object ToEntity, object Offset = Missing);
    void SetWidthOffsetDefaultWidthExtent(object Width, object OffsetDistance, object OffsetEntity, bool PositiveDirection); // hidden in 2025, 2026, 2027: there, prefer the newer members
    void SetWidthOffsetWidthExtent(Edge Edge, object Width, object OffsetDistance, object OffsetEntity, bool PositiveDirection); // hidden in 2025, 2026, 2027: there, prefer the newer members
}
```

**Returned by:** [FlangeDefinition](../objects/FlangeDefinition.md).Copy, [FlangeFeature](../objects/FlangeFeature.md).Definition, [FlangeFeatureProxy](../objects/FlangeFeatureProxy.md).Definition, [FlangeFeatures](../objects/FlangeFeatures.md).CreateDefinition, [FlangeFeatures](../objects/FlangeFeatures.md).CreateFlangeDefinition

**Referenced types:** [BendOptions](../objects/BendOptions.md), [CornerOptions](../objects/CornerOptions.md), [DirectionEnum](../enums/DirectionEnum.md), [Edge](../objects/Edge.md), [EdgeCollection](../objects/EdgeCollection.md), [FlangeEdgeSet](../objects/FlangeEdgeSet.md), [FlangeFeature](../objects/FlangeFeature.md), [FlangeReferenceTypeEnum](../enums/FlangeReferenceTypeEnum.md), [HeightDatumTypeEnum](../enums/HeightDatumTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureExtent](../objects/PartFeatureExtent.md), [PartFeatureExtentDirectionEnum](../enums/PartFeatureExtentDirectionEnum.md), [PartFeatureExtentEnum](../enums/PartFeatureExtentEnum.md), [UnfoldMethod](../objects/UnfoldMethod.md)

