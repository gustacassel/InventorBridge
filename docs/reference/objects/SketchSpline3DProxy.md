# SketchSpline3DProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [SketchSpline3D](../objects/SketchSpline3D.md) → [SketchEntity3D](../objects/SketchEntity3D.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SketchSplines3D.Item[…] → (SketchSpline3DProxy)`

```csharp
interface SketchSpline3DProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool Closed { get; set; }
    ConstraintStatusEnum ConstraintStatus { get; }
    SketchConstraints3DEnumerator Constraints3D { get; }
    bool Construction { get; set; }
    ComponentOccurrence ContainingOccurrence { get; }
    bool CurvatureDisplay { get; set; }
    SketchPoint3D EndSketchPoint { get; }
    Parameter EndTangentScale { get; }
    SplineFitMethodEnum FitMethod { get; set; }
    SketchPoint3D FitPoint[int Index] { get; }
    int FitPointCount { get; }
    BSplineCurve Geometry { get; set; }
    bool HasReferenceComponent { get; }
    double Length { get; }
    SketchSpline3D NativeObject { get; }
    SketchEntities3DEnumerator OwnedBy { get; }
    Sketch3D Parent { get; }
    Box RangeBox { get; }
    bool Reference { get; set; }
    ReferenceComponent ReferenceComponent { get; }
    object ReferencedEntity { get; }
    SketchPoint3D StartSketchPoint { get; }
    Parameter StartTangentScale { get; }
    int Tension { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void Disconnect(object FitPoint);
    SketchSplineHandle3D GetHandle(SketchPoint3D FitPoint);
    bool GetHandleStatus(SketchPoint3D FitPoint);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    SketchPoint3D InsertFitPoint(object FitPoint, int TargetIndex = 0, bool InsertBefore = true);
    void SetHandleStatus(SketchPoint3D FitPoint, bool Value);
    SketchSpline3D Split(object FitPoint);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [BSplineCurve](../objects/BSplineCurve.md), [Box](../objects/Box.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch3D](../objects/Sketch3D.md), [SketchConstraints3DEnumerator](../objects/SketchConstraints3DEnumerator.md), [SketchEntities3DEnumerator](../objects/SketchEntities3DEnumerator.md), [SketchPoint3D](../objects/SketchPoint3D.md), [SketchSpline3D](../objects/SketchSpline3D.md), [SketchSplineHandle3D](../objects/SketchSplineHandle3D.md), [SplineFitMethodEnum](../enums/SplineFitMethodEnum.md)

