# ReplaceFaceDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.ReplaceFaceFeatures.Item[…].Definition`

```csharp
interface ReplaceFaceDefinition
{
    // Properties
    object Application { get; }
    FaceCollection ExistingFaces { get; set; }
    ObjectCollection NewFaces { get; set; }
    ReplaceFaceFeature Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ReplaceFaceDefinition Copy();
}
```

**Returned by:** [ReplaceFaceDefinition](../objects/ReplaceFaceDefinition.md).Copy, [ReplaceFaceFeature](../objects/ReplaceFaceFeature.md).Definition, [ReplaceFaceFeatures](../objects/ReplaceFaceFeatures.md).CreateDefinition

**Referenced types:** [FaceCollection](../objects/FaceCollection.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReplaceFaceFeature](../objects/ReplaceFaceFeature.md)

