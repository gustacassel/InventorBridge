# FaceFeatureDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.Item[…] → (FaceFeature).Definition`

```csharp
interface FaceFeatureDefinition
{
    // Properties
    ObjectCollection AffectedBodies { get; set; }
    object Application { get; }
    BendDefinition BendDefinition { get; set; }
    PartFeatureExtentDirectionEnum Direction { get; set; }
    PartFeatureOperationEnum Operation { get; set; }
    FaceFeature Parent { get; }
    Profile Profile { get; set; }
    SheetMetalStyle SheetMetalRule { get; set; }
    ObjectTypeEnum Type { get; }
    bool UseDefaultSheetMetalRule { get; set; }
}
```

**Returned by:** [FaceFeature](../objects/FaceFeature.md).Definition, [FaceFeatureProxy](../objects/FaceFeatureProxy.md).Definition, [FaceFeatures](../objects/FaceFeatures.md).CreateFaceFeatureDefinition

**Referenced types:** [BendDefinition](../objects/BendDefinition.md), [FaceFeature](../objects/FaceFeature.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureExtentDirectionEnum](../enums/PartFeatureExtentDirectionEnum.md), [PartFeatureOperationEnum](../enums/PartFeatureOperationEnum.md), [Profile](../objects/Profile.md), [SheetMetalStyle](../objects/SheetMetalStyle.md)

