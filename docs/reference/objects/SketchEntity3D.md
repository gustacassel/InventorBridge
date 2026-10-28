# SketchEntity3D

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SketchEntities3D.Item[…]`

```csharp
interface SketchEntity3D
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ConstraintStatusEnum ConstraintStatus { get; }
    SketchConstraints3DEnumerator Constraints3D { get; }
    bool Construction { get; set; }
    bool HasReferenceComponent { get; }
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

**Returned by:** [CustomConstraint3D](../objects/CustomConstraint3D.md).Entity, [CustomConstraint3DProxy](../objects/CustomConstraint3DProxy.md).Entity, [EqualConstraint3D](../objects/EqualConstraint3D.md).EntityOne, [EqualConstraint3D](../objects/EqualConstraint3D.md).EntityTwo, [EqualConstraint3DProxy](../objects/EqualConstraint3DProxy.md).EntityOne, [EqualConstraint3DProxy](../objects/EqualConstraint3DProxy.md).EntityTwo, [OnFaceConstraint3D](../objects/OnFaceConstraint3D.md).Entity, [OnFaceConstraint3DProxy](../objects/OnFaceConstraint3DProxy.md).Entity, [ParallelToXYPlaneConstraint3D](../objects/ParallelToXYPlaneConstraint3D.md).Entity, [ParallelToXYPlaneConstraint3DProxy](../objects/ParallelToXYPlaneConstraint3DProxy.md).Entity, [ParallelToXZPlaneConstraint3D](../objects/ParallelToXZPlaneConstraint3D.md).Entity, [ParallelToXZPlaneConstraint3DProxy](../objects/ParallelToXZPlaneConstraint3DProxy.md).Entity, [ParallelToYZPlaneConstraint3D](../objects/ParallelToYZPlaneConstraint3D.md).Entity, [ParallelToYZPlaneConstraint3DProxy](../objects/ParallelToYZPlaneConstraint3DProxy.md).Entity, [ProfileEntity3D](../objects/ProfileEntity3D.md).SketchEntity, [ProfileEntity3DProxy](../objects/ProfileEntity3DProxy.md).SketchEntity, [RadiusDimConstraint3D](../objects/RadiusDimConstraint3D.md).Entity, [RadiusDimConstraint3DProxy](../objects/RadiusDimConstraint3DProxy.md).Entity, [Sketch3D](../objects/Sketch3D.md).Include, [Sketch3DProxy](../objects/Sketch3DProxy.md).Include, [SketchEntities3DEnumerator](../objects/SketchEntities3DEnumerator.md).Item, [SmoothConstraint3D](../objects/SmoothConstraint3D.md).EntityOne, [SmoothConstraint3D](../objects/SmoothConstraint3D.md).EntityTwo, [SmoothConstraint3DProxy](../objects/SmoothConstraint3DProxy.md).EntityOne, [SmoothConstraint3DProxy](../objects/SmoothConstraint3DProxy.md).EntityTwo, [TangentConstraint3D](../objects/TangentConstraint3D.md).EntityOne, [TangentConstraint3D](../objects/TangentConstraint3D.md).EntityTwo, [TangentConstraint3DProxy](../objects/TangentConstraint3DProxy.md).EntityOne, [TangentConstraint3DProxy](../objects/TangentConstraint3DProxy.md).EntityTwo

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch3D](../objects/Sketch3D.md), [SketchConstraints3DEnumerator](../objects/SketchConstraints3DEnumerator.md), [SketchEntities3DEnumerator](../objects/SketchEntities3DEnumerator.md)

