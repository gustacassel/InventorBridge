# HoleTableColumn

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.HoleTables.Item[…].HoleTableColumns.Item[…]`

```csharp
interface HoleTableColumn
{
    // Properties
    object Application { get; }
    string CustomPropertyName { get; }
    HoleTable Parent { get; }
    HolePropertyEnum PropertyType { get; }
    string Title { get; set; }
    ObjectTypeEnum Type { get; }
    UnitsFormatting UnitsFormatting { get; }
    double Width { get; set; }
    // Methods
    void Delete();
    void Reposition(int TargetIndex = 0, bool InsertBefore = true);
}
```

**Returned by:** [HoleTableColumns](../objects/HoleTableColumns.md).Add, [HoleTableColumns](../objects/HoleTableColumns.md).Item

**Referenced types:** [HolePropertyEnum](../enums/HolePropertyEnum.md), [HoleTable](../objects/HoleTable.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [UnitsFormatting](../objects/UnitsFormatting.md)

