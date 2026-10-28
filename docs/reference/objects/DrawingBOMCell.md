# DrawingBOMCell

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).DrawingBOMs.Item[…].DrawingBOMRows.Item[…].Item[…]`

```csharp
interface DrawingBOMCell
{
    // Properties
    object Application { get; }
    DrawingBOM Parent { get; }
    bool Static { get; }
    ObjectTypeEnum Type { get; }
    string Value { get; }
}
```

**Returned by:** [DrawingBOMRow](../objects/DrawingBOMRow.md).Item

**Referenced types:** [DrawingBOM](../objects/DrawingBOM.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

