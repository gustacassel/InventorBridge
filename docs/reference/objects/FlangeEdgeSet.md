# FlangeEdgeSet

Inventor API object · versions: 2025, 2026, 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.Item[…] → (ContourFlangeFeature).Definition.AddContourFlangeEdgeSet(…)`

```csharp
interface FlangeEdgeSet
{
    // Properties
    object Application { get; } // since 2025
    EdgeCollection Edges { get; set; } // since 2025
    ObjectTypeEnum Type { get; } // since 2025
    PartFeatureExtent WidthExtent { get; } // since 2025
    PartFeatureExtentEnum WidthExtentType { get; } // since 2025
    // Methods
    void Delete(); // since 2025
    void SetCenteredWidthExtent(object Width); // since 2025
    void SetEdgeWidthExtent(); // since 2025
    void SetFromToWidthExtent(object FromEntity, object ToEntity); // since 2025
    void SetOffsetdWidthExtent(object OffsetEntityOne, object OffsetDistanceOne, object OffsetEntityTwo, object OffsetDistanceTwo); // since 2025
    void SetWidthOffsetWidthExtent(object Width, object OffsetDistance, object OffsetEntity, bool PositiveDirection); // since 2025
}
```

**Returned by:** [ContourFlangeDefinition](../objects/ContourFlangeDefinition.md).AddContourFlangeEdgeSet, [ContourFlangeDefinition](../objects/ContourFlangeDefinition.md).ContourFlangeEdgeSetItem, [FlangeDefinition](../objects/FlangeDefinition.md).AddFlangeEdgeSet, [FlangeDefinition](../objects/FlangeDefinition.md).EdgeSetItem

**Referenced types:** [EdgeCollection](../objects/EdgeCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureExtent](../objects/PartFeatureExtent.md), [PartFeatureExtentEnum](../enums/PartFeatureExtentEnum.md)

