# ParameterTables

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).Parameters.ParameterTables`

```csharp
interface ParameterTables
{
    // Properties
    int Count { get; }
    ParameterTable Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ParameterTable AddExcelTable(string ExcelDocument, string StartCell, bool Link);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Parameters](../objects/Parameters.md).ParameterTables

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ParameterTable](../objects/ParameterTable.md)

