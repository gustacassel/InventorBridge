# iFeatureTableColumn

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.iFeatures.Item[…].iFeatureDefinition.iFeatureTable.iFeatureTableColumns.Item[…]`

```csharp
interface iFeatureTableColumn
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
    iFeatureTableCell Item[object Index] { get; }
    int Key { get; set; }
    iFeatureTable Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [iFeatureTableCell](../objects/iFeatureTableCell.md).Column, [iFeatureTableColumns](../objects/iFeatureTableColumns.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iFeatureTable](../objects/iFeatureTable.md), [iFeatureTableCell](../objects/iFeatureTableCell.md)

