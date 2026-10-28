# CustomTables

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.CustomTables`

```csharp
interface CustomTables
{
    // Properties
    object Application { get; }
    int Count { get; }
    CustomTable Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    CustomTable Add(string Title, Point2d PlacementPoint, int NumberOfColumns, int NumberOfRows, out string[] ColumnTitles, object Contents = Missing, object ColumnWidths = Missing, object RowHeights = Missing, object MoreInfo = Missing);
    CustomTable AddBendTableWithOptions(string SheetMetalFileName, Point2d PlacementPoint, object Options = Missing);
    CustomTable AddCSVTable(string CSVFileName, Point2d PlacementPoint, string Title = "", bool UseFirstRowForHeaders = true);
    CustomTable AddConfigurationTable(string ConfigurationFileName, Point2d PlacementPoint, string Title = "", object Columns = Missing);
    CustomTable AddExcelTable(string ExcelFileName, Point2d PlacementPoint, string Title = "", string StartCell = "A2", int ColumnHeaderRow = 1);
    TableFormat CreateTableFormat();
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sheet](../objects/Sheet.md).CustomTables

**Referenced types:** [CustomTable](../objects/CustomTable.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [TableFormat](../objects/TableFormat.md)

