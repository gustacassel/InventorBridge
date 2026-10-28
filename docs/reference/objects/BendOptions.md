# BendOptions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.Item[…] → (BendFeature).Definition.BendOptions`

```csharp
interface BendOptions
{
    // Properties
    object BendReliefDepth { get; set; }
    BendReliefShapeEnum BendReliefShape { get; set; }
    object BendReliefWidth { get; set; }
    BendTransitionEnum BendTransition { get; set; }
    object BendTransitionArcRadius { get; set; }
    object MinimumRemnant { get; set; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    BendOptions Copy();
}
```

**Returned by:** [BendDefinition](../objects/BendDefinition.md).BendOptions, [BendOptions](../objects/BendOptions.md).Copy, [ContourFlangeDefinition](../objects/ContourFlangeDefinition.md).BendOptions, [CornerDefinition](../objects/CornerDefinition.md).BendOptions, [FlangeDefinition](../objects/FlangeDefinition.md).BendOptions, [FoldDefinition](../objects/FoldDefinition.md).BendOptions, [HemDefinition](../objects/HemDefinition.md).BendOptions

**Referenced types:** [BendReliefShapeEnum](../enums/BendReliefShapeEnum.md), [BendTransitionEnum](../enums/BendTransitionEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

