# SketchDrivenPatternFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.SketchDrivenPatternFeatures`

```csharp
interface SketchDrivenPatternFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchDrivenPatternFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchDrivenPatternFeature Add(SketchDrivenPatternDefinition Definition);
    SketchDrivenPatternDefinition CreateDefinition(ObjectCollection ParentFeatures, object Sketch, object BasePoint = Missing, object ReferenceFaces = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Features](../objects/Features.md).SketchDrivenPatternFeatures, [FlatPatternFeatures](../objects/FlatPatternFeatures.md).SketchDrivenPatternFeatures, [PartFeatures](../objects/PartFeatures.md).SketchDrivenPatternFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).SketchDrivenPatternFeatures

**Referenced types:** [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchDrivenPatternDefinition](../objects/SketchDrivenPatternDefinition.md), [SketchDrivenPatternFeature](../objects/SketchDrivenPatternFeature.md)

