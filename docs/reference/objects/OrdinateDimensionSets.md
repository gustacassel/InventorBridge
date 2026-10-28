# OrdinateDimensionSets

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingDimensions.OrdinateDimensionSets`

```csharp
interface OrdinateDimensionSets
{
    // Properties
    object Application { get; }
    int Count { get; }
    OrdinateDimensionSet Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    OrdinateDimensionSet Add(ObjectCollection GeometryIntents, Point2d PlacementPoint, DimensionTypeEnum DimensionType, object DimensionStyle = Missing, object Layer = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingDimensions](../objects/DrawingDimensions.md).OrdinateDimensionSets

**Referenced types:** [DimensionTypeEnum](../enums/DimensionTypeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [OrdinateDimensionSet](../objects/OrdinateDimensionSet.md), [Point2d](../objects/Point2d.md)

