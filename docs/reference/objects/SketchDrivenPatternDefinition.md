# SketchDrivenPatternDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.SketchDrivenPatternFeatures.Item[…].Definition`

```csharp
interface SketchDrivenPatternDefinition
{
    // Properties
    ObjectCollection AffectedBodies { get; set; }
    ObjectCollection AffectedOccurrences { get; set; }
    object Application { get; }
    object BasePoint { get; set; }
    PatternComputeTypeEnum ComputeType { get; set; }
    PartFeatureOperationEnum Operation { get; set; }
    ObjectCollection ParentFeatures { get; set; }
    bool PatternOfBody { get; }
    FaceCollection ReferenceFaces { get; set; }
    object Sketch { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchDrivenPatternDefinition Copy();
}
```

**Returned by:** [SketchDrivenPatternDefinition](../objects/SketchDrivenPatternDefinition.md).Copy, [SketchDrivenPatternFeature](../objects/SketchDrivenPatternFeature.md).Definition, [SketchDrivenPatternFeatureProxy](../objects/SketchDrivenPatternFeatureProxy.md).Definition, [SketchDrivenPatternFeatures](../objects/SketchDrivenPatternFeatures.md).CreateDefinition

**Referenced types:** [FaceCollection](../objects/FaceCollection.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureOperationEnum](../enums/PartFeatureOperationEnum.md), [PatternComputeTypeEnum](../enums/PatternComputeTypeEnum.md)

