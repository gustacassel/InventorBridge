# MergedCellsEnumerator

Inventor API object · versions: 2025, 2026, 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.CustomTables.Item[…].MergedCells`

```csharp
interface MergedCellsEnumerator
{
    // Properties
    object Application { get; } // since 2025
    int Count { get; } // since 2025
    MergedCell Item[int Index] { get; } // since 2025
    ObjectTypeEnum Type { get; } // since 2025
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [CustomTable](../objects/CustomTable.md).MergedCells

**Referenced types:** [MergedCell](../objects/MergedCell.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

