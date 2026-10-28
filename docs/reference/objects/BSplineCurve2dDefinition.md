# BSplineCurve2dDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateBSplineCurve2dDefinition(…)`

```csharp
interface BSplineCurve2dDefinition
{
    // Properties
    SplineFitMethodEnum FitMethod { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void AddPoint(Point2d Point, double Weight = 1, object Tangent = Missing);
}
```

**Returned by:** [TransientGeometry](../objects/TransientGeometry.md).CreateBSplineCurve2dDefinition

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [SplineFitMethodEnum](../enums/SplineFitMethodEnum.md)

