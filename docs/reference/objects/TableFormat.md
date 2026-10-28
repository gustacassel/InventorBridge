# TableFormat

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.CustomTables.Item[…].OverrideFormat`

```csharp
interface TableFormat
{
    // Properties
    object Application { get; }
    Color InsideLineColor { get; set; }
    double InsideLineWeight { get; set; }
    Color OutsideLineColor { get; set; }
    double OutsideLineWeight { get; set; }
    TextStyle TextStyle { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [CustomTable](../objects/CustomTable.md).OverrideFormat, [CustomTables](../objects/CustomTables.md).CreateTableFormat

**Referenced types:** [Color](../objects/Color.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [TextStyle](../objects/TextStyle.md)

