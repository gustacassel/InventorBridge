# ModelParameters

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).Parameters.ModelParameters`

```csharp
interface ModelParameters
{
    // Properties
    int Count { get; }
    ModelParameter Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ModelParameter AddByExpression(string Expression, object UnitsSpecifier, string Name = "");
    ModelParameter AddByValue(object Value, object UnitsSpecifier, string Name = "");
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Parameters](../objects/Parameters.md).ModelParameters

**Referenced types:** [ModelParameter](../objects/ModelParameter.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

