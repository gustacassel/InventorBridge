# DerivedParameterTables

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).Parameters.DerivedParameterTables`

```csharp
interface DerivedParameterTables
{
    // Properties
    int Count { get; }
    DerivedParameterTable Item[int Value] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    DerivedParameterTable Add(string FullFileName);
    DerivedParameterTable Add2(string FullFileName, object ParametersToLink = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Parameters](../objects/Parameters.md).DerivedParameterTables

**Referenced types:** [DerivedParameterTable](../objects/DerivedParameterTable.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

