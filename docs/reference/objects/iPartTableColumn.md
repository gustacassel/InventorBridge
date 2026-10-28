# iPartTableColumn

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.iPartFactory.DisplayStyleColumn`

```csharp
interface iPartTableColumn
{
    // Properties
    object Application { get; }
    int Count { get; }
    bool CustomColumn { get; set; }
    string CustomIncrement { get; set; }
    string CustomRangeMaximum { get; set; }
    string CustomRangeMinimum { get; set; }
    string DisplayHeading { get; }
    string FormattedHeading { get; }
    string Heading { get; }
    int Index { get; }
    iPartTableCell Item[object Index] { get; }
    int Key { get; set; }
    iPartFactory Parent { get; }
    iComponentColumnTypeEnum ReferencedDataType { get; }
    object ReferencedObject { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [iPartFactory](../objects/iPartFactory.md).DisplayStyleColumn, [iPartFactory](../objects/iPartFactory.md).FileNameColumn, [iPartFactory](../objects/iPartFactory.md).MaterialColumn, [iPartTableColumns](../objects/iPartTableColumns.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iComponentColumnTypeEnum](../enums/iComponentColumnTypeEnum.md), [iPartFactory](../objects/iPartFactory.md), [iPartTableCell](../objects/iPartTableCell.md)

