# SketchControlPointSpline3D

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [SketchEntity3D](../objects/SketchEntity3D.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SketchControlPointSplines3D.Item[…]`

```csharp
interface SketchControlPointSpline3D
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ConstraintStatusEnum ConstraintStatus { get; }
    SketchConstraints3DEnumerator Constraints3D { get; }
    bool Construction { get; set; }
    SketchPoint3D ControlPoint[int Index] { get; }
    int ControlPointCount { get; }
    SketchLine3D ControlPolygonSide[int Index] { get; }
    bool CurvatureDisplay { get; set; }
    SketchPoint3D EndSketchPoint { get; }
    BSplineCurve Geometry { get; }
    bool HasReferenceComponent { get; }
    bool IsClosed { get; }
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
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    double InsertKnot(double Position);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SketchControlPointSpline3DProxy](../objects/SketchControlPointSpline3DProxy.md).NativeObject, [SketchControlPointSplines3D](../objects/SketchControlPointSplines3D.md).Add, [SketchControlPointSplines3D](../objects/SketchControlPointSplines3D.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [BSplineCurve](../objects/BSplineCurve.md), [Box](../objects/Box.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch3D](../objects/Sketch3D.md), [SketchConstraints3DEnumerator](../objects/SketchConstraints3DEnumerator.md), [SketchEntities3DEnumerator](../objects/SketchEntities3DEnumerator.md), [SketchLine3D](../objects/SketchLine3D.md), [SketchPoint3D](../objects/SketchPoint3D.md), [SketchSpline3D](../objects/SketchSpline3D.md)

