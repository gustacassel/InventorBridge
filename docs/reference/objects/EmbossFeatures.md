# EmbossFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.EmbossFeatures`

```csharp
interface EmbossFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    EmbossFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    EmbossFeature AddEmbossEngraveFromPlane(Profile Profile, object Taper, PartFeatureExtentDirectionEnum ExtentDirection, object TopFaceColor = Missing);
    EmbossFeature AddEmbossFromFace(Profile Profile, object Distance, PartFeatureExtentDirectionEnum ExtentDirection, object TopFaceColor = Missing, object WrapFace = Missing);
    EmbossFeature AddEngraveFromFace(Profile Profile, object Distance, PartFeatureExtentDirectionEnum ExtentDirection, object TopFaceColor = Missing, object WrapFace = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FlatPatternFeatures](../objects/FlatPatternFeatures.md).EmbossFeatures, [PartFeatures](../objects/PartFeatures.md).EmbossFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).EmbossFeatures

**Referenced types:** [EmbossFeature](../objects/EmbossFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureExtentDirectionEnum](../enums/PartFeatureExtentDirectionEnum.md), [Profile](../objects/Profile.md)

