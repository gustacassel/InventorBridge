# CustomParameterGroup

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).Parameters.CustomParameterGroups.Item[…]`

```csharp
interface CustomParameterGroup
{
    // Properties
    object Application { get; }
    string ClientId { get; }
    int Count { get; }
    ActionTypeEnum DisabledActionTypes { get; set; }
    string DisplayName { get; set; }
    string InternalName { get; }
    Parameter Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Add(Parameter Parameter);
    void Delete(bool DeleteParameters = false);
    void Remove(int Index);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [CustomParameterGroups](../objects/CustomParameterGroups.md).Add, [CustomParameterGroups](../objects/CustomParameterGroups.md).Item

**Referenced types:** [ActionTypeEnum](../enums/ActionTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md)

