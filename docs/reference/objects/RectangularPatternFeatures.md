# RectangularPatternFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.RectangularPatternFeatures`

```csharp
interface RectangularPatternFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    RectangularPatternFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    RectangularPatternFeature AddByDefinition(RectangularPatternFeatureDefinition Definition);
    RectangularPatternFeatureDefinition CreateDefinition(ObjectCollection ParentFeatures, object XDirectionEntity, bool NaturalXDirection, object XCount, object XSpacing, PatternSpacingTypeEnum XSpacingType = PatternSpacingTypeEnum.kDefault);
}
```

4 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Features](../objects/Features.md).RectangularPatternFeatures, [FlatPatternFeatures](../objects/FlatPatternFeatures.md).RectangularPatternFeatures, [PartFeatures](../objects/PartFeatures.md).RectangularPatternFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).RectangularPatternFeatures

**Referenced types:** [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PatternSpacingTypeEnum](../enums/PatternSpacingTypeEnum.md), [RectangularPatternFeature](../objects/RectangularPatternFeature.md), [RectangularPatternFeatureDefinition](../objects/RectangularPatternFeatureDefinition.md)

