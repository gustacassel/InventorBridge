# SketchBlocksEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SketchBlockDefinitions.Item[…].InsertionPoint.SketchBlockPath`

```csharp
interface SketchBlocksEnumerator
{
    // Properties
    int Count { get; }
    SketchBlock Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DerivedPartComponent](../objects/DerivedPartComponent.md).SketchBlocks, [DerivedPartComponentProxy](../objects/DerivedPartComponentProxy.md).SketchBlocks, [SketchArc](../objects/SketchArc.md).SketchBlockPath, [SketchArcProxy](../objects/SketchArcProxy.md).SketchBlockPath, [SketchBlock](../objects/SketchBlock.md).ChildBlocks, [SketchBlock](../objects/SketchBlock.md).SketchBlockPath, [SketchBlockProxy](../objects/SketchBlockProxy.md).ChildBlocks, [SketchBlockProxy](../objects/SketchBlockProxy.md).SketchBlockPath, [SketchCircle](../objects/SketchCircle.md).SketchBlockPath, [SketchCircleProxy](../objects/SketchCircleProxy.md).SketchBlockPath, [SketchControlPointSpline](../objects/SketchControlPointSpline.md).SketchBlockPath, [SketchControlPointSplineProxy](../objects/SketchControlPointSplineProxy.md).SketchBlockPath, [SketchEllipse](../objects/SketchEllipse.md).SketchBlockPath, [SketchEllipseProxy](../objects/SketchEllipseProxy.md).SketchBlockPath, [SketchEllipticalArc](../objects/SketchEllipticalArc.md).SketchBlockPath, [SketchEllipticalArcProxy](../objects/SketchEllipticalArcProxy.md).SketchBlockPath, [SketchEntity](../objects/SketchEntity.md).SketchBlockPath, [SketchEquationCurve](../objects/SketchEquationCurve.md).SketchBlockPath, [SketchEquationCurveProxy](../objects/SketchEquationCurveProxy.md).SketchBlockPath, [SketchFixedSpline](../objects/SketchFixedSpline.md).SketchBlockPath, [SketchFixedSplineProxy](../objects/SketchFixedSplineProxy.md).SketchBlockPath, [SketchImage](../objects/SketchImage.md).SketchBlockPath, [SketchImageProxy](../objects/SketchImageProxy.md).SketchBlockPath, [SketchLine](../objects/SketchLine.md).SketchBlockPath, [SketchLineProxy](../objects/SketchLineProxy.md).SketchBlockPath, [SketchOffsetSpline](../objects/SketchOffsetSpline.md).SketchBlockPath, [SketchOffsetSplineProxy](../objects/SketchOffsetSplineProxy.md).SketchBlockPath, [SketchPoint](../objects/SketchPoint.md).SketchBlockPath, [SketchPointProxy](../objects/SketchPointProxy.md).SketchBlockPath, [SketchSpline](../objects/SketchSpline.md).SketchBlockPath, [SketchSplineHandle](../objects/SketchSplineHandle.md).SketchBlockPath, [SketchSplineHandleProxy](../objects/SketchSplineHandleProxy.md).SketchBlockPath, [SketchSplineProxy](../objects/SketchSplineProxy.md).SketchBlockPath, [TextBox](../objects/TextBox.md).SketchBlockPath, [TextBoxProxy](../objects/TextBoxProxy.md).SketchBlockPath

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchBlock](../objects/SketchBlock.md)

