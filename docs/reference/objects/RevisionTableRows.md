# RevisionTableRows

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.RevisionTables.Item[…].RevisionTableRows`

```csharp
interface RevisionTableRows
{
    // Properties
    object Application { get; }
    int Count { get; }
    RevisionTableRow Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    RevisionTableRow Add();
    RevisionTableRow AddCustom(int TargetIndex = 0, bool InsertBefore = true);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [RevisionTable](../objects/RevisionTable.md).RevisionTableRows

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RevisionTableRow](../objects/RevisionTableRow.md)

