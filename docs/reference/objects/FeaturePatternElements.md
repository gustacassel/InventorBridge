# FeaturePatternElements

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.CircularPatternFeatures.Item[…].PatternElements`

```csharp
interface FeaturePatternElements
{
    // Properties
    object Application { get; }
    int Count { get; }
    FeaturePatternElement Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [CircularPatternFeature](../objects/CircularPatternFeature.md).PatternElements, [CircularPatternFeatureProxy](../objects/CircularPatternFeatureProxy.md).PatternElements, [MirrorFeature](../objects/MirrorFeature.md).PatternElements, [MirrorFeatureProxy](../objects/MirrorFeatureProxy.md).PatternElements, [RectangularPatternFeature](../objects/RectangularPatternFeature.md).PatternElements, [RectangularPatternFeatureProxy](../objects/RectangularPatternFeatureProxy.md).PatternElements, [SketchDrivenPatternFeature](../objects/SketchDrivenPatternFeature.md).PatternElements, [SketchDrivenPatternFeatureProxy](../objects/SketchDrivenPatternFeatureProxy.md).PatternElements

**Referenced types:** [FeaturePatternElement](../objects/FeaturePatternElement.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

