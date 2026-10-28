# MirrorFeatureDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.MirrorFeatures.Item[…].Definition`

```csharp
interface MirrorFeatureDefinition
{
    // Properties
    ObjectCollection AffectedBodies { get; set; }
    object Application { get; }
    PatternComputeTypeEnum ComputeType { get; set; }
    bool MirrorOfBody { get; }
    object MirrorPlaneEntity { get; set; }
    PartFeatureOperationEnum Operation { get; set; }
    ObjectCollection ParentFeatures { get; set; }
    bool RemoveOriginal { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    MirrorFeatureDefinition Copy();
}
```

**Returned by:** [MirrorFeature](../objects/MirrorFeature.md).Definition, [MirrorFeatureDefinition](../objects/MirrorFeatureDefinition.md).Copy, [MirrorFeatureProxy](../objects/MirrorFeatureProxy.md).Definition, [MirrorFeatures](../objects/MirrorFeatures.md).CreateDefinition

**Referenced types:** [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureOperationEnum](../enums/PartFeatureOperationEnum.md), [PatternComputeTypeEnum](../enums/PatternComputeTypeEnum.md)

