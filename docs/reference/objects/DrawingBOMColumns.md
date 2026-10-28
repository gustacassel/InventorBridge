# DrawingBOMColumns

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).DrawingBOMs.Item[…].DrawingBOMColumns`

```csharp
interface DrawingBOMColumns
{
    // Properties
    object Application { get; }
    int Count { get; }
    DrawingBOMColumn Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingBOM](../objects/DrawingBOM.md).DrawingBOMColumns

**Referenced types:** [DrawingBOMColumn](../objects/DrawingBOMColumn.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

