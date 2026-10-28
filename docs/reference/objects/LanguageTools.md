# LanguageTools

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.LanguageTools`

```csharp
interface LanguageTools
{
    // Properties
    object Application { get; }
    string CurrentPrimaryModelStateString { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    bool GetiComponentStringValue(string iComponentString);
    bool IsValidPrimaryModelState(string PrimaryName);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).LanguageTools, [InventorServer](../objects/InventorServer.md).LanguageTools

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

