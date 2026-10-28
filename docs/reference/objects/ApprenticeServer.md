# ApprenticeServer

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface ApprenticeServer
{
    // Properties
    ApplicationAddIns ApplicationAddIns { get; }
    DesignProjectManager DesignProjectManager { get; }
    bool DisplayAffinity { get; set; }
    DisplayOptions DisplayOptions { get; }
    ApprenticeServerDocument Document { get; }
    FileManager FileManager { get; }
    FileOptions FileOptions { get; }
    FileSaveAs FileSaveAs { get; }
    HardwareOptions HardwareOptions { get; }
    HelpManager HelpManager { get; }
    string InstallPath { get; }
    int Locale { get; }
    bool MultiUserExternallyManaged { get; set; }
    MultiUserModeEnum MultiUserMode { get; set; }
    SoftwareVersion SoftwareVersion { get; }
    TransientGeometry TransientGeometry { get; }
    TransientObjects TransientObjects { get; }
    ObjectTypeEnum Type { get; }
    string UserName { get; set; }
    // Methods
    void Close();
    void Close2(bool ForceDependentsToClose = false);
    ApprenticeServerDocument Open(string FullDocumentName);
    ApprenticeServerDocument OpenWithOptions(string FullDocumentName, NameValueMap Options);
}
```

19 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [ApplicationAddIns](../objects/ApplicationAddIns.md), [ApprenticeServerDocument](../objects/ApprenticeServerDocument.md), [DesignProjectManager](../objects/DesignProjectManager.md), [DisplayOptions](../objects/DisplayOptions.md), [FileManager](../objects/FileManager.md), [FileOptions](../objects/FileOptions.md), [FileSaveAs](../objects/FileSaveAs.md), [HardwareOptions](../objects/HardwareOptions.md), [HelpManager](../objects/HelpManager.md), [MultiUserModeEnum](../enums/MultiUserModeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SoftwareVersion](../objects/SoftwareVersion.md), [TransientGeometry](../objects/TransientGeometry.md), [TransientObjects](../objects/TransientObjects.md)

