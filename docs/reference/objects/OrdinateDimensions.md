# OrdinateDimensions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingDimensions.OrdinateDimensions`

```csharp
interface OrdinateDimensions
{
    // Properties
    object Application { get; }
    int Count { get; }
    OrdinateDimension Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    OrdinateDimension Add(GeometryIntent Intent, Point2d TextOrigin, DimensionTypeEnum DimensionType, object DimensionStyle = Missing, object Layer = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingDimensions](../objects/DrawingDimensions.md).OrdinateDimensions

**Referenced types:** [DimensionTypeEnum](../enums/DimensionTypeEnum.md), [GeometryIntent](../objects/GeometryIntent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [OrdinateDimension](../objects/OrdinateDimension.md), [Point2d](../objects/Point2d.md)

