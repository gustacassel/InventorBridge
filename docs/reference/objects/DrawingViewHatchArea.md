# DrawingViewHatchArea

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingViews.Item[…].HatchRegions.Item[…].HatchAreas.Item[…]`

```csharp
interface DrawingViewHatchArea
{
    // Properties
    object Application { get; }
    ObjectCollection BoundaryGeometries { get; }
    DrawingViewHatchRegion Parent { get; }
    Box2d RangeBox { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [DrawingViewHatchAreas](../objects/DrawingViewHatchAreas.md).Item

**Referenced types:** [Box2d](../objects/Box2d.md), [DrawingViewHatchRegion](../objects/DrawingViewHatchRegion.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

