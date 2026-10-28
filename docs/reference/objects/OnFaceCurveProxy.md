# OnFaceCurveProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [OnFaceCurve](../objects/OnFaceCurve.md) → [SketchEntity3D](../objects/SketchEntity3D.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].OnFaceCurves.Item[…] → (OnFaceCurveProxy)`

```csharp
interface OnFaceCurveProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool Closed { get; set; }
    ConstraintStatusEnum ConstraintStatus { get; }
    SketchConstraints3DEnumerator Constraints3D { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    SketchPoint3D EndSketchPoint { get; }
    NameValueMap Faces { get; }
    int FitPointCount { get; }
    string Name { get; set; }
    OnFaceCurve NativeObject { get; }
    Sketch3D Parent { get; }
    Box RangeBox { get; }
    SketchEntities3DEnumerator SketchEntities { get; }
    SketchPoint3D StartSketchPoint { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void BreakLink();
    void Delete();
    void Edit(NameValueMap Faces, NameValueMap FitPoints);
    SketchPoint3D FitPoint(int Index);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [OnFaceCurve](../objects/OnFaceCurve.md), [Sketch3D](../objects/Sketch3D.md), [SketchConstraints3DEnumerator](../objects/SketchConstraints3DEnumerator.md), [SketchEntities3DEnumerator](../objects/SketchEntities3DEnumerator.md), [SketchPoint3D](../objects/SketchPoint3D.md)

