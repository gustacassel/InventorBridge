# Vector

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateVector(…)`

```csharp
interface Vector
{
    // Properties
    double Length { get; }
    double X { get; set; }
    double Y { get; set; }
    double Z { get; set; }
    // Methods
    void AddVector(Vector Argument);
    double AngleTo(Vector Argument);
    UnitVector AsUnitVector();
    Vector Copy();
    Vector CrossProduct(Vector Argument);
    double DotProduct(Vector Argument);
    void GetVectorData(out double[] Coords);
    bool IsEqualTo(Vector Argument, double Tolerance = 0);
    bool IsParallelTo(Vector Argument, double Tolerance = 0);
    bool IsPerpendicularTo(Vector Argument, double Tolerance = 0);
    void Normalize();
    void PutVectorData(out double[] Coords);
    void ScaleBy(double Scale);
    void SubtractVector(Vector Argument);
    void TransformBy(Matrix Matrix);
}
```

**Returned by:** [DSLoadDefinition](../objects/DSLoadDefinition.md).Vector, [EllipseFull](../objects/EllipseFull.md).MajorAxisVector, [EllipticalCone](../objects/EllipticalCone.md).MajorAxisVector, [EllipticalCylinder](../objects/EllipticalCylinder.md).MajorAxisVector, [HoleTapInfo](../objects/HoleTapInfo.md).ThreadDirection, [Light](../objects/Light.md).Direction, [Matrix](../objects/Matrix.md).Translation, [OrientedBox](../objects/OrientedBox.md).DirectionOne, [OrientedBox](../objects/OrientedBox.md).DirectionThree, [OrientedBox](../objects/OrientedBox.md).DirectionTwo, [Point](../objects/Point.md).VectorTo, [StandardThreadInfo](../objects/StandardThreadInfo.md).ThreadDirection, [TaperedThreadInfo](../objects/TaperedThreadInfo.md).ThreadDirection, [ThreadInfo](../objects/ThreadInfo.md).ThreadDirection, [TransientGeometry](../objects/TransientGeometry.md).CreateVector, [UnitVector](../objects/UnitVector.md).AsVector, [Vector](../objects/Vector.md).Copy, [Vector](../objects/Vector.md).CrossProduct

**Referenced types:** [Matrix](../objects/Matrix.md), [UnitVector](../objects/UnitVector.md)

