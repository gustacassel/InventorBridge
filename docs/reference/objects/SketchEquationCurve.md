# SketchEquationCurve

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [SketchEntity](../objects/SketchEntity.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].SketchEquationCurves.Item[…]`

```csharp
interface SketchEquationCurve
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ConstraintStatusEnum ConstraintStatus { get; }
    SketchConstraintsEnumerator Constraints { get; }
    bool Construction { get; set; }
    SketchBlock ContainingSketchBlock { get; }
    bool CurvatureDisplay { get; set; }
    ActionTypeEnum DisabledActionTypes { get; set; }
    SketchPoint EndSketchPoint { get; }
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
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void GetEquation(out CurveEquationTypeEnum EquationType, out CoordinateSystemTypeEnum CoordinateSystemType, out string XValueOrRadius, out string YValueOrTheta, out Parameter MinValue, out Parameter MaxValue);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
    void SetEquation(CurveEquationTypeEnum EquationType, CoordinateSystemTypeEnum CoordinateSystemType, string XValueOrRadius, string YValueOrTheta, object MinValue, object MaxValue);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SketchEquationCurveProxy](../objects/SketchEquationCurveProxy.md).NativeObject, [SketchEquationCurves](../objects/SketchEquationCurves.md).Add, [SketchEquationCurves](../objects/SketchEquationCurves.md).Item

**Referenced types:** [ActionTypeEnum](../enums/ActionTypeEnum.md), [AttributeSets](../objects/AttributeSets.md), [BSplineCurve](../objects/BSplineCurve.md), [BSplineCurve2d](../objects/BSplineCurve2d.md), [Box2d](../objects/Box2d.md), [Color](../objects/Color.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [CoordinateSystemTypeEnum](../enums/CoordinateSystemTypeEnum.md), [CurveEquationTypeEnum](../enums/CurveEquationTypeEnum.md), [Layer](../objects/Layer.md), [LineDefinitionSpaceEnum](../enums/LineDefinitionSpaceEnum.md), [LineTypeEnum](../enums/LineTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch](../objects/Sketch.md), [SketchBlock](../objects/SketchBlock.md), [SketchBlocksEnumerator](../objects/SketchBlocksEnumerator.md), [SketchConstraintsEnumerator](../objects/SketchConstraintsEnumerator.md), [SketchEntitiesEnumerator](../objects/SketchEntitiesEnumerator.md), [SketchPoint](../objects/SketchPoint.md)

