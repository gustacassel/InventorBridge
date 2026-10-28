# CornerOptions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.Item[…] → (ContourFlangeFeature).Definition.CornerOptions`

```csharp
interface CornerOptions
{
    // Properties
    CornerReliefPlacementEnum CornerReliefPlacement { get; set; }
    CornerReliefShapeEnum CornerReliefShape { get; set; }
    object CornerReliefSize { get; set; }
    bool IsTwoBend { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    CornerOptions Copy();
}
```

**Returned by:** [ContourFlangeDefinition](../objects/ContourFlangeDefinition.md).CornerOptions, [CornerDefinition](../objects/CornerDefinition.md).CornerOptions, [CornerOptions](../objects/CornerOptions.md).Copy, [FlangeDefinition](../objects/FlangeDefinition.md).CornerOptions

**Referenced types:** [CornerReliefPlacementEnum](../enums/CornerReliefPlacementEnum.md), [CornerReliefShapeEnum](../enums/CornerReliefShapeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

