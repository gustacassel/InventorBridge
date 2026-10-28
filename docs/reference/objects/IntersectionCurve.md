# IntersectionCurve

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].IntersectionCurves.Item[…]`

```csharp
interface IntersectionCurve
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    object EntityOne { get; set; }
    object EntityTwo { get; set; }
    string Name { get; set; }
    Sketch3D Parent { get; }
    SketchEntities3DEnumerator SketchEntities { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void BreakLink();
    void Delete();
    IntersectionCurve Edit(object EntityOne, object EntityTwo);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [IntersectionCurve](../objects/IntersectionCurve.md).Edit, [IntersectionCurveProxy](../objects/IntersectionCurveProxy.md).Edit, [IntersectionCurveProxy](../objects/IntersectionCurveProxy.md).NativeObject, [IntersectionCurves](../objects/IntersectionCurves.md).Add, [IntersectionCurves](../objects/IntersectionCurves.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch3D](../objects/Sketch3D.md), [SketchEntities3DEnumerator](../objects/SketchEntities3DEnumerator.md)

