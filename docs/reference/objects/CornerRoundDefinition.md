# CornerRoundDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.Item[…] → (CornerRoundFeature).Definition`

```csharp
interface CornerRoundDefinition
{
    // Properties
    object Application { get; }
    int EdgeSetCount { get; }
    CornerRoundEdgeSet EdgeSetItem[int Index] { get; }
    CornerRoundFeature Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    CornerRoundEdgeSet AddEdgeSet(EdgeCollection CornerEdges, object Radius);
    CornerRoundDefinition Copy();
    void RemoveEdgeSet(int Index);
}
```

**Returned by:** [CornerRoundDefinition](../objects/CornerRoundDefinition.md).Copy, [CornerRoundEdgeSet](../objects/CornerRoundEdgeSet.md).Parent, [CornerRoundFeature](../objects/CornerRoundFeature.md).Definition, [CornerRoundFeatureProxy](../objects/CornerRoundFeatureProxy.md).Definition, [CornerRoundFeatures](../objects/CornerRoundFeatures.md).CreateCornerRoundDefinition

**Referenced types:** [CornerRoundEdgeSet](../objects/CornerRoundEdgeSet.md), [CornerRoundFeature](../objects/CornerRoundFeature.md), [EdgeCollection](../objects/EdgeCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

