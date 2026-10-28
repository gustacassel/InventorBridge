# UserParameters

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).Parameters.UserParameters`

```csharp
interface UserParameters
{
    // Properties
    int Count { get; }
    UserParameter Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    UserParameter AddByExpression(string Name, string Expression, object UnitsSpecifier);
    UserParameter AddByValue(string Name, object Value, object UnitsSpecifier);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Parameters](../objects/Parameters.md).UserParameters

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [UserParameter](../objects/UserParameter.md)

