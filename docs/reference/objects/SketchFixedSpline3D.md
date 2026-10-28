# SketchFixedSpline3D

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [SketchEntity3D](../objects/SketchEntity3D.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SketchFixedSplines3D.Item[…]`

```csharp
interface SketchFixedSpline3D
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool Closed { get; }
    ConstraintStatusEnum ConstraintStatus { get; }
    SketchConstraints3DEnumerator Constraints3D { get; }
    bool Construction { get; set; }
    SketchPoint3D EndSketchPoint { get; }
    BSplineCurve Geometry { get; set; }
    bool HasReferenceComponent { get; }
    bool IsDefinedByEdge { get; }
    double Length { get; }
    SketchEntities3DEnumerator OwnedBy { get; }
    Sketch3D Parent { get; }
    Box RangeBox { get; }
    bool Reference { get; set; }
    ReferenceComponent ReferenceComponent { get; }
    object ReferencedEntity { get; }
    SketchPoint3D StartSketchPoint { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchSpline3D ConvertToSpline();
    void Delete();
    void Edit(BSplineCurve SplineCurve, object StartPoint = Missing, object EndPoint = Missing);
    void EditByEdge(Edge TransientEdge);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SketchFixedSpline3DProxy](../objects/SketchFixedSpline3DProxy.md).NativeObject, [SketchFixedSplines3D](../objects/SketchFixedSplines3D.md).Add, [SketchFixedSplines3D](../objects/SketchFixedSplines3D.md).AddByEdge, [SketchFixedSplines3D](../objects/SketchFixedSplines3D.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [BSplineCurve](../objects/BSplineCurve.md), [Box](../objects/Box.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [Edge](../objects/Edge.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch3D](../objects/Sketch3D.md), [SketchConstraints3DEnumerator](../objects/SketchConstraints3DEnumerator.md), [SketchEntities3DEnumerator](../objects/SketchEntities3DEnumerator.md), [SketchPoint3D](../objects/SketchPoint3D.md), [SketchSpline3D](../objects/SketchSpline3D.md)

