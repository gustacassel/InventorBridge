# HoleTableCell

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.HoleTables.Item[…].HoleTableRows.Item[…].Item[…]`

```csharp
interface HoleTableCell
{
    // Properties
    object Application { get; }
    string FormattedText { get; set; }
    HoleTable Parent { get; }
    VerticalTextAlignmentEnum StackedTextPosition { get; set; }
    string Text { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [HoleTableRow](../objects/HoleTableRow.md).Item

**Referenced types:** [HoleTable](../objects/HoleTable.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [VerticalTextAlignmentEnum](../enums/VerticalTextAlignmentEnum.md)

