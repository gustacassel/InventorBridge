# SpellCheckOptions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.GeneralOptions.SpellCheckOptions`

```csharp
interface SpellCheckOptions
{
    // Properties
    CustomDictionary ActiveCustomDictionary { get; set; }
    object Application { get; }
    CustomDictionaries CustomDictionaries { get; }
    DictionaryLanguageTypeEnum DictionaryLanguage { get; set; }
    bool IgnoreCapitalizedWords { get; set; }
    bool IgnoreUppercaseWords { get; set; }
    bool IgnoreWordWithMixedCase { get; set; }
    bool IgnoreWordsContainingPunctuation { get; set; }
    bool IgnoreWordsWithNumbers { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [GeneralOptions](../objects/GeneralOptions.md).SpellCheckOptions

**Referenced types:** [CustomDictionaries](../objects/CustomDictionaries.md), [CustomDictionary](../objects/CustomDictionary.md), [DictionaryLanguageTypeEnum](../enums/DictionaryLanguageTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

