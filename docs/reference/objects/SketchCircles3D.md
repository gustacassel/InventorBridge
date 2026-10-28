# SketchCircles3D

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SketchCircles3D`

```csharp
interface SketchCircles3D
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchCircle3D Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchCircle3D AddByCenterRadius(object CenterPoint, UnitVector Normal, double Radius);
    SketchCircle3D AddByThreePoints(object StartPoint, object MidPoint, object EndPoint);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sketch3D](../objects/Sketch3D.md).SketchCircles3D, [Sketch3DProxy](../objects/Sketch3DProxy.md).SketchCircles3D

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchCircle3D](../objects/SketchCircle3D.md), [UnitVector](../objects/UnitVector.md)

