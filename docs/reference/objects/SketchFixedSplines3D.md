# SketchFixedSplines3D

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SketchFixedSplines3D`

```csharp
interface SketchFixedSplines3D
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchFixedSpline3D Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchFixedSpline3D Add(BSplineCurve SplineCurve, object StartPoint = Missing, object EndPoint = Missing);
    SketchFixedSpline3D AddByEdge(Edge TransientEdge);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sketch3D](../objects/Sketch3D.md).SketchFixedSplines3D, [Sketch3DProxy](../objects/Sketch3DProxy.md).SketchFixedSplines3D

**Referenced types:** [BSplineCurve](../objects/BSplineCurve.md), [Edge](../objects/Edge.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchFixedSpline3D](../objects/SketchFixedSpline3D.md)

