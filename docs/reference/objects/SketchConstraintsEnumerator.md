# SketchConstraintsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SketchBlockDefinitions.Item[…].InsertionPoint.Constraints`

```csharp
interface SketchConstraintsEnumerator
{
    // Properties
    int Count { get; }
    object Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SketchArc](../objects/SketchArc.md).Constraints, [SketchArcProxy](../objects/SketchArcProxy.md).Constraints, [SketchCircle](../objects/SketchCircle.md).Constraints, [SketchCircleProxy](../objects/SketchCircleProxy.md).Constraints, [SketchCircularPattern](../objects/SketchCircularPattern.md).Constraints, [SketchControlPointSpline](../objects/SketchControlPointSpline.md).Constraints, [SketchControlPointSplineProxy](../objects/SketchControlPointSplineProxy.md).Constraints, [SketchEllipse](../objects/SketchEllipse.md).Constraints, [SketchEllipseProxy](../objects/SketchEllipseProxy.md).Constraints, [SketchEllipticalArc](../objects/SketchEllipticalArc.md).Constraints, [SketchEllipticalArcProxy](../objects/SketchEllipticalArcProxy.md).Constraints, [SketchEntity](../objects/SketchEntity.md).Constraints, [SketchEquationCurve](../objects/SketchEquationCurve.md).Constraints, [SketchEquationCurveProxy](../objects/SketchEquationCurveProxy.md).Constraints, [SketchFixedSpline](../objects/SketchFixedSpline.md).Constraints, [SketchFixedSplineProxy](../objects/SketchFixedSplineProxy.md).Constraints, [SketchLine](../objects/SketchLine.md).Constraints, [SketchLineProxy](../objects/SketchLineProxy.md).Constraints, [SketchOffsetSpline](../objects/SketchOffsetSpline.md).Constraints, [SketchOffsetSplineProxy](../objects/SketchOffsetSplineProxy.md).Constraints, [SketchPoint](../objects/SketchPoint.md).Constraints, [SketchPointProxy](../objects/SketchPointProxy.md).Constraints, [SketchRectangularPattern](../objects/SketchRectangularPattern.md).Constraints, [SketchSpline](../objects/SketchSpline.md).Constraints, [SketchSplineHandle](../objects/SketchSplineHandle.md).Constraints, [SketchSplineHandleProxy](../objects/SketchSplineHandleProxy.md).Constraints, [SketchSplineProxy](../objects/SketchSplineProxy.md).Constraints

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

