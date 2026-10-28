# IRxTranslatorAddInServer

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface IRxTranslatorAddInServer
{
    // Properties
    object Automation { get; }
    SByte HasOpenOptions[DataMedium SourceData, TranslationContext Context, NameValueMap DefaultOptions] { get; }
    SByte HasSaveCopyAsOptions[object SourceObject, TranslationContext Context, NameValueMap DefaultOptions] { get; }
    // Methods
    void Activate(IRxApplicationAddInSite pAddInSite, SByte FirstTime);
    void Deactivate();
    void ExecuteCommand(int CommandID);
    void Open(DataMedium SourceData, TranslationContext Context, NameValueMap Options, out object TargetObject);
    void SaveCopyAs(object SourceObject, TranslationContext Context, NameValueMap Options, DataMedium TargetData);
    void ShowOpenOptions(DataMedium SourceData, TranslationContext Context, NameValueMap ChosenOptions);
    void ShowSaveCopyAsOptions(object SourceObject, TranslationContext Context, NameValueMap ChosenOptions);
}
```

**Referenced types:** [DataMedium](../objects/DataMedium.md), [NameValueMap](../objects/NameValueMap.md), [TranslationContext](../objects/TranslationContext.md)

