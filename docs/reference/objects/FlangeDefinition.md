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
    object BendRadius { get; set; }
    CornerOptions CornerOptions { get; set; }
    int EdgeSetCount { get; } // since 2025
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
    void SetDistanceHeightExtent(object Distance, PartFeatureExtentDirectionEnum ExtentDirection, HeightDatumTypeEnum HeightDatumType);
    void SetFlangeAngleReferenceType(FlangeReferenceTypeEnum ReferenceType, object FlangeAngleOrReferencePlane = Missing, object PlancementType = Missing); // since 2025
    void SetLegacyDistanceHeightExtent(object Distance, PartFeatureExtentDirectionEnum ExtentDirection, HeightDatumTypeEnum HeightDatumType);
    void SetToHeightExtent(object ToEntity, object Offset = Missing);
}
```

17 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FlangeDefinition](../objects/FlangeDefinition.md).Copy, [FlangeFeature](../objects/FlangeFeature.md).Definition, [FlangeFeatureProxy](../objects/FlangeFeatureProxy.md).Definition, [FlangeFeatures](../objects/FlangeFeatures.md).CreateDefinition

**Referenced types:** [BendOptions](../objects/BendOptions.md), [CornerOptions](../objects/CornerOptions.md), [DirectionEnum](../enums/DirectionEnum.md), [EdgeCollection](../objects/EdgeCollection.md), [FlangeEdgeSet](../objects/FlangeEdgeSet.md), [FlangeFeature](../objects/FlangeFeature.md), [FlangeReferenceTypeEnum](../enums/FlangeReferenceTypeEnum.md), [HeightDatumTypeEnum](../enums/HeightDatumTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureExtent](../objects/PartFeatureExtent.md), [PartFeatureExtentDirectionEnum](../enums/PartFeatureExtentDirectionEnum.md), [PartFeatureExtentEnum](../enums/PartFeatureExtentEnum.md), [UnfoldMethod](../objects/UnfoldMethod.md)

