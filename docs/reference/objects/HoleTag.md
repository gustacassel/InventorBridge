# HoleTag

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.HoleTables.Item[…].HoleTableRows.Item[…].HoleTag`

```csharp
interface HoleTag
{
    // Properties
    object Application { get; }
    DimensionStyle DimensionStyle { get; set; }
    string FormattedText { get; set; }
    Layer Layer { get; set; }
    Leader Leader { get; }
    HoleTableRow Parent { get; }
    Point2d Position { get; set; }
    Box2d RangeBox { get; }
    bool ShowLeader { get; set; }
    VerticalTextAlignmentEnum StackedTextPosition { get; set; }
    string Text { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
}
```

**Returned by:** [HoleTableRow](../objects/HoleTableRow.md).HoleTag

**Referenced types:** [Box2d](../objects/Box2d.md), [DimensionStyle](../objects/DimensionStyle.md), [HoleTableRow](../objects/HoleTableRow.md), [Layer](../objects/Layer.md), [Leader](../objects/Leader.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [VerticalTextAlignmentEnum](../enums/VerticalTextAlignmentEnum.md)

