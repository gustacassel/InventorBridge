# GeneralNote

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [DrawingNote](../objects/DrawingNote.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingNotes.GeneralNotes.Item[…]`

```csharp
interface GeneralNote
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    Color BackgroundColor { get; set; }
    Color Color { get; set; }
    bool Fitted { get; }
    double FittedTextHeight { get; }
    double FittedTextWidth { get; }
    string FormattedText { get; set; }
    double Height { get; set; }
    HorizontalTextAlignmentEnum HorizontalJustification { get; set; }
    Layer Layer { get; set; }
    double LineSpacing { get; set; }
    TextLineSpacingTypeEnum LineSpacingType { get; set; }
    Sheet Parent { get; }
    Point2d Position { get; set; }
    Box2d RangeBox { get; }
    bool Retrieved { get; } // since 2025
    object RetrievedFrom { get; } // since 2025
    double Rotation { get; set; }
    bool ShowTextBorder { get; set; }
    VerticalTextAlignmentEnum StackedTextPosition { get; set; }
    string Text { get; set; }
    TextStyle TextStyle { get; set; }
    ObjectTypeEnum Type { get; }
    UnitAttributes UnitAttributes { get; }
    bool UseBackgroundColor { get; set; }
    VerticalTextAlignmentEnum VerticalJustification { get; set; }
    double Width { get; set; }
    double WidthScale { get; set; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [GeneralNotes](../objects/GeneralNotes.md).AddByRectangle, [GeneralNotes](../objects/GeneralNotes.md).AddFitted, [GeneralNotes](../objects/GeneralNotes.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box2d](../objects/Box2d.md), [Color](../objects/Color.md), [HorizontalTextAlignmentEnum](../enums/HorizontalTextAlignmentEnum.md), [Layer](../objects/Layer.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [Sheet](../objects/Sheet.md), [TextLineSpacingTypeEnum](../enums/TextLineSpacingTypeEnum.md), [TextStyle](../objects/TextStyle.md), [UnitAttributes](../objects/UnitAttributes.md), [VerticalTextAlignmentEnum](../enums/VerticalTextAlignmentEnum.md)

