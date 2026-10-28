# EdgeUses

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SurfaceBodies.Item[…].Wires.Item[…].EdgeUses`

```csharp
interface EdgeUses
{
    // Properties
    int Count { get; }
    EdgeUse Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Edge](../objects/Edge.md).EdgeUses, [EdgeLoop](../objects/EdgeLoop.md).EdgeUses, [EdgeLoopProxy](../objects/EdgeLoopProxy.md).EdgeUses, [EdgeProxy](../objects/EdgeProxy.md).EdgeUses, [Wire](../objects/Wire.md).EdgeUses

**Referenced types:** [EdgeUse](../objects/EdgeUse.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

