# ContentTableRows

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ContentCenter.TreeViewTopNode.Families.Item[…].TableRows`

```csharp
interface ContentTableRows
{
    // Properties
    object Application { get; }
    int Count { get; }
    ContentTableRow Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ContentTableRow Add(out string[] RowData, int Position = -1);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ContentFamily](../objects/ContentFamily.md).TableRows

**Referenced types:** [ContentTableRow](../objects/ContentTableRow.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

