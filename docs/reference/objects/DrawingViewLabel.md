# DrawingViewLabel

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingViews.Item[…].Label`

```csharp
interface DrawingViewLabel
{
    // Properties
    object Application { get; }
    Color Color { get; set; }
    bool ConstrainToBorder { get; set; }
    string FormattedText { get; set; }
    HorizontalTextAlignmentEnum HorizontalJustification { get; set; }
    Layer Layer { get; set; }
    double LineSpacing { get; set; }
    TextLineSpacingTypeEnum LineSpacingType { get; set; }
    DrawingView Parent { get; }
    Point2d Position { get; set; }
    Box2d RangeBox { get; }
    VerticalTextAlignmentEnum StackedTextPosition { get; set; }
    string Text { get; }
    TextStyle TextStyle { get; set; }
    ObjectTypeEnum Type { get; }
    VerticalTextAlignmentEnum VerticalJustification { get; set; }
    double WidthScale { get; set; }
    // Methods
    void RestoreViewLabel(); // since 2025
}
```

**Returned by:** [DetailDrawingView](../objects/DetailDrawingView.md).Label, [DrawingView](../objects/DrawingView.md).Label, [SectionDrawingView](../objects/SectionDrawingView.md).Label

**Referenced types:** [Box2d](../objects/Box2d.md), [Color](../objects/Color.md), [DrawingView](../objects/DrawingView.md), [HorizontalTextAlignmentEnum](../enums/HorizontalTextAlignmentEnum.md), [Layer](../objects/Layer.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [TextLineSpacingTypeEnum](../enums/TextLineSpacingTypeEnum.md), [TextStyle](../objects/TextStyle.md), [VerticalTextAlignmentEnum](../enums/VerticalTextAlignmentEnum.md)

