# Wire

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SurfaceBodies.Item[…].Wires.Item[…]`

```csharp
interface Wire
{
    // Properties
    object Application { get; }
    EdgeUses EdgeUses { get; }
    Edges Edges { get; }
    bool IsPlanar { get; }
    SurfaceBody Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    Wires OffsetPlanarWire(UnitVector Normal, double Distance, OffsetCornerClosureTypeEnum CornerClosureType);
}
```

**Returned by:** [Edge](../objects/Edge.md).Wire, [EdgeProxy](../objects/EdgeProxy.md).Wire, [EdgeUse](../objects/EdgeUse.md).Wire, [EdgeUseProxy](../objects/EdgeUseProxy.md).Wire, [Wires](../objects/Wires.md).Item

**Referenced types:** [EdgeUses](../objects/EdgeUses.md), [Edges](../objects/Edges.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [OffsetCornerClosureTypeEnum](../enums/OffsetCornerClosureTypeEnum.md), [SurfaceBody](../objects/SurfaceBody.md), [UnitVector](../objects/UnitVector.md), [Wires](../objects/Wires.md)

