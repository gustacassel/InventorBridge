# FoldDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.Item[…] → (FoldFeature).Definition`

```csharp
interface FoldDefinition
{
    // Properties
    object Application { get; }
    object BendAngle { get; set; }
    SketchLine BendLine { get; set; }
    BendLocationEnum BendLocation { get; set; }
    BendOptions BendOptions { get; set; }
    object BendRadius { get; set; }
    bool IsPositiveBendDirection { get; set; }
    bool IsPositiveBendSide { get; set; }
    bool IsUnfoldMethodOverridden { get; set; }
    FoldFeature Parent { get; }
    ObjectTypeEnum Type { get; }
    UnfoldMethod UnfoldMethod { get; set; }
    // Methods
    FoldDefinition Copy();
}
```

**Returned by:** [FoldDefinition](../objects/FoldDefinition.md).Copy, [FoldFeature](../objects/FoldFeature.md).Definition, [FoldFeatureProxy](../objects/FoldFeatureProxy.md).Definition, [FoldFeatures](../objects/FoldFeatures.md).CreateFoldDefinition

**Referenced types:** [BendLocationEnum](../enums/BendLocationEnum.md), [BendOptions](../objects/BendOptions.md), [FoldFeature](../objects/FoldFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchLine](../objects/SketchLine.md), [UnfoldMethod](../objects/UnfoldMethod.md)

