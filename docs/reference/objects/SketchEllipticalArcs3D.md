# SketchEllipticalArcs3D

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SketchEllipticalArcs3D`

```csharp
interface SketchEllipticalArcs3D
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchEllipticalArc3D Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sketch3D](../objects/Sketch3D.md).SketchEllipticalArcs3D, [Sketch3DProxy](../objects/Sketch3DProxy.md).SketchEllipticalArcs3D

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchEllipticalArc3D](../objects/SketchEllipticalArc3D.md)

