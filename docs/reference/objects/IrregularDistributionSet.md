# IrregularDistributionSet

Inventor API object · versions: 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.CircularPatternFeatures.Item[…].Definition.IrregularDistributionSet`

```csharp
interface IrregularDistributionSet
{
    // Properties
    object Application { get; } // since 2027
    int Count { get; } // since 2027
    object Parent { get; } // since 2027
    ObjectTypeEnum Type { get; } // since 2027
    // Methods
    IrregularDistributionItem Add(ref int[] PatternMemberIndices, object DistributionValue); // since 2027
    void Clear(); // since 2027
    IrregularDistributionItem Item(int Index); // since 2027
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [CircularPatternFeatureDefinition](../objects/CircularPatternFeatureDefinition.md).IrregularDistributionSet, [RectangularPatternFeatureDefinition](../objects/RectangularPatternFeatureDefinition.md).XDirectionIrregularDistributionSet, [RectangularPatternFeatureDefinition](../objects/RectangularPatternFeatureDefinition.md).YDirectionIrregularDistributionSet

**Referenced types:** [IrregularDistributionItem](../objects/IrregularDistributionItem.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

