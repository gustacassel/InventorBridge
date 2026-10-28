# Rows

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.CustomTables.Item[…].Rows`

```csharp
interface Rows
{
    // Properties
    object Application { get; }
    int Count { get; }
    Row Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    Row Add(int TargetIndex = 0, bool InsertBefore = true, object Contents = Missing, object Height = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [CustomTable](../objects/CustomTable.md).Rows

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Row](../objects/Row.md)

