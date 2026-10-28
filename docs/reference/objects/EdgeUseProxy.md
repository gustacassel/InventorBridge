# EdgeUseProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [EdgeUse](../objects/EdgeUse.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SurfaceBodies.Item[…].Wires.Item[…].EdgeUses.Item[…] → (EdgeUseProxy)`

```csharp
interface EdgeUseProxy
{
    // Properties
    object Application { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    Curve2dTypeEnum CurveType { get; }
    Edge Edge { get; }
    EdgeLoop EdgeLoop { get; }
    Curve2dEvaluator Evaluator { get; }
    object Geometry { get; }
    int GeometryForm { get; }
    bool IsOpposedToEdge { get; }
    bool IsParamReversed { get; }
    EdgeUse NativeObject { get; }
    EdgeUse Next { get; }
    SurfaceBody Parent { get; }
    EdgeUse Partner { get; }
    EdgeUse Previous { get; }
    int TransientKey { get; }
    ObjectTypeEnum Type { get; }
    Wire Wire { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [ComponentOccurrence](../objects/ComponentOccurrence.md), [Curve2dEvaluator](../objects/Curve2dEvaluator.md), [Curve2dTypeEnum](../enums/Curve2dTypeEnum.md), [Edge](../objects/Edge.md), [EdgeLoop](../objects/EdgeLoop.md), [EdgeUse](../objects/EdgeUse.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SurfaceBody](../objects/SurfaceBody.md), [Wire](../objects/Wire.md)

