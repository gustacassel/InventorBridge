# CornerDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.Item[…] → (CornerFeature).Definition`

```csharp
interface CornerDefinition
{
    // Properties
    bool AlignedCornerExtension { get; set; }
    object Application { get; }
    BendOptions BendOptions { get; set; }
    CornerDefinitionTypeEnum CornerDefinitionType { get; set; }
    CornerOptions CornerOptions { get; set; }
    CornerTypeEnum CornerType { get; set; }
    EdgeCollection Edges { get; set; }
    object GapWidth { get; set; }
    bool IsRippedCorner { get; set; }
    CornerFeature Parent { get; }
    double PercentOverlap { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    CornerDefinition Copy();
}
```

**Returned by:** [CornerDefinition](../objects/CornerDefinition.md).Copy, [CornerFeature](../objects/CornerFeature.md).Definition, [CornerFeatureProxy](../objects/CornerFeatureProxy.md).Definition, [CornerFeatures](../objects/CornerFeatures.md).CreateCornerDefinition

**Referenced types:** [BendOptions](../objects/BendOptions.md), [CornerDefinitionTypeEnum](../enums/CornerDefinitionTypeEnum.md), [CornerFeature](../objects/CornerFeature.md), [CornerOptions](../objects/CornerOptions.md), [CornerTypeEnum](../enums/CornerTypeEnum.md), [EdgeCollection](../objects/EdgeCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

