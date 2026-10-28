# CircularPatternFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.CircularPatternFeatures`

```csharp
interface CircularPatternFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    CircularPatternFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    CircularPatternFeature AddByDefinition(CircularPatternFeatureDefinition Definition);
    CircularPatternFeatureDefinition CreateDefinition(ObjectCollection ParentFeatures, object AxisEntity, bool NaturalAxisDirection, object Count, object Angle, bool FitWithinAngle = true);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Features](../objects/Features.md).CircularPatternFeatures, [FlatPatternFeatures](../objects/FlatPatternFeatures.md).CircularPatternFeatures, [PartFeatures](../objects/PartFeatures.md).CircularPatternFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).CircularPatternFeatures

**Referenced types:** [CircularPatternFeature](../objects/CircularPatternFeature.md), [CircularPatternFeatureDefinition](../objects/CircularPatternFeatureDefinition.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

