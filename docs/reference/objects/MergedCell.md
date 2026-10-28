# MergedCell

Inventor API object · versions: 2025, 2026, 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.CustomTables.Item[…].MergedCells.Item[…]`

```csharp
interface MergedCell
{
    // Properties
    object Application { get; } // since 2025
    Cell EndCell { get; } // since 2025
    CustomTable Parent { get; } // since 2025
    Cell StartCell { get; } // since 2025
    ObjectTypeEnum Type { get; } // since 2025
    // Methods
    void Unmerge(); // since 2025
}
```

**Returned by:** [Cell](../objects/Cell.md).MergedCell, [CustomTable](../objects/CustomTable.md).MergeCells, [MergedCellsEnumerator](../objects/MergedCellsEnumerator.md).Item

**Referenced types:** [Cell](../objects/Cell.md), [CustomTable](../objects/CustomTable.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

