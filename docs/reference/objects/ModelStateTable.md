# ModelStateTable

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelStates.ModelStateTable`

```csharp
interface ModelStateTable
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ModelStates Parent { get; }
    ModelStateTableColumns TableColumns { get; }
    ModelStateTableRows TableRows { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [ModelStateTableCell](../objects/ModelStateTableCell.md).Parent, [ModelStateTableColumn](../objects/ModelStateTableColumn.md).Parent, [ModelStateTableRow](../objects/ModelStateTableRow.md).Parent, [ModelStates](../objects/ModelStates.md).ModelStateTable

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ModelStateTableColumns](../objects/ModelStateTableColumns.md), [ModelStateTableRows](../objects/ModelStateTableRows.md), [ModelStates](../objects/ModelStates.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

