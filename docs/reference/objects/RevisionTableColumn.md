# RevisionTableColumn

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.RevisionTables.Item[…].RevisionTableColumns.Item[…]`

```csharp
interface RevisionTableColumn
{
    // Properties
    object Application { get; }
    string CustomPropertyName { get; }
    RevisionTable Parent { get; }
    RevisionTablePropertyEnum PropertyType { get; }
    string Title { get; set; }
    HorizontalTextAlignmentEnum TitleHorizontalJustification { get; set; }
    ObjectTypeEnum Type { get; }
    HorizontalTextAlignmentEnum ValueHorizontalJustification { get; set; }
    double Width { get; set; }
    // Methods
    void Delete();
    void GetFilePropertyId(out string PropertySetId, out int PropId);
    void Reposition(int TargetIndex = 0, bool InsertBefore = true);
}
```

**Returned by:** [RevisionTableColumns](../objects/RevisionTableColumns.md).Add, [RevisionTableColumns](../objects/RevisionTableColumns.md).Item

**Referenced types:** [HorizontalTextAlignmentEnum](../enums/HorizontalTextAlignmentEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RevisionTable](../objects/RevisionTable.md), [RevisionTablePropertyEnum](../enums/RevisionTablePropertyEnum.md)

