# ExtrudeFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.ExtrudeFeatures`

```csharp
interface ExtrudeFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    ExtrudeFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ExtrudeFeature Add(ExtrudeDefinition Definition);
    ExtrudeDefinition CreateExtrudeDefinition(Profile Profile, PartFeatureOperationEnum Operation);
}
```

8 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Features](../objects/Features.md).ExtrudeFeatures, [FlatPatternFeatures](../objects/FlatPatternFeatures.md).ExtrudeFeatures, [PartFeatures](../objects/PartFeatures.md).ExtrudeFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).ExtrudeFeatures

**Referenced types:** [ExtrudeDefinition](../objects/ExtrudeDefinition.md), [ExtrudeFeature](../objects/ExtrudeFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureOperationEnum](../enums/PartFeatureOperationEnum.md), [Profile](../objects/Profile.md)

