# LoftedFlangeDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.BoundaryPatchFeatures.Item[…] → (LoftedFlangeFeatureProxy).Definition`

```csharp
interface LoftedFlangeDefinition
{
    // Properties
    ObjectCollection AffectedBodies { get; set; }
    object Application { get; }
    object BendRadius { get; set; }
    bool Converge { get; set; }
    PartFeatureExtentDirectionEnum ExtentDirection { get; set; }
    Parameter FacetTolerance { get; }
    bool IsUnfoldMethodOverridden { get; set; }
    PartFeatureOperationEnum Operation { get; set; }
    LoftedFlangeOutputTypeEnum OutputType { get; }
    LoftedFlangeFeature Parent { get; }
    Path ProfileOne { get; set; }
    Path ProfileTwo { get; set; }
    SheetMetalStyle SheetMetalRule { get; set; }
    ObjectTypeEnum Type { get; }
    UnfoldMethod UnfoldMethod { get; set; }
    bool UseDefaultSheetMetalRule { get; set; }
    // Methods
    LoftedFlangeDefinition Copy();
    void SetOutputType(LoftedFlangeOutputTypeEnum OutputType, object FacetTolerance = Missing);
}
```

**Returned by:** [LoftedFlangeDefinition](../objects/LoftedFlangeDefinition.md).Copy, [LoftedFlangeFeature](../objects/LoftedFlangeFeature.md).Definition, [LoftedFlangeFeatureProxy](../objects/LoftedFlangeFeatureProxy.md).Definition, [LoftedFlangeFeatures](../objects/LoftedFlangeFeatures.md).CreateLoftedFlangeDefinition

**Referenced types:** [LoftedFlangeFeature](../objects/LoftedFlangeFeature.md), [LoftedFlangeOutputTypeEnum](../enums/LoftedFlangeOutputTypeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [PartFeatureExtentDirectionEnum](../enums/PartFeatureExtentDirectionEnum.md), [PartFeatureOperationEnum](../enums/PartFeatureOperationEnum.md), [Path](../objects/Path.md), [SheetMetalStyle](../objects/SheetMetalStyle.md), [UnfoldMethod](../objects/UnfoldMethod.md)

