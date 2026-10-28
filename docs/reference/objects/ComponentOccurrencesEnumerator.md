# ComponentOccurrencesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Occurrences.AllLeafOccurrences[…]`

```csharp
interface ComponentOccurrencesEnumerator
{
    // Properties
    int Count { get; }
    ComponentOccurrence Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AliasFreeformFeature](../objects/AliasFreeformFeature.md).Participants, [AliasFreeformFeatureProxy](../objects/AliasFreeformFeatureProxy.md).Participants, [BOMRow](../objects/BOMRow.md).ComponentOccurrences, [BendFeature](../objects/BendFeature.md).Participants, [BendFeatureProxy](../objects/BendFeatureProxy.md).Participants, [BendPartFeature](../objects/BendPartFeature.md).Participants, [BendPartFeatureProxy](../objects/BendPartFeatureProxy.md).Participants, [BossFeature](../objects/BossFeature.md).Participants, [BossFeatureProxy](../objects/BossFeatureProxy.md).Participants, [BoundaryPatchFeature](../objects/BoundaryPatchFeature.md).Participants, [BoundaryPatchFeatureProxy](../objects/BoundaryPatchFeatureProxy.md).Participants, [ChamferFeature](../objects/ChamferFeature.md).Participants, [ChamferFeatureProxy](../objects/ChamferFeatureProxy.md).Participants, [CircularPatternFeature](../objects/CircularPatternFeature.md).Participants, [CircularPatternFeatureProxy](../objects/CircularPatternFeatureProxy.md).Participants, [ClientFeature](../objects/ClientFeature.md).Participants, [ClientFeatureProxy](../objects/ClientFeatureProxy.md).Participants, [CoilFeature](../objects/CoilFeature.md).Participants, [CoilFeatureProxy](../objects/CoilFeatureProxy.md).Participants, [CombineFeature](../objects/CombineFeature.md).Participants, [CombineFeatureProxy](../objects/CombineFeatureProxy.md).Participants, [ComponentOccurrence](../objects/ComponentOccurrence.md).OccurrencePath, [ComponentOccurrence](../objects/ComponentOccurrence.md).SubOccurrences, [ComponentOccurrenceProxy](../objects/ComponentOccurrenceProxy.md).OccurrencePath, [ComponentOccurrenceProxy](../objects/ComponentOccurrenceProxy.md).SubOccurrences, [ComponentOccurrences](../objects/ComponentOccurrences.md).AddUsingiMates, [ComponentOccurrences](../objects/ComponentOccurrences.md).AllLeafOccurrences, [ComponentOccurrences](../objects/ComponentOccurrences.md).AllReferencedOccurrences, [ContourFlangeFeature](../objects/ContourFlangeFeature.md).Participants, [ContourFlangeFeatureProxy](../objects/ContourFlangeFeatureProxy.md).Participants, [ContourRollFeature](../objects/ContourRollFeature.md).Participants, [ContourRollFeatureProxy](../objects/ContourRollFeatureProxy.md).Participants, [CornerChamferFeature](../objects/CornerChamferFeature.md).Participants, [CornerChamferFeatureProxy](../objects/CornerChamferFeatureProxy.md).Participants, [CornerFeature](../objects/CornerFeature.md).Participants, [CornerFeatureProxy](../objects/CornerFeatureProxy.md).Participants, [CornerRoundFeature](../objects/CornerRoundFeature.md).Participants, [CornerRoundFeatureProxy](../objects/CornerRoundFeatureProxy.md).Participants, [CosmeticBendFeature](../objects/CosmeticBendFeature.md).Participants, [CosmeticBendFeatureProxy](../objects/CosmeticBendFeatureProxy.md).Participants and 106 more (see `members.tsv`)

**Referenced types:** [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

