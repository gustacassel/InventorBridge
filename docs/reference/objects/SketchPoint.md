# SketchPoint

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [SketchEntity](../objects/SketchEntity.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SketchBlockDefinitions.Item[…].InsertionPoint`

```csharp
interface SketchPoint
{
    // Properties
    object Application { get; }
    SketchEntitiesEnumerator AttachedEntities { get; }
    AttributeSets AttributeSets { get; }
    bool ConnectionPoint { get; set; }
    ConstraintStatusEnum ConstraintStatus { get; }
    SketchConstraintsEnumerator Constraints { get; }
    bool Construction { get; set; }
    SketchBlock ContainingSketchBlock { get; }
    ActionTypeEnum DisabledActionTypes { get; set; }
    Point2d Geometry { get; }
    Point Geometry3d { get; }
    bool HasReferenceComponent { get; }
    bool HoleCenter { get; set; }
    bool InsertionPoint { get; set; }
    Layer Layer { get; set; }
    SketchEntitiesEnumerator OwnedBy { get; }
    Sketch Parent { get; }
    Box2d RangeBox { get; }
    bool Reference { get; set; }
    ReferenceComponent ReferenceComponent { get; }
    object ReferencedEntity { get; }
    SketchBlocksEnumerator SketchBlockPath { get; }
    bool SketchOnly { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void Merge(SketchPoint SketchPoint);
    void MoveBy(Vector2d Vector);
    void MoveTo(Point2d Point);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [HorizontalAlignConstraint](../objects/HorizontalAlignConstraint.md).PointOne, [HorizontalAlignConstraint](../objects/HorizontalAlignConstraint.md).PointTwo, [HorizontalAlignConstraintProxy](../objects/HorizontalAlignConstraintProxy.md).PointOne, [HorizontalAlignConstraintProxy](../objects/HorizontalAlignConstraintProxy.md).PointTwo, [MidpointConstraint](../objects/MidpointConstraint.md).Point, [MidpointConstraintProxy](../objects/MidpointConstraintProxy.md).Point, [ProfileEntity](../objects/ProfileEntity.md).EndSketchPoint, [ProfileEntity](../objects/ProfileEntity.md).StartSketchPoint, [ProfileEntityProxy](../objects/ProfileEntityProxy.md).EndSketchPoint, [ProfileEntityProxy](../objects/ProfileEntityProxy.md).StartSketchPoint, [SketchArc](../objects/SketchArc.md).CenterSketchPoint, [SketchArc](../objects/SketchArc.md).EndSketchPoint, [SketchArc](../objects/SketchArc.md).StartSketchPoint, [SketchArcProxy](../objects/SketchArcProxy.md).CenterSketchPoint, [SketchArcProxy](../objects/SketchArcProxy.md).EndSketchPoint, [SketchArcProxy](../objects/SketchArcProxy.md).StartSketchPoint, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).InsertionPoint, [SketchBlockDefinitionProxy](../objects/SketchBlockDefinitionProxy.md).InsertionPoint, [SketchCircle](../objects/SketchCircle.md).CenterSketchPoint, [SketchCircleProxy](../objects/SketchCircleProxy.md).CenterSketchPoint, [SketchControlPointSpline](../objects/SketchControlPointSpline.md).ControlPoint, [SketchControlPointSpline](../objects/SketchControlPointSpline.md).EndSketchPoint, [SketchControlPointSpline](../objects/SketchControlPointSpline.md).StartSketchPoint, [SketchControlPointSplineProxy](../objects/SketchControlPointSplineProxy.md).ControlPoint, [SketchControlPointSplineProxy](../objects/SketchControlPointSplineProxy.md).EndSketchPoint, [SketchControlPointSplineProxy](../objects/SketchControlPointSplineProxy.md).StartSketchPoint, [SketchEllipse](../objects/SketchEllipse.md).CenterSketchPoint, [SketchEllipseProxy](../objects/SketchEllipseProxy.md).CenterSketchPoint, [SketchEllipticalArc](../objects/SketchEllipticalArc.md).CenterSketchPoint, [SketchEllipticalArc](../objects/SketchEllipticalArc.md).EndSketchPoint, [SketchEllipticalArc](../objects/SketchEllipticalArc.md).StartSketchPoint, [SketchEllipticalArcProxy](../objects/SketchEllipticalArcProxy.md).CenterSketchPoint, [SketchEllipticalArcProxy](../objects/SketchEllipticalArcProxy.md).EndSketchPoint, [SketchEllipticalArcProxy](../objects/SketchEllipticalArcProxy.md).StartSketchPoint, [SketchEquationCurve](../objects/SketchEquationCurve.md).EndSketchPoint, [SketchEquationCurve](../objects/SketchEquationCurve.md).StartSketchPoint, [SketchEquationCurveProxy](../objects/SketchEquationCurveProxy.md).EndSketchPoint, [SketchEquationCurveProxy](../objects/SketchEquationCurveProxy.md).StartSketchPoint, [SketchFixedSpline](../objects/SketchFixedSpline.md).EndSketchPoint, [SketchFixedSpline](../objects/SketchFixedSpline.md).StartSketchPoint and 45 more (see `members.tsv`)

**Referenced types:** [ActionTypeEnum](../enums/ActionTypeEnum.md), [AttributeSets](../objects/AttributeSets.md), [Box2d](../objects/Box2d.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [Layer](../objects/Layer.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [Point2d](../objects/Point2d.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch](../objects/Sketch.md), [SketchBlock](../objects/SketchBlock.md), [SketchBlocksEnumerator](../objects/SketchBlocksEnumerator.md), [SketchConstraintsEnumerator](../objects/SketchConstraintsEnumerator.md), [SketchEntitiesEnumerator](../objects/SketchEntitiesEnumerator.md), [Vector2d](../objects/Vector2d.md)

