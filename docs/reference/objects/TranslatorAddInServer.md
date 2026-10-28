# TranslatorAddInServer

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface TranslatorAddInServer
{
    // Properties
    object Automation { get; }
    bool HasOpenOptions[DataMedium SourceData, TranslationContext Context, NameValueMap DefaultOptions] { get; }
    bool HasSaveCopyAsOptions[object SourceObject, TranslationContext Context, NameValueMap DefaultOptions] { get; }
    // Methods
    void Activate(ApplicationAddInSite AddInSiteObject, bool FirstTime);
    void Deactivate();
    void ExecuteCommand(int CommandID);
    object GetThumbnail(DataMedium SourceData);
    void Open(DataMedium SourceData, TranslationContext Context, NameValueMap Options, out object TargetObject);
    void SaveCopyAs(object SourceObject, TranslationContext Context, NameValueMap Options, DataMedium TargetData);
    void ShowOpenOptions(DataMedium SourceData, TranslationContext Context, NameValueMap ChosenOptions);
    void ShowSaveCopyAsOptions(object SourceObject, TranslationContext Context, NameValueMap ChosenOptions);
}
```

**Referenced types:** [ApplicationAddInSite](../objects/ApplicationAddInSite.md), [DataMedium](../objects/DataMedium.md), [NameValueMap](../objects/NameValueMap.md), [TranslationContext](../objects/TranslationContext.md)

