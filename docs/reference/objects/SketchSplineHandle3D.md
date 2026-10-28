# SketchSplineHandle3D

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [SketchLine3D](../objects/SketchLine3D.md) → [SketchEntity3D](../objects/SketchEntity3D.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SketchLines3D.Item[…] → (SketchSplineHandle3D)`

```csharp
interface SketchSplineHandle3D
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ConstraintStatusEnum ConstraintStatus { get; }
    SketchConstraints3DEnumerator Constraints3D { get; }
    bool Construction { get; set; }
    SketchPoint3D EndSketchPoint { get; }
    SketchPoint3D FitPoint { get; }
    LineSegment Geometry { get; set; }
    bool HasReferenceComponent { get; }
    double Length { get; }
    SketchEntities3DEnumerator OwnedBy { get; }
    Sketch3D Parent { get; }
    Box RangeBox { get; }
    bool Reference { get; set; }
    ReferenceComponent ReferenceComponent { get; }
    object ReferencedEntity { get; }
    SketchSpline3D Spline { get; }
    SketchPoint3D StartSketchPoint { get; }
    UnitVector Tangent { get; set; }
    ObjectTypeEnum Type { get; }
    double Weight { get; set; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

4 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SketchSpline3D](../objects/SketchSpline3D.md).GetHandle, [SketchSpline3DProxy](../objects/SketchSpline3DProxy.md).GetHandle, [SketchSplineHandle3DProxy](../objects/SketchSplineHandle3DProxy.md).NativeObject

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [LineSegment](../objects/LineSegment.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch3D](../objects/Sketch3D.md), [SketchConstraints3DEnumerator](../objects/SketchConstraints3DEnumerator.md), [SketchEntities3DEnumerator](../objects/SketchEntities3DEnumerator.md), [SketchPoint3D](../objects/SketchPoint3D.md), [SketchSpline3D](../objects/SketchSpline3D.md), [UnitVector](../objects/UnitVector.md)

