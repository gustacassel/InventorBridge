# BaselineDimensionSets

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingDimensions.BaselineDimensionSets`

```csharp
interface BaselineDimensionSets
{
    // Properties
    object Application { get; }
    int Count { get; }
    BaselineDimensionSet Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    BaselineDimensionSet Add(ObjectCollection GeometryIntents, Point2d PlacementPoint, DimensionTypeEnum DimensionType, object DimensionStyle = Missing, object Layer = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingDimensions](../objects/DrawingDimensions.md).BaselineDimensionSets

**Referenced types:** [BaselineDimensionSet](../objects/BaselineDimensionSet.md), [DimensionTypeEnum](../enums/DimensionTypeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md)

