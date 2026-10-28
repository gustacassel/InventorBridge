# ModelStateTableCell

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelStates.ModelStateTable.TableRows.Item[…].Item[…]`

```csharp
interface ModelStateTableCell
{
    // Properties
    object Application { get; }
    int Column { get; }
    bool HasFormula { get; }
    bool IsValid { get; }
    ModelStateTable Parent { get; }
    int Row { get; }
    ObjectTypeEnum Type { get; }
    string Value { get; set; }
}
```

**Returned by:** [ModelStateTableColumn](../objects/ModelStateTableColumn.md).Item, [ModelStateTableRow](../objects/ModelStateTableRow.md).Item

**Referenced types:** [ModelStateTable](../objects/ModelStateTable.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

