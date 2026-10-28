# Columns

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.CustomTables.Item[…].Columns`

```csharp
interface Columns
{
    // Properties
    object Application { get; }
    int Count { get; }
    Column Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    Column Add(string Title, int TargetIndex = 0, bool InsertBefore = true, object Width = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [CustomTable](../objects/CustomTable.md).Columns

**Referenced types:** [Column](../objects/Column.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

