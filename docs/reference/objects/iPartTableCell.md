# iPartTableCell

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.iPartFactory.DisplayStyleColumn.Item[…]`

```csharp
interface iPartTableCell
{
    // Properties
    object Application { get; }
    int Column { get; }
    bool CustomCell { get; set; }
    string CustomIncrement { get; set; }
    string CustomRangeMaximum { get; set; }
    string CustomRangeMinimum { get; set; }
    bool HasFormula { get; }
    bool IsValid { get; }
    iPartFactory Parent { get; }
    int Row { get; }
    ObjectTypeEnum Type { get; }
    string Value { get; set; }
}
```

**Returned by:** [iPartTableColumn](../objects/iPartTableColumn.md).Item, [iPartTableRow](../objects/iPartTableRow.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iPartFactory](../objects/iPartFactory.md)

