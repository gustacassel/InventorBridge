# HoleTableRow

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.HoleTables.Item[…].HoleTableRows.Item[…]`

```csharp
interface HoleTableRow
{
    // Properties
    object Application { get; }
    int Count { get; }
    double Height { get; set; }
    HoleTag HoleTag { get; }
    HoleTableCell Item[object Index] { get; }
    HoleTable Parent { get; }
    object ReferencedHole { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [HoleTableRows](../objects/HoleTableRows.md).Add, [HoleTableRows](../objects/HoleTableRows.md).Item, [HoleTag](../objects/HoleTag.md).Parent

**Referenced types:** [HoleTable](../objects/HoleTable.md), [HoleTableCell](../objects/HoleTableCell.md), [HoleTag](../objects/HoleTag.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

