# IntersectionCurves

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].IntersectionCurves`

```csharp
interface IntersectionCurves
{
    // Properties
    object Application { get; }
    int Count { get; }
    IntersectionCurve Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    IntersectionCurve Add(object EntityOne, object EntityTwo);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sketch3D](../objects/Sketch3D.md).IntersectionCurves, [Sketch3DProxy](../objects/Sketch3DProxy.md).IntersectionCurves

**Referenced types:** [IntersectionCurve](../objects/IntersectionCurve.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

