# ReferenceParameters

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).Parameters.ReferenceParameters`

```csharp
interface ReferenceParameters
{
    // Properties
    int Count { get; }
    ReferenceParameter Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ReferenceParameter AddByExpression(string Expression, object UnitsSpecifier, string Name = "");
    ReferenceParameter AddByValue(object Value, object UnitsSpecifier, string Name = "");
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Parameters](../objects/Parameters.md).ReferenceParameters

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferenceParameter](../objects/ReferenceParameter.md)

