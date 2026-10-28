# ModelStateTableRow

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelStates.ModelStateTable.TableRows.Item[…]`

```csharp
interface ModelStateTableRow
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    int Count { get; }
    int Index { get; }
    ModelStateTableCell Item[object Index] { get; }
    string MemberName { get; }
    ModelStateTable Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ModelStateTableRow Copy(string NewName = "");
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelStateTableRow](../objects/ModelStateTableRow.md).Copy, [ModelStateTableRows](../objects/ModelStateTableRows.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ModelStateTable](../objects/ModelStateTable.md), [ModelStateTableCell](../objects/ModelStateTableCell.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

