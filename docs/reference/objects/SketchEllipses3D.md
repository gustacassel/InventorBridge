# SketchEllipses3D

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SketchEllipses3D`

```csharp
interface SketchEllipses3D
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchEllipse3D Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sketch3D](../objects/Sketch3D.md).SketchEllipses3D, [Sketch3DProxy](../objects/Sketch3DProxy.md).SketchEllipses3D

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchEllipse3D](../objects/SketchEllipse3D.md)

