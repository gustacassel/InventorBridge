# DrawingViewHatchRegion

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingViews.Item[…].HatchRegions.Item[…]`

```csharp
interface DrawingViewHatchRegion
{
    // Properties
    double Angle { get; set; }
    object Application { get; }
    ObjectCollection BoundaryGeometries { get; }
    bool ByMaterial { get; set; }
    Color Color { get; set; }
    bool DoublePattern { get; set; }
    DrawingViewHatchAreas HatchAreas { get; }
    Layer Layer { get; set; }
    double LineWeight { get; set; }
    DrawingView Parent { get; }
    DrawingHatchPattern Pattern { get; set; }
    Box2d RangeBox { get; }
    double Scale { get; set; }
    double Shift { get; set; }
    object SurfaceBody { get; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
}
```

**Returned by:** [DrawingViewHatchArea](../objects/DrawingViewHatchArea.md).Parent, [DrawingViewHatchRegions](../objects/DrawingViewHatchRegions.md).Item

**Referenced types:** [Box2d](../objects/Box2d.md), [Color](../objects/Color.md), [DrawingHatchPattern](../objects/DrawingHatchPattern.md), [DrawingView](../objects/DrawingView.md), [DrawingViewHatchAreas](../objects/DrawingViewHatchAreas.md), [Layer](../objects/Layer.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

