# FaceFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features → (SheetMetalFeatures).FaceFeatures`

```csharp
interface FaceFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    FaceFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    FaceFeature Add(FaceFeatureDefinition FaceFeatureDefinition);
    FaceFeatureDefinition CreateFaceFeatureDefinition(Profile Profile);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SheetMetalFeatures](../objects/SheetMetalFeatures.md).FaceFeatures

**Referenced types:** [FaceFeature](../objects/FaceFeature.md), [FaceFeatureDefinition](../objects/FaceFeatureDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Profile](../objects/Profile.md)

