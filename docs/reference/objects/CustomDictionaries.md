# CustomDictionaries

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.GeneralOptions.SpellCheckOptions.CustomDictionaries`

```csharp
interface CustomDictionaries
{
    // Properties
    object Application { get; }
    int Count { get; }
    CustomDictionary Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    CustomDictionary Add(string Name);
    CustomDictionary AddExisting(string FullFileName);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SpellCheckOptions](../objects/SpellCheckOptions.md).CustomDictionaries

**Referenced types:** [CustomDictionary](../objects/CustomDictionary.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

