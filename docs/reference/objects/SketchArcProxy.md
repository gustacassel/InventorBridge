# SketchArcProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [SketchArc](../objects/SketchArc.md) → [SketchEntity](../objects/SketchEntity.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].SketchArcs.Item[…] → (SketchArcProxy)`

```csharp
interface SketchArcProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    SketchPoint CenterSketchPoint { get; }
    ConstraintStatusEnum ConstraintStatus { get; }
    SketchConstraintsEnumerator Constraints { get; }
    bool Construction { get; set; }
    ComponentOccurrence ContainingOccurrence { get; }
    SketchBlock ContainingSketchBlock { get; }
    bool CurvatureDisplay { get; set; }
    ActionTypeEnum DisabledActionTypes { get; set; }
    SketchPoint EndSketchPoint { get; }
    Arc2d Geometry { get; }
    Arc3d Geometry3d { get; }
    bool HasReferenceComponent { get; }
    Layer Layer { get; set; }
    double Length { get; }
    LineDefinitionSpaceEnum LineDefinitionSpace { get; set; }
    double LineScale { get; set; }
    LineTypeEnum LineType { get; set; }
    double LineWeight { get; set; }
    SketchArc NativeObject { get; }
    Color OverrideColor { get; set; }
    SketchEntitiesEnumerator OwnedBy { get; }
    Sketch Parent { get; }
    double Radius { get; }
    Box2d RangeBox { get; }
    bool Reference { get; set; }
    ReferenceComponent ReferenceComponent { get; }
    object ReferencedEntity { get; }
    SketchBlocksEnumerator SketchBlockPath { get; }
    bool SketchOnly { get; set; }
    double StartAngle { get; }
    SketchPoint StartSketchPoint { get; }
    double SweepAngle { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [ActionTypeEnum](../enums/ActionTypeEnum.md), [Arc2d](../objects/Arc2d.md), [Arc3d](../objects/Arc3d.md), [AttributeSets](../objects/AttributeSets.md), [Box2d](../objects/Box2d.md), [Color](../objects/Color.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [Layer](../objects/Layer.md), [LineDefinitionSpaceEnum](../enums/LineDefinitionSpaceEnum.md), [LineTypeEnum](../enums/LineTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch](../objects/Sketch.md), [SketchArc](../objects/SketchArc.md), [SketchBlock](../objects/SketchBlock.md), [SketchBlocksEnumerator](../objects/SketchBlocksEnumerator.md), [SketchConstraintsEnumerator](../objects/SketchConstraintsEnumerator.md), [SketchEntitiesEnumerator](../objects/SketchEntitiesEnumerator.md), [SketchPoint](../objects/SketchPoint.md)

