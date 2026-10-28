# DrawingNote

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingNotes.Item[…]`

```csharp
interface DrawingNote
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    Color Color { get; set; }
    string FormattedText { get; set; }
    HorizontalTextAlignmentEnum HorizontalJustification { get; set; }
    Layer Layer { get; set; }
    double LineSpacing { get; set; }
    TextLineSpacingTypeEnum LineSpacingType { get; set; }
    Sheet Parent { get; }
    Point2d Position { get; set; }
    Box2d RangeBox { get; }
    VerticalTextAlignmentEnum StackedTextPosition { get; set; }
    string Text { get; set; }
    ObjectTypeEnum Type { get; }
    VerticalTextAlignmentEnum VerticalJustification { get; set; }
    double WidthScale { get; set; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingNotes](../objects/DrawingNotes.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box2d](../objects/Box2d.md), [Color](../objects/Color.md), [HorizontalTextAlignmentEnum](../enums/HorizontalTextAlignmentEnum.md), [Layer](../objects/Layer.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [Sheet](../objects/Sheet.md), [TextLineSpacingTypeEnum](../enums/TextLineSpacingTypeEnum.md), [VerticalTextAlignmentEnum](../enums/VerticalTextAlignmentEnum.md)

