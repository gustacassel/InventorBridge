# CustomTable

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.CustomTables.Item[…]`

```csharp
interface CustomTable
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool BendDirectionReversed { get; set; }
    TextStyle ColumnHeaderTextStyle { get; set; }
    Columns Columns { get; }
    TextStyle DataTextStyle { get; set; }
    HeadingPlacementEnum HeadingPlacement { get; set; }
    Layer Layer { get; set; }
    int MaximumRows { get; set; }
    MergedCellsEnumerator MergedCells { get; } // since 2025
    int NumberOfSections { get; set; }
    TableFormat OverrideFormat { get; set; }
    object Parent { get; }
    Point2d Position { get; set; }
    Box2d RangeBox { get; }
    object ReferencedDocumentDescriptor { get; }
    double Rotation { get; set; }
    double RowGap { get; }
    LineSpacingEnum RowLineSpacing { get; set; }
    Rows Rows { get; }
    bool ShowTitle { get; set; }
    TableStyle Style { get; set; }
    TableDirectionEnum TableDirection { get; set; }
    TableSourceTypeEnum TableSource { get; }
    string Title { get; set; }
    TextStyle TitleTextStyle { get; set; }
    ObjectTypeEnum Type { get; }
    bool WrapAutomatically { get; set; }
    bool WrapLeft { get; set; }
    // Methods
    void AddBendTagsToView(DrawingView DrawingView); // since 2025
    void AddLink(string FullFileName);
    CustomTable CopyTo(Sheet TargetSheet);
    void Delete();
    void Export(string FileName, FileFormatEnum FileFormat, object Options = Missing);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    MergedCell MergeCells(Cell StartCell, Cell EndCell); // since 2025
    void Renumber();
    void Sort(string PrimaryColumnTitle, bool PrimaryColumnAscending = true, string SecondaryColumnTitle = "", bool SecondaryColumnAscending = true, string TertiaryColumnTitle = "", bool TertiaryColumnAscending = true);
    void Update();
}
```

**Returned by:** [Cell](../objects/Cell.md).Parent, [Column](../objects/Column.md).Parent, [CustomTable](../objects/CustomTable.md).CopyTo, [CustomTables](../objects/CustomTables.md).Add, [CustomTables](../objects/CustomTables.md).AddBendTableWithOptions, [CustomTables](../objects/CustomTables.md).AddCSVTable, [CustomTables](../objects/CustomTables.md).AddConfigurationTable, [CustomTables](../objects/CustomTables.md).AddExcelTable, [CustomTables](../objects/CustomTables.md).Item, [MergedCell](../objects/MergedCell.md).Parent, [Row](../objects/Row.md).Parent

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box2d](../objects/Box2d.md), [Cell](../objects/Cell.md), [Columns](../objects/Columns.md), [DrawingView](../objects/DrawingView.md), [FileFormatEnum](../enums/FileFormatEnum.md), [HeadingPlacementEnum](../enums/HeadingPlacementEnum.md), [Layer](../objects/Layer.md), [LineSpacingEnum](../enums/LineSpacingEnum.md), [MergedCell](../objects/MergedCell.md), [MergedCellsEnumerator](../objects/MergedCellsEnumerator.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [Rows](../objects/Rows.md), [Sheet](../objects/Sheet.md), [TableDirectionEnum](../enums/TableDirectionEnum.md), [TableFormat](../objects/TableFormat.md), [TableSourceTypeEnum](../enums/TableSourceTypeEnum.md), [TableStyle](../objects/TableStyle.md), [TextStyle](../objects/TextStyle.md)

