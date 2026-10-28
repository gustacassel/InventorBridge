# SketchPoints3D

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SketchPoints3D`

```csharp
interface SketchPoints3D
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchPoint3D Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchPoint3D Add(Point Point, bool HoleCenter = true);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sketch3D](../objects/Sketch3D.md).SketchPoints3D, [Sketch3DProxy](../objects/Sketch3DProxy.md).SketchPoints3D

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [SketchPoint3D](../objects/SketchPoint3D.md)

