# iFeatureTableRow

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.iFeatures.Item[…].iFeatureDefinition.iFeatureTable.DefaultRow`

```csharp
interface iFeatureTableRow
{
    // Properties
    object Application { get; }
    int Count { get; }
    int Index { get; }
    iFeatureTableCell Item[object Index] { get; }
    string MemberName { get; }
    iFeatureTable Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    iFeatureTableRow Copy();
    void Delete();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [iFeatureDefinition](../objects/iFeatureDefinition.md).ActiveTableRow, [iFeatureTable](../objects/iFeatureTable.md).DefaultRow, [iFeatureTableCell](../objects/iFeatureTableCell.md).Row, [iFeatureTableRow](../objects/iFeatureTableRow.md).Copy, [iFeatureTableRows](../objects/iFeatureTableRows.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iFeatureTable](../objects/iFeatureTable.md), [iFeatureTableCell](../objects/iFeatureTableCell.md)

