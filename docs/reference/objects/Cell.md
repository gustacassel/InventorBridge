# Cell

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.CustomTables.Item[…].Rows.Item[…].Item[…]`

```csharp
interface Cell
{
    // Properties
    object Application { get; }
    int Column { get; } // since 2025
    bool IsMerged { get; } // since 2025
    MergedCell MergedCell { get; } // since 2025
    CustomTable Parent { get; }
    int Row { get; } // since 2025
    bool Static { get; set; }
    ObjectTypeEnum Type { get; }
    string Value { get; set; }
}
```

**Returned by:** [MergedCell](../objects/MergedCell.md).EndCell, [MergedCell](../objects/MergedCell.md).StartCell, [Row](../objects/Row.md).Item

**Referenced types:** [CustomTable](../objects/CustomTable.md), [MergedCell](../objects/MergedCell.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

