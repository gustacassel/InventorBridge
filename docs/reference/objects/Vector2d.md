# Vector2d

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateVector2d(…)`

```csharp
interface Vector2d
{
    // Properties
    double Length { get; }
    double X { get; set; }
    double Y { get; set; }
    // Methods
    void AddVector(Vector2d Value);
    double AngleTo(Vector2d Vector);
    UnitVector2d AsUnitVector();
    Vector2d Copy();
    double DotProduct(Vector2d Vector);
    void GetVectorData(out double[] Coords);
    bool IsEqualTo(Vector2d Vector, double Tolerance = 0);
    bool IsParallelTo(Vector2d Vector, double Tolerance = 0);
    bool IsPerpendicularTo(Vector2d Vector, double Tolerance = 0);
    void Normalize();
    void PutVectorData(out double[] Coords);
    void ScaleBy(double Value);
    void SubtractVector(Vector2d Value);
    void TransformBy(Matrix2d Value);
}
```

**Returned by:** [EllipseFull2d](../objects/EllipseFull2d.md).MajorAxisVector, [Matrix2d](../objects/Matrix2d.md).Translation, [Point2d](../objects/Point2d.md).VectorTo, [TransientGeometry](../objects/TransientGeometry.md).CreateVector2d, [UnitVector2d](../objects/UnitVector2d.md).AsVector, [Vector2d](../objects/Vector2d.md).Copy

**Referenced types:** [Matrix2d](../objects/Matrix2d.md), [UnitVector2d](../objects/UnitVector2d.md)

