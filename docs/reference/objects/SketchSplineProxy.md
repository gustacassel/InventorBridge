# SketchSplineProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [SketchSpline](../objects/SketchSpline.md) → [SketchEntity](../objects/SketchEntity.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].SketchSplines.Item[…] → (SketchSplineProxy)`

```csharp
interface SketchSplineProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool Closed { get; set; }
    ConstraintStatusEnum ConstraintStatus { get; }
    SketchConstraintsEnumerator Constraints { get; }
    bool Construction { get; set; }
    ComponentOccurrence ContainingOccurrence { get; }
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
    SketchSpline NativeObject { get; }
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

**Referenced types:** [ActionTypeEnum](../enums/ActionTypeEnum.md), [AttributeSets](../objects/AttributeSets.md), [BSplineCurve](../objects/BSplineCurve.md), [BSplineCurve2d](../objects/BSplineCurve2d.md), [Box2d](../objects/Box2d.md), [Color](../objects/Color.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [Layer](../objects/Layer.md), [LineDefinitionSpaceEnum](../enums/LineDefinitionSpaceEnum.md), [LineTypeEnum](../enums/LineTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch](../objects/Sketch.md), [SketchBlock](../objects/SketchBlock.md), [SketchBlocksEnumerator](../objects/SketchBlocksEnumerator.md), [SketchConstraintsEnumerator](../objects/SketchConstraintsEnumerator.md), [SketchEntitiesEnumerator](../objects/SketchEntitiesEnumerator.md), [SketchPoint](../objects/SketchPoint.md), [SketchSpline](../objects/SketchSpline.md), [SketchSplineHandle](../objects/SketchSplineHandle.md), [SplineFitMethodEnum](../enums/SplineFitMethodEnum.md)

