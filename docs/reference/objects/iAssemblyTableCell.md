# iAssemblyTableCell

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.iAssemblyMember.Row.Item[…]`

```csharp
interface iAssemblyTableCell
{
    // Properties
    object Application { get; }
    int Column { get; }
    bool HasFormula { get; }
    bool IsValid { get; }
    iAssemblyFactory Parent { get; }
    int Row { get; }
    ObjectTypeEnum Type { get; }
    string Value { get; set; }
}
```

**Returned by:** [iAssemblyTableColumn](../objects/iAssemblyTableColumn.md).Item, [iAssemblyTableRow](../objects/iAssemblyTableRow.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iAssemblyFactory](../objects/iAssemblyFactory.md)

