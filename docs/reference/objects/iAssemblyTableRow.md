# iAssemblyTableRow

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.iAssemblyMember.Row`

```csharp
interface iAssemblyTableRow
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    int Count { get; }
    string DocumentName { get; set; }
    bool DocumentNameModifiable { get; }
    int Index { get; }
    bool IsDocumentNameBasedOnMemberName { get; }
    iAssemblyTableCell Item[object Index] { get; }
    string MemberName { get; }
    iAssemblyFactory Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    iAssemblyTableRow Copy(string NewMemberName = "");
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    bool IsExcluded(object Object);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [iAssemblyFactory](../objects/iAssemblyFactory.md).DefaultRow, [iAssemblyMember](../objects/iAssemblyMember.md).Row, [iAssemblyTableRow](../objects/iAssemblyTableRow.md).Copy, [iAssemblyTableRows](../objects/iAssemblyTableRows.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iAssemblyFactory](../objects/iAssemblyFactory.md), [iAssemblyTableCell](../objects/iAssemblyTableCell.md)

