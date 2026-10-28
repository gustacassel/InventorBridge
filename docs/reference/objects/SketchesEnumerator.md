# SketchesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.iFeatures.Item[…].Sketches`

```csharp
interface SketchesEnumerator
{
    // Properties
    int Count { get; }
    Sketch Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DerivedPartComponent](../objects/DerivedPartComponent.md).Sketches, [DerivedPartComponentProxy](../objects/DerivedPartComponentProxy.md).Sketches, [RefoldFeature](../objects/RefoldFeature.md).InputSketches, [RefoldFeature](../objects/RefoldFeature.md).ResultSketches, [RefoldFeatureProxy](../objects/RefoldFeatureProxy.md).InputSketches, [RefoldFeatureProxy](../objects/RefoldFeatureProxy.md).ResultSketches, [UnfoldFeature](../objects/UnfoldFeature.md).InputSketches, [UnfoldFeature](../objects/UnfoldFeature.md).ResultSketches, [UnfoldFeatureProxy](../objects/UnfoldFeatureProxy.md).InputSketches, [UnfoldFeatureProxy](../objects/UnfoldFeatureProxy.md).ResultSketches, [iFeature](../objects/iFeature.md).Sketches, [iFeatureProxy](../objects/iFeatureProxy.md).Sketches

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch](../objects/Sketch.md)

