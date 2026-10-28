# RevisionTable

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.RevisionTables.Item[…]`

```csharp
interface RevisionTable
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    TextStyle ColumnHeaderTextStyle { get; set; }
    TextStyle DataTextStyle { get; set; }
    double HeadingGap { get; }
    HeadingPlacementEnum HeadingPlacement { get; set; }
    bool IsSheetScope { get; }
    Layer Layer { get; set; }
    int MaximumRows { get; set; }
    int NumberOfSections { get; set; }
    Sheet Parent { get; }
    Point2d Position { get; set; }
    Box2d RangeBox { get; }
    RevisionTableColumns RevisionTableColumns { get; }
    RevisionTableRows RevisionTableRows { get; }
    double Rotation { get; set; }
    double RowGap { get; }
    LineSpacingEnum RowLineSpacing { get; set; }
    bool ShowTitle { get; set; }
    RevisionTableStyle Style { get; set; }
    TableDirectionEnum TableDirection { get; set; }
    string Title { get; set; }
    TextStyle TitleTextStyle { get; set; }
    ObjectTypeEnum Type { get; }
    bool UpdatePropertyToRevisionNumber { get; set; }
    bool WrapAutomatically { get; set; }
    bool WrapLeft { get; set; }
    // Methods
    RevisionTable CopyTo(Sheet TargetSheet);
    void Delete();
    void Export(string FileName, FileFormatEnum FileFormat, object Options = Missing);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void Sort(string PrimaryColumnTitle, bool PrimaryColumnAscending = true, string SecondaryColumnTitle = "", bool SecondaryColumnAscending = true, string TertiaryColumnTitle = "", bool TertiaryColumnAscending = true);
}
```

**Returned by:** [RevisionTable](../objects/RevisionTable.md).CopyTo, [RevisionTableCell](../objects/RevisionTableCell.md).Parent, [RevisionTableColumn](../objects/RevisionTableColumn.md).Parent, [RevisionTableRow](../objects/RevisionTableRow.md).Parent, [RevisionTables](../objects/RevisionTables.md).Add, [RevisionTables](../objects/RevisionTables.md).Add2, [RevisionTables](../objects/RevisionTables.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box2d](../objects/Box2d.md), [FileFormatEnum](../enums/FileFormatEnum.md), [HeadingPlacementEnum](../enums/HeadingPlacementEnum.md), [Layer](../objects/Layer.md), [LineSpacingEnum](../enums/LineSpacingEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [RevisionTableColumns](../objects/RevisionTableColumns.md), [RevisionTableRows](../objects/RevisionTableRows.md), [RevisionTableStyle](../objects/RevisionTableStyle.md), [Sheet](../objects/Sheet.md), [TableDirectionEnum](../enums/TableDirectionEnum.md), [TextStyle](../objects/TextStyle.md)

