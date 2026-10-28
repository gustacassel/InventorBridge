# SketchSplineHandle

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [SketchLine](../objects/SketchLine.md) → [SketchEntity](../objects/SketchEntity.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].SketchLines.Item[…] → (SketchSplineHandle)`

```csharp
interface SketchSplineHandle
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool Centerline { get; set; }
    ConstraintStatusEnum ConstraintStatus { get; }
    SketchConstraintsEnumerator Constraints { get; }
    bool Construction { get; set; }
    SketchBlock ContainingSketchBlock { get; }
    ActionTypeEnum DisabledActionTypes { get; set; }
    SketchPoint EndSketchPoint { get; }
    SketchPoint FitPoint { get; }
    LineSegment2d Geometry { get; }
    LineSegment Geometry3d { get; }
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
    SketchSpline Spline { get; }
    SketchPoint StartSketchPoint { get; }
    UnitVector2d Tangent { get; set; }
    ObjectTypeEnum Type { get; }
    double Weight { get; set; }
    // Methods
    void Delete();
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SketchSpline](../objects/SketchSpline.md).GetHandle, [SketchSplineHandleProxy](../objects/SketchSplineHandleProxy.md).NativeObject, [SketchSplineProxy](../objects/SketchSplineProxy.md).GetHandle

**Referenced types:** [ActionTypeEnum](../enums/ActionTypeEnum.md), [AttributeSets](../objects/AttributeSets.md), [Box2d](../objects/Box2d.md), [Color](../objects/Color.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [Layer](../objects/Layer.md), [LineDefinitionSpaceEnum](../enums/LineDefinitionSpaceEnum.md), [LineSegment](../objects/LineSegment.md), [LineSegment2d](../objects/LineSegment2d.md), [LineTypeEnum](../enums/LineTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch](../objects/Sketch.md), [SketchBlock](../objects/SketchBlock.md), [SketchBlocksEnumerator](../objects/SketchBlocksEnumerator.md), [SketchConstraintsEnumerator](../objects/SketchConstraintsEnumerator.md), [SketchEntitiesEnumerator](../objects/SketchEntitiesEnumerator.md), [SketchPoint](../objects/SketchPoint.md), [SketchSpline](../objects/SketchSpline.md), [UnitVector2d](../objects/UnitVector2d.md)

