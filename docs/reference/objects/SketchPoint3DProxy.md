# SketchPoint3DProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [SketchPoint3D](../objects/SketchPoint3D.md) → [SketchEntity3D](../objects/SketchEntity3D.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SketchPoints3D.Item[…] → (SketchPoint3DProxy)`

```csharp
interface SketchPoint3DProxy
{
    // Properties
    object Application { get; }
    SketchEntities3DEnumerator AttachedEntities { get; }
    AttributeSets AttributeSets { get; }
    ConstraintStatusEnum ConstraintStatus { get; }
    SketchConstraints3DEnumerator Constraints3D { get; }
    bool Construction { get; set; }
    ComponentOccurrence ContainingOccurrence { get; }
    Point Geometry { get; set; }
    bool HasReferenceComponent { get; }
    bool HoleCenter { get; set; }
    SketchPoint3D NativeObject { get; }
    SketchEntities3DEnumerator OwnedBy { get; }
    Sketch3D Parent { get; }
    Box RangeBox { get; }
    bool Reference { get; set; }
    ReferenceComponent ReferenceComponent { get; }
    object ReferencedEntity { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void ConnectTo(object ConstrainingPoint);
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void MoveBy(Vector Vector);
    void MoveTo(Point Point);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch3D](../objects/Sketch3D.md), [SketchConstraints3DEnumerator](../objects/SketchConstraints3DEnumerator.md), [SketchEntities3DEnumerator](../objects/SketchEntities3DEnumerator.md), [SketchPoint3D](../objects/SketchPoint3D.md), [Vector](../objects/Vector.md)

