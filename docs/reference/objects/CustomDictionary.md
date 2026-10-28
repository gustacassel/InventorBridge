# CustomDictionary

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.GeneralOptions.SpellCheckOptions.CustomDictionaries.Item[…]`

```csharp
interface CustomDictionary
{
    // Properties
    object Application { get; }
    string FullFileName { get; }
    string Name { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void AddWord(string Word);
    void DeleteWord(string Word);
    void GetWords(out string[] Words);
    void ImportWordsFromExistingDictionary(string FullFileName);
    void Remove();
}
```

**Returned by:** [CustomDictionaries](../objects/CustomDictionaries.md).Add, [CustomDictionaries](../objects/CustomDictionaries.md).AddExisting, [CustomDictionaries](../objects/CustomDictionaries.md).Item, [SpellCheckOptions](../objects/SpellCheckOptions.md).ActiveCustomDictionary

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

