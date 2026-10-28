# SketchControlPointSpline3DProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [SketchControlPointSpline3D](../objects/SketchControlPointSpline3D.md) → [SketchEntity3D](../objects/SketchEntity3D.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SketchControlPointSplines3D.Item[…] → (SketchControlPointSpline3DProxy)`

```csharp
interface SketchControlPointSpline3DProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ConstraintStatusEnum ConstraintStatus { get; }
    SketchConstraints3DEnumerator Constraints3D { get; }
    bool Construction { get; set; }
    ComponentOccurrence ContainingOccurrence { get; }
    SketchPoint3D ControlPoint[int Index] { get; }
    int ControlPointCount { get; }
    SketchLine3D ControlPolygonSide[int Index] { get; }
    bool CurvatureDisplay { get; set; }
    SketchPoint3D EndSketchPoint { get; }
    BSplineCurve Geometry { get; }
    bool HasReferenceComponent { get; }
    bool IsClosed { get; }
    double Length { get; }
    SketchControlPointSpline3D NativeObject { get; }
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

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [BSplineCurve](../objects/BSplineCurve.md), [Box](../objects/Box.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch3D](../objects/Sketch3D.md), [SketchConstraints3DEnumerator](../objects/SketchConstraints3DEnumerator.md), [SketchControlPointSpline3D](../objects/SketchControlPointSpline3D.md), [SketchEntities3DEnumerator](../objects/SketchEntities3DEnumerator.md), [SketchLine3D](../objects/SketchLine3D.md), [SketchPoint3D](../objects/SketchPoint3D.md), [SketchSpline3D](../objects/SketchSpline3D.md)

