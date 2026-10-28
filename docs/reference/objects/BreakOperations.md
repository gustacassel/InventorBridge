# BreakOperations

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingViews.Item[…].BreakOperations`

```csharp
interface BreakOperations
{
    // Properties
    object Application { get; }
    int Count { get; }
    BreakOperation Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    BreakOperation AddBySketch(DrawingSketch Sketch, BreakStyleEnum BreakStyle = BreakStyleEnum.kRectangularBreakStyle, int DisplayLevel = 5, double Gap = 0, int NumberOfSymbols = 1, object Reserved = Missing); // since 2026
    BreakOperation AddWithOptions(BreakOrientationEnum Orientation, Point2d StartPoint, Point2d EndPoint, object Options = Missing); // since 2027
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DetailDrawingView](../objects/DetailDrawingView.md).BreakOperations, [DrawingView](../objects/DrawingView.md).BreakOperations, [SectionDrawingView](../objects/SectionDrawingView.md).BreakOperations

**Referenced types:** [BreakOperation](../objects/BreakOperation.md), [BreakOrientationEnum](../enums/BreakOrientationEnum.md), [BreakStyleEnum](../enums/BreakStyleEnum.md), [DrawingSketch](../objects/DrawingSketch.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md)

