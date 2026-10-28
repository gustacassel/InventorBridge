# NonParametricBaseFeatureDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.NonParametricBaseFeatures.CreateDefinition(…)`

```csharp
interface NonParametricBaseFeatureDefinition
{
    // Properties
    object Application { get; }
    ObjectCollection BRepEntities { get; set; }
    bool DeleteOriginal { get; set; }
    bool IsAssociative { get; set; }
    BaseFeatureOutputTypeEnum OutputType { get; set; }
    ComponentOccurrence TargetOccurrence { get; set; }
}
```

**Returned by:** [NonParametricBaseFeatures](../objects/NonParametricBaseFeatures.md).CreateDefinition

**Referenced types:** [BaseFeatureOutputTypeEnum](../enums/BaseFeatureOutputTypeEnum.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectCollection](../objects/ObjectCollection.md)

