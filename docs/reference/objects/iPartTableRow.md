# iPartTableRow

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.iPartFactory.DefaultRow`

```csharp
interface iPartTableRow
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    int Count { get; }
    int Index { get; }
    bool IsPartNameBasedOnMemberName { get; }
    iPartTableCell Item[object Index] { get; }
    string MemberName { get; }
    iPartFactory Parent { get; }
    string PartName { get; set; }
    bool PartNameModifiable { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    iPartTableRow Copy(string NewMemberName = "");
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [iPartFactory](../objects/iPartFactory.md).DefaultRow, [iPartMember](../objects/iPartMember.md).Row, [iPartTableRow](../objects/iPartTableRow.md).Copy, [iPartTableRows](../objects/iPartTableRows.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iPartFactory](../objects/iPartFactory.md), [iPartTableCell](../objects/iPartTableCell.md)

