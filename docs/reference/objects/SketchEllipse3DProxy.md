# SketchEllipse3DProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [SketchEllipse3D](../objects/SketchEllipse3D.md) → [SketchEntity3D](../objects/SketchEntity3D.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SketchEllipses3D.Item[…] → (SketchEllipse3DProxy)`

```csharp
interface SketchEllipse3DProxy
{
    // Properties
    object Application { get; }
    double Area { get; }
    AttributeSets AttributeSets { get; }
    Point CenterPoint { get; }
    ConstraintStatusEnum ConstraintStatus { get; }
    SketchConstraints3DEnumerator Constraints3D { get; }
    bool Construction { get; set; }
    ComponentOccurrence ContainingOccurrence { get; }
    bool CurvatureDisplay { get; set; }
    EllipseFull Geometry { get; set; }
    bool HasReferenceComponent { get; }
    double Length { get; }
    UnitVector MajorAxisVector { get; }
    double MajorRadius { get; }
    double MinorRadius { get; }
    SketchEllipse3D NativeObject { get; }
    SketchEntities3DEnumerator OwnedBy { get; }
    Sketch3D Parent { get; }
    Box RangeBox { get; }
    bool Reference { get; set; }
    ReferenceComponent ReferenceComponent { get; }
    object ReferencedEntity { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [EllipseFull](../objects/EllipseFull.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch3D](../objects/Sketch3D.md), [SketchConstraints3DEnumerator](../objects/SketchConstraints3DEnumerator.md), [SketchEllipse3D](../objects/SketchEllipse3D.md), [SketchEntities3DEnumerator](../objects/SketchEntities3DEnumerator.md), [UnitVector](../objects/UnitVector.md)

