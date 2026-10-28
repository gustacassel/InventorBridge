# HelicalCurve

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [SketchEntity3D](../objects/SketchEntity3D.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].HelicalCurves.Item[…]`

```csharp
interface HelicalCurve
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ConstraintStatusEnum ConstraintStatus { get; }
    SketchConstraints3DEnumerator Constraints3D { get; }
    bool Construction { get; set; }
    HelicalCurveDefinition Definition { get; set; }
    bool HasReferenceComponent { get; }
    string Name { get; set; }
    SketchEntities3DEnumerator OwnedBy { get; }
    Sketch3D Parent { get; }
    Box RangeBox { get; }
    bool Reference { get; set; }
    ReferenceComponent ReferenceComponent { get; }
    object ReferencedEntity { get; }
    SketchEntities3DEnumerator SketchEntities { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [HelicalCurveConstantShapeDefinition](../objects/HelicalCurveConstantShapeDefinition.md).Parent, [HelicalCurveDefinition](../objects/HelicalCurveDefinition.md).Parent, [HelicalCurveProxy](../objects/HelicalCurveProxy.md).NativeObject, [HelicalCurveVariableShapeDefinition](../objects/HelicalCurveVariableShapeDefinition.md).Parent, [HelicalCurves](../objects/HelicalCurves.md).Add, [HelicalCurves](../objects/HelicalCurves.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [HelicalCurveDefinition](../objects/HelicalCurveDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch3D](../objects/Sketch3D.md), [SketchConstraints3DEnumerator](../objects/SketchConstraints3DEnumerator.md), [SketchEntities3DEnumerator](../objects/SketchEntities3DEnumerator.md)

