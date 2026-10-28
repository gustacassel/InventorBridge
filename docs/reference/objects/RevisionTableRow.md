# RevisionTableRow

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.RevisionTables.Item[…].RevisionTableRows.Item[…]`

```csharp
interface RevisionTableRow
{
    // Properties
    object Application { get; }
    int Count { get; }
    bool Custom { get; }
    double Height { get; set; }
    bool IsActiveRow { get; set; }
    RevisionTableCell Item[object Index] { get; }
    RevisionTable Parent { get; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void Delete();
    void Reposition(int TargetIndex = 0, bool InsertBefore = true);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [RevisionTableRows](../objects/RevisionTableRows.md).Add, [RevisionTableRows](../objects/RevisionTableRows.md).AddCustom, [RevisionTableRows](../objects/RevisionTableRows.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RevisionTable](../objects/RevisionTable.md), [RevisionTableCell](../objects/RevisionTableCell.md)

