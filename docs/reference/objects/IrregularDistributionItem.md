# IrregularDistributionItem

Inventor API object · versions: 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.CircularPatternFeatures.Item[…].Definition.IrregularDistributionSet.Item(…)`

```csharp
interface IrregularDistributionItem
{
    // Properties
    object Application { get; } // since 2027
    object DistributionValue { get; set; } // since 2027
    object Parent { get; } // since 2027
    int[] PatternMemberIndices { get; set; } // since 2027
    ObjectTypeEnum Type { get; } // since 2027
    // Methods
    void Delete(); // since 2027
}
```

**Returned by:** [IrregularDistributionSet](../objects/IrregularDistributionSet.md).Add, [IrregularDistributionSet](../objects/IrregularDistributionSet.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

