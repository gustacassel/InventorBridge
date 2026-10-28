# iFeatureTable

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.iFeatures.Item[…].iFeatureDefinition.iFeatureTable`

```csharp
interface iFeatureTable
{
    // Properties
    object Application { get; }
    iFeatureTableRow DefaultRow { get; set; }
    object ExcelWorkSheet { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    iFeatureTableColumns iFeatureTableColumns { get; }
    iFeatureTableRows iFeatureTableRows { get; }
    // Methods
    void Delete();
    void Export(string FileName, FileFormatEnum FileFormat, object Options = Missing);
}
```

**Returned by:** [iFeatureDefinition](../objects/iFeatureDefinition.md).iFeatureTable, [iFeatureTableCell](../objects/iFeatureTableCell.md).Parent, [iFeatureTableColumn](../objects/iFeatureTableColumn.md).Parent, [iFeatureTableRow](../objects/iFeatureTableRow.md).Parent

**Referenced types:** [FileFormatEnum](../enums/FileFormatEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iFeatureTableColumns](../objects/iFeatureTableColumns.md), [iFeatureTableRow](../objects/iFeatureTableRow.md), [iFeatureTableRows](../objects/iFeatureTableRows.md)

