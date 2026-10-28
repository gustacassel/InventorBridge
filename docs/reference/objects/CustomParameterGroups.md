# CustomParameterGroups

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).Parameters.CustomParameterGroups`

```csharp
interface CustomParameterGroups
{
    // Properties
    object Application { get; }
    int Count { get; }
    CustomParameterGroup Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    CustomParameterGroup Add(string DisplayName, string InternalName, string ClientId = "");
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Parameters](../objects/Parameters.md).CustomParameterGroups

**Referenced types:** [CustomParameterGroup](../objects/CustomParameterGroup.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

