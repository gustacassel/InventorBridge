# LoftDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.LoftFeatures.Item[…].Definition`

```csharp
interface LoftDefinition
{
    // Properties
    object Centerline { get; set; }
    bool Closed { get; set; }
    object FirstSectionAngle { get; set; }
    LoftConditionEnum FirstSectionCondition { get; set; }
    bool FirstSectionDirectionReversed { get; set; }
    object FirstSectionImpact { get; set; }
    object FirstSectionTangentPlane { get; set; }
    object LastSectionAngle { get; set; }
    LoftConditionEnum LastSectionCondition { get; set; }
    bool LastSectionDirectionReversed { get; set; }
    object LastSectionImpact { get; set; }
    object LastSectionTangentPlane { get; set; }
    LoftRails LoftRails { get; }
    LoftSectionDimensions LoftSectionDimensions { get; }
    LoftTypeEnum LoftType { get; }
    MapPointCurves MapPointCurves { get; set; }
    bool MergeTangentFaces { get; set; }
    PartFeatureOperationEnum Operation { get; set; }
    ObjectCollection Sections { get; set; }
    // Methods
    LoftDefinition Copy();
}
```

**Returned by:** [LoftDefinition](../objects/LoftDefinition.md).Copy, [LoftFeature](../objects/LoftFeature.md).Definition, [LoftFeatureProxy](../objects/LoftFeatureProxy.md).Definition, [LoftFeatures](../objects/LoftFeatures.md).CreateLoftDefinition

**Referenced types:** [LoftConditionEnum](../enums/LoftConditionEnum.md), [LoftRails](../objects/LoftRails.md), [LoftSectionDimensions](../objects/LoftSectionDimensions.md), [LoftTypeEnum](../enums/LoftTypeEnum.md), [MapPointCurves](../objects/MapPointCurves.md), [ObjectCollection](../objects/ObjectCollection.md), [PartFeatureOperationEnum](../enums/PartFeatureOperationEnum.md)

