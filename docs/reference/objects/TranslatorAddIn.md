# TranslatorAddIn

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ApplicationAddIn](../objects/ApplicationAddIn.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ApplicationAddIns.Item[…] → (TranslatorAddIn)`

```csharp
interface TranslatorAddIn
{
    // Properties
    bool Activated { get; }
    ApplicationAddInTypeEnum AddInType { get; }
    object Application { get; }
    object Automation { get; }
    string ClassIdString { get; }
    string ClientId { get; }
    int DataVersion { get; set; }
    string Description { get; }
    string DisplayName { get; }
    string FileExtensions { get; }
    string FilterText { get; }
    bool HasOpenOptions[DataMedium SourceData, TranslationContext Context, NameValueMap DefaultOptions] { get; }
    bool HasSaveCopyAsOptions[object SourceObject, TranslationContext Context, NameValueMap DefaultOptions] { get; }
    bool Hidden { get; set; }
    AddInLicenseStatusEnum LicenseStatus { get; }
    bool LoadAutomatically { get; set; }
    AddInLoadBehaviorEnum LoadBehavior { get; }
    string Location { get; }
    object Parent { get; }
    string ProgId { get; }
    string ShortDisplayName { get; }
    string SupportsImportInto { get; }
    bool SupportsOpen { get; }
    string SupportsOpenInto { get; }
    bool SupportsSaveCopyAs { get; }
    string SupportsSaveCopyAsFrom { get; }
    bool TranslatorAvailable { get; set; }
    ObjectTypeEnum Type { get; }
    int UserInterfaceVersion { get; }
    bool UserUnloadable { get; set; }
    // Methods
    void Activate();
    void Deactivate();
    object GetThumbnail(DataMedium SourceData);
    void Open(DataMedium SourceData, TranslationContext Context, NameValueMap Options, out object TargetObject);
    void SaveCopyAs(object SourceObject, TranslationContext Context, NameValueMap Options, DataMedium TargetData);
    void ShowOpenOptions(DataMedium SourceData, TranslationContext Context, NameValueMap ChosenOptions);
    void ShowSaveCopyAsOptions(object SourceObject, TranslationContext Context, NameValueMap ChosenOptions);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AddInLicenseStatusEnum](../enums/AddInLicenseStatusEnum.md), [AddInLoadBehaviorEnum](../enums/AddInLoadBehaviorEnum.md), [ApplicationAddInTypeEnum](../enums/ApplicationAddInTypeEnum.md), [DataMedium](../objects/DataMedium.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [TranslationContext](../objects/TranslationContext.md)

