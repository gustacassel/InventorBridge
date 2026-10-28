# EdgeUse

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SurfaceBodies.Item[…].Wires.Item[…].EdgeUses.Item[…]`

```csharp
interface EdgeUse
{
    // Properties
    object Application { get; }
    Curve2dTypeEnum CurveType { get; }
    Edge Edge { get; }
    EdgeLoop EdgeLoop { get; }
    Curve2dEvaluator Evaluator { get; }
    object Geometry { get; }
    int GeometryForm { get; }
    bool IsOpposedToEdge { get; }
    bool IsParamReversed { get; }
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

**Returned by:** [EdgeUse](../objects/EdgeUse.md).Next, [EdgeUse](../objects/EdgeUse.md).Partner, [EdgeUse](../objects/EdgeUse.md).Previous, [EdgeUseProxy](../objects/EdgeUseProxy.md).NativeObject, [EdgeUseProxy](../objects/EdgeUseProxy.md).Next, [EdgeUseProxy](../objects/EdgeUseProxy.md).Partner, [EdgeUseProxy](../objects/EdgeUseProxy.md).Previous, [EdgeUses](../objects/EdgeUses.md).Item

**Referenced types:** [Curve2dEvaluator](../objects/Curve2dEvaluator.md), [Curve2dTypeEnum](../enums/Curve2dTypeEnum.md), [Edge](../objects/Edge.md), [EdgeLoop](../objects/EdgeLoop.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SurfaceBody](../objects/SurfaceBody.md), [Wire](../objects/Wire.md)

