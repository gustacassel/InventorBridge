# SketchSplines3D

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SketchSplines3D`

```csharp
interface SketchSplines3D
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchSpline3D Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchSpline3D Add(ObjectCollection FitPoints, SplineFitMethodEnum FitMethod = SplineFitMethodEnum.kSweetSplineFit);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sketch3D](../objects/Sketch3D.md).SketchSplines3D, [Sketch3DProxy](../objects/Sketch3DProxy.md).SketchSplines3D

**Referenced types:** [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchSpline3D](../objects/SketchSpline3D.md), [SplineFitMethodEnum](../enums/SplineFitMethodEnum.md)

