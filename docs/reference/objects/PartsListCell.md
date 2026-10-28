# PartsListCell

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.PartsLists.Item[…].PartsListRows.Item[…].Item[…]`

```csharp
interface PartsListCell
{
    // Properties
    object Application { get; }
    PartsList Parent { get; }
    bool Static { get; set; }
    ObjectTypeEnum Type { get; }
    string Value { get; set; }
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartsListRow](../objects/PartsListRow.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartsList](../objects/PartsList.md)

