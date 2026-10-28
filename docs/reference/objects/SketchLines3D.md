# SketchLines3D

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SketchLines3D`

```csharp
interface SketchLines3D
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchLine3D Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchLine3D AddByTwoPoints(object StartPoint, object EndPoint, bool UseAutoBend = true, object BendRadius = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sketch3D](../objects/Sketch3D.md).SketchLines3D, [Sketch3DProxy](../objects/Sketch3DProxy.md).SketchLines3D

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchLine3D](../objects/SketchLine3D.md)

