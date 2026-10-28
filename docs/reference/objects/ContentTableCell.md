# ContentTableCell

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ContentCenter.TreeViewTopNode.Families.Item[…].TableRows.Item[…].Item[…]`

```csharp
interface ContentTableCell
{
    // Properties
    object Application { get; }
    int Column { get; set; }
    bool IsOverridden { get; }
    ContentFamily Parent { get; }
    int Row { get; set; }
    ObjectTypeEnum Type { get; }
    string Value { get; set; }
}
```

**Returned by:** [ContentFamily](../objects/ContentFamily.md).ActiveCell, [ContentTableRow](../objects/ContentTableRow.md).Item

**Referenced types:** [ContentFamily](../objects/ContentFamily.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

