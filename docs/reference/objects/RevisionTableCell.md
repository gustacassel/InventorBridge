# RevisionTableCell

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.RevisionTables.Item[…].RevisionTableRows.Item[…].Item[…]`

```csharp
interface RevisionTableCell
{
    // Properties
    object Application { get; }
    string FormattedText { get; set; }
    RevisionTable Parent { get; }
    VerticalTextAlignmentEnum StackedTextPosition { get; set; }
    string Text { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [RevisionTableRow](../objects/RevisionTableRow.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RevisionTable](../objects/RevisionTable.md), [VerticalTextAlignmentEnum](../enums/VerticalTextAlignmentEnum.md)

