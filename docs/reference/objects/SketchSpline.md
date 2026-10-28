# SketchSpline

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [SketchEntity](../objects/SketchEntity.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].SketchSplines.Item[…]`

```csharp
interface SketchSpline
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool Closed { get; set; }
    ConstraintStatusEnum ConstraintStatus { get; }
    SketchConstraintsEnumerator Constraints { get; }
    bool Construction { get; set; }
    SketchBlock ContainingSketchBlock { get; }
    bool CurvatureDisplay { get; set; }
    ActionTypeEnum DisabledActionTypes { get; set; }
    SketchPoint EndSketchPoint { get; }
    SplineFitMethodEnum FitMethod { get; set; }
    SketchPoint FitPoint[int Index] { get; }
    int FitPointCount { get; }
    BSplineCurve2d Geometry { get; }
    BSplineCurve Geometry3d { get; }
    bool HasReferenceComponent { get; }
    Layer Layer { get; set; }
    double Length { get; }
    LineDefinitionSpaceEnum LineDefinitionSpace { get; set; }
    double LineScale { get; set; }
    LineTypeEnum LineType { get; set; }
    double LineWeight { get; set; }
    Color OverrideColor { get; set; }
    SketchEntitiesEnumerator OwnedBy { get; }
    Sketch Parent { get; }
    Box2d RangeBox { get; }
    bool Reference { get; set; }
    ReferenceComponent ReferenceComponent { get; }
    object ReferencedEntity { get; }
    SketchBlocksEnumerator SketchBlockPath { get; }
    bool SketchOnly { get; set; }
    SketchPoint StartSketchPoint { get; }
    int Tension { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    SketchSplineHandle GetHandle(SketchPoint FitPoint);
    bool GetHandleStatus(SketchPoint FitPoint);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    SketchPoint InsertFitPoint(object FitPoint, int TargetIndex = 0, bool InsertBefore = true);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
    void SetHandleStatus(SketchPoint FitPoint, bool Value);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [OffsetSplineDimConstraint](../objects/OffsetSplineDimConstraint.md).Spline, [OffsetSplineDimConstraintProxy](../objects/OffsetSplineDimConstraintProxy.md).Spline, [SketchControlPointSpline](../objects/SketchControlPointSpline.md).ConvertToSpline, [SketchControlPointSplineProxy](../objects/SketchControlPointSplineProxy.md).ConvertToSpline, [SketchFixedSpline](../objects/SketchFixedSpline.md).ConvertToSpline, [SketchFixedSplineProxy](../objects/SketchFixedSplineProxy.md).ConvertToSpline, [SketchOffsetSpline](../objects/SketchOffsetSpline.md).ConvertToSpline, [SketchOffsetSpline](../objects/SketchOffsetSpline.md).OriginalSpline, [SketchOffsetSplineProxy](../objects/SketchOffsetSplineProxy.md).ConvertToSpline, [SketchOffsetSplineProxy](../objects/SketchOffsetSplineProxy.md).OriginalSpline, [SketchSplineHandle](../objects/SketchSplineHandle.md).Spline, [SketchSplineHandleProxy](../objects/SketchSplineHandleProxy.md).Spline, [SketchSplineProxy](../objects/SketchSplineProxy.md).NativeObject, [SketchSplines](../objects/SketchSplines.md).Add, [SketchSplines](../objects/SketchSplines.md).Item, [SplineFitPointConstraint](../objects/SplineFitPointConstraint.md).Spline, [SplineFitPointConstraintProxy](../objects/SplineFitPointConstraintProxy.md).Spline

**Referenced types:** [ActionTypeEnum](../enums/ActionTypeEnum.md), [AttributeSets](../objects/AttributeSets.md), [BSplineCurve](../objects/BSplineCurve.md), [BSplineCurve2d](../objects/BSplineCurve2d.md), [Box2d](../objects/Box2d.md), [Color](../objects/Color.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [Layer](../objects/Layer.md), [LineDefinitionSpaceEnum](../enums/LineDefinitionSpaceEnum.md), [LineTypeEnum](../enums/LineTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch](../objects/Sketch.md), [SketchBlock](../objects/SketchBlock.md), [SketchBlocksEnumerator](../objects/SketchBlocksEnumerator.md), [SketchConstraintsEnumerator](../objects/SketchConstraintsEnumerator.md), [SketchEntitiesEnumerator](../objects/SketchEntitiesEnumerator.md), [SketchPoint](../objects/SketchPoint.md), [SketchSplineHandle](../objects/SketchSplineHandle.md), [SplineFitMethodEnum](../enums/SplineFitMethodEnum.md)

