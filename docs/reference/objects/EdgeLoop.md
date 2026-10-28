# EdgeLoop

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SurfaceBodies.Item[…].Faces.Item[…].EdgeLoops.Item[…]`

```csharp
interface EdgeLoop
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    EdgeUses EdgeUses { get; }
    Edges Edges { get; }
    Face Face { get; }
    bool IsOuterEdgeLoop { get; }
    SurfaceBody Parent { get; }
    Box RangeBox { get; }
    int TransientKey { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [EdgeLoopProxy](../objects/EdgeLoopProxy.md).NativeObject, [EdgeLoops](../objects/EdgeLoops.md).Item, [EdgeUse](../objects/EdgeUse.md).EdgeLoop, [EdgeUseProxy](../objects/EdgeUseProxy.md).EdgeLoop

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [EdgeUses](../objects/EdgeUses.md), [Edges](../objects/Edges.md), [Face](../objects/Face.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SurfaceBody](../objects/SurfaceBody.md)

