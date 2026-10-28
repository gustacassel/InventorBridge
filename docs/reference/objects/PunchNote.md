# PunchNote

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [LeaderNote](../objects/LeaderNote.md) → [DrawingNote](../objects/DrawingNote.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingNotes.PunchNotes.Item[…]`

```csharp
interface PunchNote
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    Color BackgroundColor { get; set; }
    Color Color { get; set; }
    DimensionStyle DimensionStyle { get; set; }
    string FormattedPunchNote { get; set; }
    string FormattedQuantityNote { get; set; }
    string FormattedText { get; set; }
    bool HideValue { get; set; }
    HorizontalTextAlignmentEnum HorizontalJustification { get; set; }
    Layer Layer { get; set; }
    Leader Leader { get; }
    double LineSpacing { get; set; }
    TextLineSpacingTypeEnum LineSpacingType { get; set; }
    Sheet Parent { get; }
    Point2d Position { get; set; }
    GeometryIntent PunchEdge { get; set; }
    PunchNoteQuantityEnum QuantityDefinition { get; set; }
    Box2d RangeBox { get; }
    bool Retrieved { get; } // since 2025
    object RetrievedFrom { get; } // since 2025
    double Rotation { get; set; }
    bool ShowTextBorder { get; set; }
    VerticalTextAlignmentEnum StackedTextPosition { get; set; }
    string Text { get; set; }
    ObjectTypeEnum Type { get; }
    UnitAttributes UnitAttributes { get; }
    bool UseBackgroundColor { get; set; }
    bool UsePartUnits { get; set; }
    VerticalTextAlignmentEnum VerticalJustification { get; set; }
    double WidthScale { get; set; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PunchNotes](../objects/PunchNotes.md).Add, [PunchNotes](../objects/PunchNotes.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box2d](../objects/Box2d.md), [Color](../objects/Color.md), [DimensionStyle](../objects/DimensionStyle.md), [GeometryIntent](../objects/GeometryIntent.md), [HorizontalTextAlignmentEnum](../enums/HorizontalTextAlignmentEnum.md), [Layer](../objects/Layer.md), [Leader](../objects/Leader.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [PunchNoteQuantityEnum](../enums/PunchNoteQuantityEnum.md), [Sheet](../objects/Sheet.md), [TextLineSpacingTypeEnum](../enums/TextLineSpacingTypeEnum.md), [UnitAttributes](../objects/UnitAttributes.md), [VerticalTextAlignmentEnum](../enums/VerticalTextAlignmentEnum.md)

