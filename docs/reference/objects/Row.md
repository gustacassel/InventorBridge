# Row

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.CustomTables.Item[…].Rows.Item[…]`

```csharp
interface Row
{
    // Properties
    object Application { get; }
    int Count { get; }
    double Height { get; set; }
    Cell Item[object Index] { get; }
    CustomTable Parent { get; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void Delete();
    void Reposition(int TargetIndex = 0, bool InsertBefore = true);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Rows](../objects/Rows.md).Add, [Rows](../objects/Rows.md).Item

**Referenced types:** [Cell](../objects/Cell.md), [CustomTable](../objects/CustomTable.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

