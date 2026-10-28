# FilletFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.FilletFeatures`

```csharp
interface FilletFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    FilletFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    FilletFeature Add(FilletDefinition FilletDefinition, bool AutomaticEdgeChain = true, bool SmoothRadiusTransition = true, bool RollAlongSharpEdges = false, bool RollingBallWherePossible = true, bool PreserveAllFeatures = false);
    FilletFeature AddSimple(EdgeCollection Edges, object Radius, bool AllFillets = false, bool AllRounds = false, bool AutomaticEdgeChain = true, bool RollAlongSharpEdges = false, bool RollingBallWherePossible = true, bool PreserveAllFeatures = false);
    FilletDefinition CreateFilletDefinition();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Features](../objects/Features.md).FilletFeatures, [FlatPatternFeatures](../objects/FlatPatternFeatures.md).FilletFeatures, [PartFeatures](../objects/PartFeatures.md).FilletFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).FilletFeatures

**Referenced types:** [EdgeCollection](../objects/EdgeCollection.md), [FilletDefinition](../objects/FilletDefinition.md), [FilletFeature](../objects/FilletFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

