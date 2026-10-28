# SketchEntities3DEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SketchEntities3D`

```csharp
interface SketchEntities3DEnumerator
{
    // Properties
    int Count { get; }
    SketchEntity3D Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [HelicalCurve](../objects/HelicalCurve.md).OwnedBy, [HelicalCurve](../objects/HelicalCurve.md).SketchEntities, [HelicalCurveProxy](../objects/HelicalCurveProxy.md).OwnedBy, [HelicalCurveProxy](../objects/HelicalCurveProxy.md).SketchEntities, [IntersectionCurve](../objects/IntersectionCurve.md).SketchEntities, [IntersectionCurveProxy](../objects/IntersectionCurveProxy.md).SketchEntities, [OnFaceCurve](../objects/OnFaceCurve.md).SketchEntities, [OnFaceCurveProxy](../objects/OnFaceCurveProxy.md).SketchEntities, [ProjectToSurfaceCurve](../objects/ProjectToSurfaceCurve.md).SketchEntities, [ProjectToSurfaceCurveProxy](../objects/ProjectToSurfaceCurveProxy.md).SketchEntities, [SilhouetteCurve](../objects/SilhouetteCurve.md).SketchEntities, [SilhouetteCurveProxy](../objects/SilhouetteCurveProxy.md).SketchEntities, [Sketch3D](../objects/Sketch3D.md).SketchEntities3D, [Sketch3DProxy](../objects/Sketch3DProxy.md).SketchEntities3D, [SketchArc3D](../objects/SketchArc3D.md).OwnedBy, [SketchArc3DProxy](../objects/SketchArc3DProxy.md).OwnedBy, [SketchCircle3D](../objects/SketchCircle3D.md).OwnedBy, [SketchCircle3DProxy](../objects/SketchCircle3DProxy.md).OwnedBy, [SketchControlPointSpline3D](../objects/SketchControlPointSpline3D.md).OwnedBy, [SketchControlPointSpline3DProxy](../objects/SketchControlPointSpline3DProxy.md).OwnedBy, [SketchEllipse3D](../objects/SketchEllipse3D.md).OwnedBy, [SketchEllipse3DProxy](../objects/SketchEllipse3DProxy.md).OwnedBy, [SketchEllipticalArc3D](../objects/SketchEllipticalArc3D.md).OwnedBy, [SketchEllipticalArc3DProxy](../objects/SketchEllipticalArc3DProxy.md).OwnedBy, [SketchEntity3D](../objects/SketchEntity3D.md).OwnedBy, [SketchEquationCurve3D](../objects/SketchEquationCurve3D.md).OwnedBy, [SketchEquationCurve3DProxy](../objects/SketchEquationCurve3DProxy.md).OwnedBy, [SketchFixedSpline3D](../objects/SketchFixedSpline3D.md).OwnedBy, [SketchFixedSpline3DProxy](../objects/SketchFixedSpline3DProxy.md).OwnedBy, [SketchLine3D](../objects/SketchLine3D.md).OwnedBy, [SketchLine3DProxy](../objects/SketchLine3DProxy.md).OwnedBy, [SketchPoint3D](../objects/SketchPoint3D.md).AttachedEntities, [SketchPoint3D](../objects/SketchPoint3D.md).OwnedBy, [SketchPoint3DProxy](../objects/SketchPoint3DProxy.md).AttachedEntities, [SketchPoint3DProxy](../objects/SketchPoint3DProxy.md).OwnedBy, [SketchSpline3D](../objects/SketchSpline3D.md).OwnedBy, [SketchSpline3DProxy](../objects/SketchSpline3DProxy.md).OwnedBy, [SketchSplineHandle3D](../objects/SketchSplineHandle3D.md).OwnedBy, [SketchSplineHandle3DProxy](../objects/SketchSplineHandle3DProxy.md).OwnedBy

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchEntity3D](../objects/SketchEntity3D.md)

