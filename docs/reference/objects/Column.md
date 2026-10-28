# Column

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.CustomTables.Item[…].Columns.Item[…]`

```csharp
interface Column
{
    // Properties
    object Application { get; }
    string InternalTitle { get; }
    CustomTable Parent { get; }
    string Title { get; set; }
    HorizontalTextAlignmentEnum TitleHorizontalJustification { get; set; }
    ObjectTypeEnum Type { get; }
    HorizontalTextAlignmentEnum ValueHorizontalJustification { get; set; }
    double Width { get; set; }
    // Methods
    void Delete();
    void Reposition(int TargetIndex = 0, bool InsertBefore = true);
}
```

**Returned by:** [Columns](../objects/Columns.md).Add, [Columns](../objects/Columns.md).Item

**Referenced types:** [CustomTable](../objects/CustomTable.md), [HorizontalTextAlignmentEnum](../enums/HorizontalTextAlignmentEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

