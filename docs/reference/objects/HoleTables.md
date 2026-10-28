# HoleTables

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.HoleTables`

```csharp
interface HoleTables
{
    // Properties
    object Application { get; }
    int Count { get; }
    HoleTable Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    HoleTable Add(DrawingView DrawingView, Point2d PlacementPoint, object HoleTableStyle = Missing, object Layer = Missing);
    HoleTable AddByFeatureType(DrawingView DrawingView, Point2d PlacementPoint, bool IncludeDrilledHoleFeatures, bool IncludeCounterBoreHoleFeatures, bool IncludeCounterSinkHoleFeatures, bool IncludeThreadedHoleFeatures, bool IncludeCircularCuts, bool IncludeCentermarks, bool IncludeRecoveredPunchCenters, object HoleTableStyle = Missing, object Layer = Missing);
    HoleTable AddSelected(ObjectCollection Holes, Point2d PlacementPoint, object HoleTableStyle = Missing, object Layer = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sheet](../objects/Sheet.md).HoleTables

**Referenced types:** [DrawingView](../objects/DrawingView.md), [HoleTable](../objects/HoleTable.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md)

