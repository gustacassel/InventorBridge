# SketchBlock

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].SketchBlocks.Item[…]`

```csharp
interface SketchBlock
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    SketchBlocksEnumerator ChildBlocks { get; }
    Color Color { get; set; }
    ConstraintStatusEnum ConstraintStatus { get; }
    SketchBlock ContainingSketchBlock { get; }
    SketchBlockDefinition Definition { get; }
    bool Exported { get; set; }
    bool Flexible { get; set; }
    bool HasReferenceComponent { get; }
    LineTypeEnum LineType { get; set; }
    double LineWeight { get; set; }
    string Name { get; set; }
    Sketch Parent { get; }
    Point2d Position { get; set; }
    ReferenceComponent ReferenceComponent { get; }
    SketchBlock ReferencedEntity { get; }
    SketchBlocksEnumerator SketchBlockPath { get; }
    Matrix2d Transformation { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void Delete();
    void Edit();
    void ExitEdit(ExitTypeEnum ExitTo);
    void Explode();
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    object GetObject(object ObjectInDefinition);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
}
```

**Returned by:** [SketchArc](../objects/SketchArc.md).ContainingSketchBlock, [SketchArcProxy](../objects/SketchArcProxy.md).ContainingSketchBlock, [SketchBlock](../objects/SketchBlock.md).ContainingSketchBlock, [SketchBlock](../objects/SketchBlock.md).ReferencedEntity, [SketchBlockProxy](../objects/SketchBlockProxy.md).ContainingSketchBlock, [SketchBlockProxy](../objects/SketchBlockProxy.md).NativeObject, [SketchBlockProxy](../objects/SketchBlockProxy.md).ReferencedEntity, [SketchBlocks](../objects/SketchBlocks.md).Add, [SketchBlocks](../objects/SketchBlocks.md).AddByDefinition, [SketchBlocks](../objects/SketchBlocks.md).Item, [SketchBlocksEnumerator](../objects/SketchBlocksEnumerator.md).Item, [SketchCircle](../objects/SketchCircle.md).ContainingSketchBlock, [SketchCircleProxy](../objects/SketchCircleProxy.md).ContainingSketchBlock, [SketchControlPointSpline](../objects/SketchControlPointSpline.md).ContainingSketchBlock, [SketchControlPointSplineProxy](../objects/SketchControlPointSplineProxy.md).ContainingSketchBlock, [SketchEllipse](../objects/SketchEllipse.md).ContainingSketchBlock, [SketchEllipseProxy](../objects/SketchEllipseProxy.md).ContainingSketchBlock, [SketchEllipticalArc](../objects/SketchEllipticalArc.md).ContainingSketchBlock, [SketchEllipticalArcProxy](../objects/SketchEllipticalArcProxy.md).ContainingSketchBlock, [SketchEntity](../objects/SketchEntity.md).ContainingSketchBlock, [SketchEquationCurve](../objects/SketchEquationCurve.md).ContainingSketchBlock, [SketchEquationCurveProxy](../objects/SketchEquationCurveProxy.md).ContainingSketchBlock, [SketchFixedSpline](../objects/SketchFixedSpline.md).ContainingSketchBlock, [SketchFixedSplineProxy](../objects/SketchFixedSplineProxy.md).ContainingSketchBlock, [SketchImage](../objects/SketchImage.md).ContainingSketchBlock, [SketchImageProxy](../objects/SketchImageProxy.md).ContainingSketchBlock, [SketchLine](../objects/SketchLine.md).ContainingSketchBlock, [SketchLineProxy](../objects/SketchLineProxy.md).ContainingSketchBlock, [SketchOffsetSpline](../objects/SketchOffsetSpline.md).ContainingSketchBlock, [SketchOffsetSplineProxy](../objects/SketchOffsetSplineProxy.md).ContainingSketchBlock, [SketchPoint](../objects/SketchPoint.md).ContainingSketchBlock, [SketchPointProxy](../objects/SketchPointProxy.md).ContainingSketchBlock, [SketchSpline](../objects/SketchSpline.md).ContainingSketchBlock, [SketchSplineHandle](../objects/SketchSplineHandle.md).ContainingSketchBlock, [SketchSplineHandleProxy](../objects/SketchSplineHandleProxy.md).ContainingSketchBlock, [SketchSplineProxy](../objects/SketchSplineProxy.md).ContainingSketchBlock, [TextBox](../objects/TextBox.md).ContainingSketchBlock, [TextBoxProxy](../objects/TextBoxProxy.md).ContainingSketchBlock

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Color](../objects/Color.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [ExitTypeEnum](../enums/ExitTypeEnum.md), [LineTypeEnum](../enums/LineTypeEnum.md), [Matrix2d](../objects/Matrix2d.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch](../objects/Sketch.md), [SketchBlockDefinition](../objects/SketchBlockDefinition.md), [SketchBlocksEnumerator](../objects/SketchBlocksEnumerator.md)

