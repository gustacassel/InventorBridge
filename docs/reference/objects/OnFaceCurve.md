# OnFaceCurve

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [SketchEntity3D](../objects/SketchEntity3D.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].OnFaceCurves.Item[…]`

```csharp
interface OnFaceCurve
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool Closed { get; set; }
    ConstraintStatusEnum ConstraintStatus { get; }
    SketchConstraints3DEnumerator Constraints3D { get; }
    SketchPoint3D EndSketchPoint { get; }
    NameValueMap Faces { get; }
    int FitPointCount { get; }
    string Name { get; set; }
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

**Returned by:** [OnFaceCurveProxy](../objects/OnFaceCurveProxy.md).NativeObject, [OnFaceCurves](../objects/OnFaceCurves.md).Add, [OnFaceCurves](../objects/OnFaceCurves.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch3D](../objects/Sketch3D.md), [SketchConstraints3DEnumerator](../objects/SketchConstraints3DEnumerator.md), [SketchEntities3DEnumerator](../objects/SketchEntities3DEnumerator.md), [SketchPoint3D](../objects/SketchPoint3D.md)

