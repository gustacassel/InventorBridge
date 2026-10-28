# DerivedParameters

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).Parameters.DerivedParameterTables.Item[…].DerivedParameters`

```csharp
interface DerivedParameters
{
    // Properties
    int Count { get; }
    DerivedParameter Item[object Value] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DerivedParameterTable](../objects/DerivedParameterTable.md).DerivedParameters

**Referenced types:** [DerivedParameter](../objects/DerivedParameter.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

