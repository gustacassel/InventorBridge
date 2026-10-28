# RevisionTableColumns

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.RevisionTables.Item[…].RevisionTableColumns`

```csharp
interface RevisionTableColumns
{
    // Properties
    object Application { get; }
    int Count { get; }
    RevisionTableColumn Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    RevisionTableColumn Add(RevisionTablePropertyEnum PropertyType, string PropertySetId = "", object PropertyIdentifier = Missing, int TargetIndex = 0, bool InsertBefore = true);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [RevisionTable](../objects/RevisionTable.md).RevisionTableColumns

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RevisionTableColumn](../objects/RevisionTableColumn.md), [RevisionTablePropertyEnum](../enums/RevisionTablePropertyEnum.md)

