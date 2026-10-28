# RuledSurfaceEdgeFacePair

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.RuledSurfaceFeatures.CreateRuledSurfaceEdgeFacePairs(…).Item[…]`

```csharp
interface RuledSurfaceEdgeFacePair
{
    // Properties
    object Application { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetData(out Edge Edge, out Face Face);
    void SetData(Edge Edge, Face Face);
}
```

**Returned by:** [RuledSurfaceEdgeFacePairs](../objects/RuledSurfaceEdgeFacePairs.md).Add, [RuledSurfaceEdgeFacePairs](../objects/RuledSurfaceEdgeFacePairs.md).Item

**Referenced types:** [Edge](../objects/Edge.md), [Face](../objects/Face.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

