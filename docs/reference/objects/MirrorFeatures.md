# MirrorFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.MirrorFeatures`

```csharp
interface MirrorFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    MirrorFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    MirrorFeature AddByDefinition(MirrorFeatureDefinition Definition);
    MirrorFeatureDefinition CreateDefinition(ObjectCollection ParentFeatures, object MirrorPlaneEntity, PatternComputeTypeEnum ComputeType = PatternComputeTypeEnum.kOptimizedCompute);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Features](../objects/Features.md).MirrorFeatures, [FlatPatternFeatures](../objects/FlatPatternFeatures.md).MirrorFeatures, [PartFeatures](../objects/PartFeatures.md).MirrorFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).MirrorFeatures

**Referenced types:** [MirrorFeature](../objects/MirrorFeature.md), [MirrorFeatureDefinition](../objects/MirrorFeatureDefinition.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PatternComputeTypeEnum](../enums/PatternComputeTypeEnum.md)

