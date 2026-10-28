# ChamferFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.ChamferFeatures`

```csharp
interface ChamferFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    ChamferFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ChamferFeature AddUsingDistance(EdgeCollection Edges, object Distance, bool AutomaticEdgeChain = true, bool CornerSetback = true, bool PreserveAllFeatures = false);
    ChamferFeature AddUsingDistanceAndAngle(EdgeCollection Edges, Face Face, object Distance, object Angle, bool AutomaticEdgeChain = true, bool PreserveAllFeatures = false);
    ChamferFeature AddUsingTwoDistances(EdgeCollection Edges, Face Face, object DistanceOne, object DistanceTwo, bool AutomaticEdgeChain = true, bool PreserveAllFeatures = false);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Features](../objects/Features.md).ChamferFeatures, [FlatPatternFeatures](../objects/FlatPatternFeatures.md).ChamferFeatures, [PartFeatures](../objects/PartFeatures.md).ChamferFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).ChamferFeatures

**Referenced types:** [ChamferFeature](../objects/ChamferFeature.md), [EdgeCollection](../objects/EdgeCollection.md), [Face](../objects/Face.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

