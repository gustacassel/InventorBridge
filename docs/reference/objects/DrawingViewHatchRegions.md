# DrawingViewHatchRegions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingViews.Item[…].HatchRegions`

```csharp
interface DrawingViewHatchRegions
{
    // Properties
    object Application { get; }
    int Count { get; }
    DrawingViewHatchRegion Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DetailDrawingView](../objects/DetailDrawingView.md).HatchRegions, [DrawingView](../objects/DrawingView.md).HatchRegions, [SectionDrawingView](../objects/SectionDrawingView.md).HatchRegions

**Referenced types:** [DrawingViewHatchRegion](../objects/DrawingViewHatchRegion.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

