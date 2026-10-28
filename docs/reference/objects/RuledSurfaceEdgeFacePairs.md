# RuledSurfaceEdgeFacePairs

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.RuledSurfaceFeatures.CreateRuledSurfaceEdgeFacePairs(…)`

```csharp
interface RuledSurfaceEdgeFacePairs
{
    // Properties
    int Count { get; }
    RuledSurfaceEdgeFacePair Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    RuledSurfaceEdgeFacePair Add(Edge Edge, Face Face);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [RuledSurfaceFeatures](../objects/RuledSurfaceFeatures.md).CreateRuledSurfaceEdgeFacePairs

**Referenced types:** [Edge](../objects/Edge.md), [Face](../objects/Face.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RuledSurfaceEdgeFacePair](../objects/RuledSurfaceEdgeFacePair.md)

