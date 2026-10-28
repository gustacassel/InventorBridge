# ContentTableRow

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ContentCenter.TreeViewTopNode.Families.Item[…].TableRows.Item[…]`

```csharp
interface ContentTableRow
{
    // Properties
    object Application { get; }
    string ContentIdentifier { get; }
    int Count { get; }
    int Index { get; }
    string InternalName { get; }
    bool IsSuppressed { get; set; }
    ContentTableCell Item[object Index] { get; }
    ContentFamily Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    string GetCellValue(object CellIndex, object CustomInput = Missing);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ContentTableRows](../objects/ContentTableRows.md).Add, [ContentTableRows](../objects/ContentTableRows.md).Item

**Referenced types:** [ContentFamily](../objects/ContentFamily.md), [ContentTableCell](../objects/ContentTableCell.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

