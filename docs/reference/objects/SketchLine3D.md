# SketchLine3D

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [SketchEntity3D](../objects/SketchEntity3D.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SketchLines3D.Item[…]`

```csharp
interface SketchLine3D
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ConstraintStatusEnum ConstraintStatus { get; }
    SketchConstraints3DEnumerator Constraints3D { get; }
    bool Construction { get; set; }
    SketchPoint3D EndSketchPoint { get; }
    LineSegment Geometry { get; set; }
    bool HasReferenceComponent { get; }
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
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

4 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BendConstraint](../objects/BendConstraint.md).LineOne, [BendConstraint](../objects/BendConstraint.md).LineTwo, [BendConstraintProxy](../objects/BendConstraintProxy.md).LineOne, [BendConstraintProxy](../objects/BendConstraintProxy.md).LineTwo, [LineLengthDimConstraint3D](../objects/LineLengthDimConstraint3D.md).Line, [LineLengthDimConstraint3DProxy](../objects/LineLengthDimConstraint3DProxy.md).Line, [MidpointConstraint3D](../objects/MidpointConstraint3D.md).Line, [MidpointConstraint3DProxy](../objects/MidpointConstraint3DProxy.md).Line, [ParallelToXAxisConstraint3D](../objects/ParallelToXAxisConstraint3D.md).Line, [ParallelToXAxisConstraint3DProxy](../objects/ParallelToXAxisConstraint3DProxy.md).Line, [ParallelToYAxisConstraint3D](../objects/ParallelToYAxisConstraint3D.md).Line, [ParallelToYAxisConstraint3DProxy](../objects/ParallelToYAxisConstraint3DProxy.md).Line, [ParallelToZAxisConstraint3D](../objects/ParallelToZAxisConstraint3D.md).Line, [ParallelToZAxisConstraint3DProxy](../objects/ParallelToZAxisConstraint3DProxy.md).Line, [SketchControlPointSpline3D](../objects/SketchControlPointSpline3D.md).ControlPolygonSide, [SketchControlPointSpline3DProxy](../objects/SketchControlPointSpline3DProxy.md).ControlPolygonSide, [SketchLine3DProxy](../objects/SketchLine3DProxy.md).NativeObject, [SketchLines3D](../objects/SketchLines3D.md).AddByTwoPoints, [SketchLines3D](../objects/SketchLines3D.md).Item, [TwoLineAngleDimConstraint3D](../objects/TwoLineAngleDimConstraint3D.md).LineOne, [TwoLineAngleDimConstraint3D](../objects/TwoLineAngleDimConstraint3D.md).LineTwo, [TwoLineAngleDimConstraint3DProxy](../objects/TwoLineAngleDimConstraint3DProxy.md).LineOne, [TwoLineAngleDimConstraint3DProxy](../objects/TwoLineAngleDimConstraint3DProxy.md).LineTwo

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [LineSegment](../objects/LineSegment.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch3D](../objects/Sketch3D.md), [SketchConstraints3DEnumerator](../objects/SketchConstraints3DEnumerator.md), [SketchEntities3DEnumerator](../objects/SketchEntities3DEnumerator.md), [SketchPoint3D](../objects/SketchPoint3D.md)

