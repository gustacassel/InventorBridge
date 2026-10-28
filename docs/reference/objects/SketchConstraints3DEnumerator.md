# SketchConstraints3DEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].OnFaceCurves.Item[…].Constraints3D`

```csharp
interface SketchConstraints3DEnumerator
{
    // Properties
    int Count { get; }
    object Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [HelicalCurve](../objects/HelicalCurve.md).Constraints3D, [HelicalCurveProxy](../objects/HelicalCurveProxy.md).Constraints3D, [OnFaceCurve](../objects/OnFaceCurve.md).Constraints3D, [OnFaceCurveProxy](../objects/OnFaceCurveProxy.md).Constraints3D, [SketchArc3D](../objects/SketchArc3D.md).Constraints3D, [SketchArc3DProxy](../objects/SketchArc3DProxy.md).Constraints3D, [SketchCircle3D](../objects/SketchCircle3D.md).Constraints3D, [SketchCircle3DProxy](../objects/SketchCircle3DProxy.md).Constraints3D, [SketchControlPointSpline3D](../objects/SketchControlPointSpline3D.md).Constraints3D, [SketchControlPointSpline3DProxy](../objects/SketchControlPointSpline3DProxy.md).Constraints3D, [SketchEllipse3D](../objects/SketchEllipse3D.md).Constraints3D, [SketchEllipse3DProxy](../objects/SketchEllipse3DProxy.md).Constraints3D, [SketchEllipticalArc3D](../objects/SketchEllipticalArc3D.md).Constraints3D, [SketchEllipticalArc3DProxy](../objects/SketchEllipticalArc3DProxy.md).Constraints3D, [SketchEntity3D](../objects/SketchEntity3D.md).Constraints3D, [SketchEquationCurve3D](../objects/SketchEquationCurve3D.md).Constraints3D, [SketchEquationCurve3DProxy](../objects/SketchEquationCurve3DProxy.md).Constraints3D, [SketchFixedSpline3D](../objects/SketchFixedSpline3D.md).Constraints3D, [SketchFixedSpline3DProxy](../objects/SketchFixedSpline3DProxy.md).Constraints3D, [SketchLine3D](../objects/SketchLine3D.md).Constraints3D, [SketchLine3DProxy](../objects/SketchLine3DProxy.md).Constraints3D, [SketchPoint3D](../objects/SketchPoint3D.md).Constraints3D, [SketchPoint3DProxy](../objects/SketchPoint3DProxy.md).Constraints3D, [SketchSpline3D](../objects/SketchSpline3D.md).Constraints3D, [SketchSpline3DProxy](../objects/SketchSpline3DProxy.md).Constraints3D, [SketchSplineHandle3D](../objects/SketchSplineHandle3D.md).Constraints3D, [SketchSplineHandle3DProxy](../objects/SketchSplineHandle3DProxy.md).Constraints3D

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

