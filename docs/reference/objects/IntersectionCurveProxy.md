# IntersectionCurveProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [IntersectionCurve](../objects/IntersectionCurve.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].IntersectionCurves.Item[…] → (IntersectionCurveProxy)`

```csharp
interface IntersectionCurveProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    object EntityOne { get; set; }
    object EntityTwo { get; set; }
    string Name { get; set; }
    IntersectionCurve NativeObject { get; }
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

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [IntersectionCurve](../objects/IntersectionCurve.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch3D](../objects/Sketch3D.md), [SketchEntities3DEnumerator](../objects/SketchEntities3DEnumerator.md)

