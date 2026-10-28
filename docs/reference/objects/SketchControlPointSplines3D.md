# SketchControlPointSplines3D

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SketchControlPointSplines3D`

```csharp
interface SketchControlPointSplines3D
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchControlPointSpline3D Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchControlPointSpline3D Add(ObjectCollection ControlPoints);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sketch3D](../objects/Sketch3D.md).SketchControlPointSplines3D, [Sketch3DProxy](../objects/Sketch3DProxy.md).SketchControlPointSplines3D

**Referenced types:** [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchControlPointSpline3D](../objects/SketchControlPointSpline3D.md)

