# ModelStateTableColumn

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelStates.ModelStateTable.TableColumns.Item[…]`

```csharp
interface ModelStateTableColumn
{
    // Properties
    object Application { get; }
    int Count { get; }
    string DisplayHeading { get; }
    string FormattedHeading { get; }
    string Heading { get; }
    int Index { get; }
    ModelStateTableCell Item[object Index] { get; }
    ModelStateTable Parent { get; }
    iComponentColumnTypeEnum ReferencedDataType { get; }
    object ReferencedObject { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelStateTableColumns](../objects/ModelStateTableColumns.md).Item

**Referenced types:** [ModelStateTable](../objects/ModelStateTable.md), [ModelStateTableCell](../objects/ModelStateTableCell.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iComponentColumnTypeEnum](../enums/iComponentColumnTypeEnum.md)

