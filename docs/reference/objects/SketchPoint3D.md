# SketchPoint3D

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [SketchEntity3D](../objects/SketchEntity3D.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SketchPoints3D.Item[…]`

```csharp
interface SketchPoint3D
{
    // Properties
    object Application { get; }
    SketchEntities3DEnumerator AttachedEntities { get; }
    AttributeSets AttributeSets { get; }
    ConstraintStatusEnum ConstraintStatus { get; }
    SketchConstraints3DEnumerator Constraints3D { get; }
    bool Construction { get; set; }
    Point Geometry { get; set; }
    bool HasReferenceComponent { get; }
    bool HoleCenter { get; set; }
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

**Returned by:** [MidpointConstraint3D](../objects/MidpointConstraint3D.md).Point, [MidpointConstraint3DProxy](../objects/MidpointConstraint3DProxy.md).Point, [OnFaceCurve](../objects/OnFaceCurve.md).EndSketchPoint, [OnFaceCurve](../objects/OnFaceCurve.md).FitPoint, [OnFaceCurve](../objects/OnFaceCurve.md).StartSketchPoint, [OnFaceCurveProxy](../objects/OnFaceCurveProxy.md).EndSketchPoint, [OnFaceCurveProxy](../objects/OnFaceCurveProxy.md).FitPoint, [OnFaceCurveProxy](../objects/OnFaceCurveProxy.md).StartSketchPoint, [PointAndPlaneDistanceDimConstraint3D](../objects/PointAndPlaneDistanceDimConstraint3D.md).Point, [PointAndPlaneDistanceDimConstraint3DProxy](../objects/PointAndPlaneDistanceDimConstraint3DProxy.md).Point, [ProfileEntity3D](../objects/ProfileEntity3D.md).EndSketchPoint, [ProfileEntity3D](../objects/ProfileEntity3D.md).StartSketchPoint, [ProfileEntity3DProxy](../objects/ProfileEntity3DProxy.md).EndSketchPoint, [ProfileEntity3DProxy](../objects/ProfileEntity3DProxy.md).StartSketchPoint, [SketchArc3D](../objects/SketchArc3D.md).EndSketchPoint, [SketchArc3D](../objects/SketchArc3D.md).StartSketchPoint, [SketchArc3DProxy](../objects/SketchArc3DProxy.md).EndSketchPoint, [SketchArc3DProxy](../objects/SketchArc3DProxy.md).StartSketchPoint, [SketchControlPointSpline3D](../objects/SketchControlPointSpline3D.md).ControlPoint, [SketchControlPointSpline3D](../objects/SketchControlPointSpline3D.md).EndSketchPoint, [SketchControlPointSpline3D](../objects/SketchControlPointSpline3D.md).StartSketchPoint, [SketchControlPointSpline3DProxy](../objects/SketchControlPointSpline3DProxy.md).ControlPoint, [SketchControlPointSpline3DProxy](../objects/SketchControlPointSpline3DProxy.md).EndSketchPoint, [SketchControlPointSpline3DProxy](../objects/SketchControlPointSpline3DProxy.md).StartSketchPoint, [SketchEllipticalArc3D](../objects/SketchEllipticalArc3D.md).EndSketchPoint, [SketchEllipticalArc3D](../objects/SketchEllipticalArc3D.md).StartSketchPoint, [SketchEllipticalArc3DProxy](../objects/SketchEllipticalArc3DProxy.md).EndSketchPoint, [SketchEllipticalArc3DProxy](../objects/SketchEllipticalArc3DProxy.md).StartSketchPoint, [SketchEquationCurve3D](../objects/SketchEquationCurve3D.md).EndSketchPoint, [SketchEquationCurve3D](../objects/SketchEquationCurve3D.md).StartSketchPoint, [SketchEquationCurve3DProxy](../objects/SketchEquationCurve3DProxy.md).EndSketchPoint, [SketchEquationCurve3DProxy](../objects/SketchEquationCurve3DProxy.md).StartSketchPoint, [SketchFixedSpline3D](../objects/SketchFixedSpline3D.md).EndSketchPoint, [SketchFixedSpline3D](../objects/SketchFixedSpline3D.md).StartSketchPoint, [SketchFixedSpline3DProxy](../objects/SketchFixedSpline3DProxy.md).EndSketchPoint, [SketchFixedSpline3DProxy](../objects/SketchFixedSpline3DProxy.md).StartSketchPoint, [SketchLine3D](../objects/SketchLine3D.md).EndSketchPoint, [SketchLine3D](../objects/SketchLine3D.md).StartSketchPoint, [SketchLine3DProxy](../objects/SketchLine3DProxy.md).EndSketchPoint, [SketchLine3DProxy](../objects/SketchLine3DProxy.md).StartSketchPoint and 17 more (see `members.tsv`)

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch3D](../objects/Sketch3D.md), [SketchConstraints3DEnumerator](../objects/SketchConstraints3DEnumerator.md), [SketchEntities3DEnumerator](../objects/SketchEntities3DEnumerator.md), [Vector](../objects/Vector.md)

