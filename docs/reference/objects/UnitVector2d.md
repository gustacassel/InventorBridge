# UnitVector2d

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateUnitVector2d(…)`

```csharp
interface UnitVector2d
{
    // Properties
    double X { get; set; }
    double Y { get; set; }
    // Methods
    double AngleTo(UnitVector2d Vector);
    Vector2d AsVector();
    UnitVector2d Copy();
    double DotProduct(UnitVector2d Vector);
    void GetUnitVectorData(out double[] Coords);
    bool IsEqualTo(UnitVector2d Vector, double Tolerance = 0);
    bool IsParallelTo(UnitVector2d Vector, double Tolerance = 0);
    bool IsPerpendicularTo(UnitVector2d Vector, double Tolerance = 0);
    void PutUnitVectorData(out double[] Coords);
    void TransformBy(Matrix2d Value);
}
```

**Returned by:** [Centermark](../objects/Centermark.md).ExtensionPointFourDirection, [Centermark](../objects/Centermark.md).ExtensionPointOneDirection, [Centermark](../objects/Centermark.md).ExtensionPointThreeDirection, [Centermark](../objects/Centermark.md).ExtensionPointTwoDirection, [EllipticalArc2d](../objects/EllipticalArc2d.md).MajorAxis, [Line2d](../objects/Line2d.md).Direction, [LineSegment2d](../objects/LineSegment2d.md).Direction, [SketchEllipse](../objects/SketchEllipse.md).MajorAxisVector, [SketchEllipseProxy](../objects/SketchEllipseProxy.md).MajorAxisVector, [SketchEllipticalArc](../objects/SketchEllipticalArc.md).MajorAxisVector, [SketchEllipticalArcProxy](../objects/SketchEllipticalArcProxy.md).MajorAxisVector, [SketchSplineHandle](../objects/SketchSplineHandle.md).Tangent, [SketchSplineHandleProxy](../objects/SketchSplineHandleProxy.md).Tangent, [TransientGeometry](../objects/TransientGeometry.md).CreateUnitVector2d, [UnitVector2d](../objects/UnitVector2d.md).Copy, [Vector2d](../objects/Vector2d.md).AsUnitVector

**Referenced types:** [Matrix2d](../objects/Matrix2d.md), [Vector2d](../objects/Vector2d.md)

