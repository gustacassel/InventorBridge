# SketchCircle

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [SketchEntity](../objects/SketchEntity.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].SketchCircles.Item[…]`

```csharp
interface SketchCircle
{
    // Properties
    object Application { get; }
    double Area { get; }
    AttributeSets AttributeSets { get; }
    SketchPoint CenterSketchPoint { get; }
    ConstraintStatusEnum ConstraintStatus { get; }
    SketchConstraintsEnumerator Constraints { get; }
    bool Construction { get; set; }
    SketchBlock ContainingSketchBlock { get; }
    bool CurvatureDisplay { get; set; }
    ActionTypeEnum DisabledActionTypes { get; set; }
    Circle2d Geometry { get; }
    Circle Geometry3d { get; }
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
    double Radius { get; set; }
    Box2d RangeBox { get; }
    bool Reference { get; set; }
    ReferenceComponent ReferenceComponent { get; }
    object ReferencedEntity { get; }
    SketchBlocksEnumerator SketchBlockPath { get; }
    bool SketchOnly { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SketchCircleProxy](../objects/SketchCircleProxy.md).NativeObject, [SketchCircles](../objects/SketchCircles.md).AddByCenterRadius, [SketchCircles](../objects/SketchCircles.md).AddByThreePoints, [SketchCircles](../objects/SketchCircles.md).Item

**Referenced types:** [ActionTypeEnum](../enums/ActionTypeEnum.md), [AttributeSets](../objects/AttributeSets.md), [Box2d](../objects/Box2d.md), [Circle](../objects/Circle.md), [Circle2d](../objects/Circle2d.md), [Color](../objects/Color.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [Layer](../objects/Layer.md), [LineDefinitionSpaceEnum](../enums/LineDefinitionSpaceEnum.md), [LineTypeEnum](../enums/LineTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch](../objects/Sketch.md), [SketchBlock](../objects/SketchBlock.md), [SketchBlocksEnumerator](../objects/SketchBlocksEnumerator.md), [SketchConstraintsEnumerator](../objects/SketchConstraintsEnumerator.md), [SketchEntitiesEnumerator](../objects/SketchEntitiesEnumerator.md), [SketchPoint](../objects/SketchPoint.md)

