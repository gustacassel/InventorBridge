# TableParameters

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).Parameters.ParameterTables.Item[…].TableParameters`

```csharp
interface TableParameters
{
    // Properties
    int Count { get; }
    TableParameter Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ParameterTable](../objects/ParameterTable.md).TableParameters

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [TableParameter](../objects/TableParameter.md)

