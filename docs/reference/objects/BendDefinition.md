# BendDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.Item[…] → (BendFeature).Definition`

```csharp
interface BendDefinition
{
    // Properties
    object Application { get; }
    BendOptions BendOptions { get; set; }
    object BendRadius { get; set; }
    DoubleBendTypeEnum DoubleBendType { get; set; }
    EdgeCollection Edges { get; set; }
    bool ExtendFaces { get; set; }
    bool IsDoubleBendFirstEdgeFixed { get; set; }
    bool IsUnfoldMethodOverridden { get; set; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    UnfoldMethod UnfoldMethod { get; set; }
    // Methods
    BendDefinition Copy();
}
```

**Returned by:** [BendDefinition](../objects/BendDefinition.md).Copy, [BendFeature](../objects/BendFeature.md).Definition, [BendFeatureProxy](../objects/BendFeatureProxy.md).Definition, [BendFeatures](../objects/BendFeatures.md).CreateBendDefinition, [FaceFeatureDefinition](../objects/FaceFeatureDefinition.md).BendDefinition

**Referenced types:** [BendOptions](../objects/BendOptions.md), [DoubleBendTypeEnum](../enums/DoubleBendTypeEnum.md), [EdgeCollection](../objects/EdgeCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [UnfoldMethod](../objects/UnfoldMethod.md)

