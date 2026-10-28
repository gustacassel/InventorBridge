# BSplineCurveDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateBSplineCurveDefinition(…)`

```csharp
interface BSplineCurveDefinition
{
    // Properties
    SplineFitMethodEnum FitMethod { get; set; }
    bool FixedLength { get; set; }
    double Length { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void AddPoint(Point Point, double Weight = 1, object Tangent = Missing);
}
```

**Returned by:** [TransientGeometry](../objects/TransientGeometry.md).CreateBSplineCurveDefinition

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [SplineFitMethodEnum](../enums/SplineFitMethodEnum.md)

