# iFeatureTableColumns

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.iFeatures.Item[…].iFeatureDefinition.iFeatureTable.iFeatureTableColumns`

```csharp
interface iFeatureTableColumns
{
    // Properties
    object Application { get; }
    int Count { get; }
    iFeatureTableColumn Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [iFeatureTable](../objects/iFeatureTable.md).iFeatureTableColumns

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iFeatureTableColumn](../objects/iFeatureTableColumn.md)

