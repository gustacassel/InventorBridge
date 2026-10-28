# SketchArc3D

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [SketchEntity3D](../objects/SketchEntity3D.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SketchArcs3D.Item[…]`

```csharp
interface SketchArc3D
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    Point CenterPoint { get; }
    ConstraintStatusEnum ConstraintStatus { get; }
    SketchConstraints3DEnumerator Constraints3D { get; }
    bool Construction { get; set; }
    bool CurvatureDisplay { get; set; }
    SketchPoint3D EndSketchPoint { get; }
    Arc3d Geometry { get; set; }
    bool HasReferenceComponent { get; }
    double Length { get; }
    SketchEntities3DEnumerator OwnedBy { get; }
    Sketch3D Parent { get; }
    double Radius { get; }
    Box RangeBox { get; }
    bool Reference { get; set; }
    ReferenceComponent ReferenceComponent { get; }
    object ReferencedEntity { get; }
    double StartAngle { get; }
    SketchPoint3D StartSketchPoint { get; }
    double SweepAngle { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

4 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BendConstraint](../objects/BendConstraint.md).Arc, [BendConstraintProxy](../objects/BendConstraintProxy.md).Arc, [SketchArc3DProxy](../objects/SketchArc3DProxy.md).NativeObject, [SketchArcs3D](../objects/SketchArcs3D.md).AddAsBend, [SketchArcs3D](../objects/SketchArcs3D.md).AddByCenterStartEndPoint, [SketchArcs3D](../objects/SketchArcs3D.md).AddByCenterStartSweepAngle, [SketchArcs3D](../objects/SketchArcs3D.md).AddByThreePoints, [SketchArcs3D](../objects/SketchArcs3D.md).Item

**Referenced types:** [Arc3d](../objects/Arc3d.md), [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch3D](../objects/Sketch3D.md), [SketchConstraints3DEnumerator](../objects/SketchConstraints3DEnumerator.md), [SketchEntities3DEnumerator](../objects/SketchEntities3DEnumerator.md), [SketchPoint3D](../objects/SketchPoint3D.md)

