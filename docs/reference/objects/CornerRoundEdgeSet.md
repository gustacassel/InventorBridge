# CornerRoundEdgeSet

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.Item[…] → (CornerRoundFeature).Definition.EdgeSetItem[…]`

```csharp
interface CornerRoundEdgeSet
{
    // Properties
    EdgeCollection Edges { get; set; }
    CornerRoundDefinition Parent { get; }
    object Radius { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [CornerRoundDefinition](../objects/CornerRoundDefinition.md).AddEdgeSet, [CornerRoundDefinition](../objects/CornerRoundDefinition.md).EdgeSetItem

**Referenced types:** [CornerRoundDefinition](../objects/CornerRoundDefinition.md), [EdgeCollection](../objects/EdgeCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

