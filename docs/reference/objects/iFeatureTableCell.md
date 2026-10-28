# iFeatureTableCell

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.iFeatures.Item[…].iFeatureDefinition.iFeatureTable.DefaultRow.Item[…]`

```csharp
interface iFeatureTableCell
{
    // Properties
    object Application { get; }
    iFeatureTableColumn Column { get; }
    bool CustomCell { get; set; }
    string CustomIncrement { get; set; }
    string CustomRangeMaximum { get; set; }
    string CustomRangeMinimum { get; set; }
    bool HasFormula { get; }
    bool IsValid { get; }
    iFeatureTable Parent { get; }
    iFeatureTableRow Row { get; }
    ObjectTypeEnum Type { get; }
    string Value { get; set; }
}
```

**Returned by:** [iFeatureTableColumn](../objects/iFeatureTableColumn.md).Item, [iFeatureTableRow](../objects/iFeatureTableRow.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iFeatureTable](../objects/iFeatureTable.md), [iFeatureTableColumn](../objects/iFeatureTableColumn.md), [iFeatureTableRow](../objects/iFeatureTableRow.md)

