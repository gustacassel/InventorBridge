# DrawingBOMRow

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).DrawingBOMs.Item[…].DrawingBOMRows.Item[…]`

```csharp
interface DrawingBOMRow
{
    // Properties
    object Application { get; }
    BOMRow BOMRow { get; }
    bool Ballooned { get; }
    int Count { get; }
    bool Custom { get; }
    DrawingBOMCell Item[object Index] { get; }
    DrawingBOM Parent { get; }
    ObjectTypeEnum Type { get; }
    bool Virtual { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BalloonValueSet](../objects/BalloonValueSet.md).ReferencedRow, [DrawingBOMRows](../objects/DrawingBOMRows.md).Item

**Referenced types:** [BOMRow](../objects/BOMRow.md), [DrawingBOM](../objects/DrawingBOM.md), [DrawingBOMCell](../objects/DrawingBOMCell.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

