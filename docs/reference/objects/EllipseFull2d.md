# EllipseFull2d

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateEllipseFull2d(…)`

```csharp
interface EllipseFull2d
{
    // Properties
    Point2d Center { get; set; }
    Curve2dEvaluator Evaluator { get; }
    Vector2d MajorAxisVector { get; set; }
    double MinorMajorRatio { get; set; }
    // Methods
    EllipseFull2d Copy();
    void GetEllipseFullData(out double[] Center, out double[] MajorAxis, out double MinorMajorRatio);
    void PutEllipseFullData(out double[] Center, out double[] MajorAxis, double MinorMajorRatio);
}
```

**Returned by:** [EllipseFull2d](../objects/EllipseFull2d.md).Copy, [SketchEllipse](../objects/SketchEllipse.md).Geometry, [SketchEllipseProxy](../objects/SketchEllipseProxy.md).Geometry, [TransientGeometry](../objects/TransientGeometry.md).CreateEllipseFull2d

**Referenced types:** [Curve2dEvaluator](../objects/Curve2dEvaluator.md), [Point2d](../objects/Point2d.md), [Vector2d](../objects/Vector2d.md)

