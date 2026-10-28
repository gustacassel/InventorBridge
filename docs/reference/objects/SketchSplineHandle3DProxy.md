# SketchSplineHandle3DProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [SketchSplineHandle3D](../objects/SketchSplineHandle3D.md) → [SketchLine3D](../objects/SketchLine3D.md) → [SketchEntity3D](../objects/SketchEntity3D.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SketchLines3D.Item[…] → (SketchSplineHandle3D) → (SketchSplineHandle3DProxy)`

```csharp
interface SketchSplineHandle3DProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ConstraintStatusEnum ConstraintStatus { get; }
    SketchConstraints3DEnumerator Constraints3D { get; }
    bool Construction { get; set; }
    ComponentOccurrence ContainingOccurrence { get; }
    SketchPoint3D EndSketchPoint { get; }
    SketchPoint3D FitPoint { get; }
    LineSegment Geometry { get; set; }
    bool HasReferenceComponent { get; }
    double Length { get; }
    SketchSplineHandle3D NativeObject { get; }
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

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [LineSegment](../objects/LineSegment.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch3D](../objects/Sketch3D.md), [SketchConstraints3DEnumerator](../objects/SketchConstraints3DEnumerator.md), [SketchEntities3DEnumerator](../objects/SketchEntities3DEnumerator.md), [SketchPoint3D](../objects/SketchPoint3D.md), [SketchSpline3D](../objects/SketchSpline3D.md), [SketchSplineHandle3D](../objects/SketchSplineHandle3D.md), [UnitVector](../objects/UnitVector.md)

