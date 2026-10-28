# HoleTableColumns

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.HoleTables.Item[…].HoleTableColumns`

```csharp
interface HoleTableColumns
{
    // Properties
    object Application { get; }
    int Count { get; }
    HoleTableColumn Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    HoleTableColumn Add(HolePropertyEnum PropertyType, string CustomPropertyName = "", int TargetIndex = 0, bool InsertBefore = true);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [HoleTable](../objects/HoleTable.md).HoleTableColumns

**Referenced types:** [HolePropertyEnum](../enums/HolePropertyEnum.md), [HoleTableColumn](../objects/HoleTableColumn.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

