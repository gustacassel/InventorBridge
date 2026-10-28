# EdgeLoopProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface EdgeLoopProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    EdgeUses EdgeUses { get; }
    Edges Edges { get; }
    Face Face { get; }
    bool IsOuterEdgeLoop { get; }
    EdgeLoop NativeObject { get; }
    SurfaceBody Parent { get; }
    Box RangeBox { get; }
    int TransientKey { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [EdgeLoop](../objects/EdgeLoop.md), [EdgeUses](../objects/EdgeUses.md), [Edges](../objects/Edges.md), [Face](../objects/Face.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SurfaceBody](../objects/SurfaceBody.md)

