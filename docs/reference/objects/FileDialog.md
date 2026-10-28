# FileDialog

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface FileDialog
{
    // Properties
    bool CancelError { get; set; }
    string DialogTitle { get; set; }
    FileDialogEvents FileDialogEvents { get; }
    string FileName { get; set; }
    string Filter { get; set; }
    int FilterIndex { get; set; }
    string InitialDirectory { get; set; }
    bool InsertMode { get; set; }
    bool MultiSelectEnabled { get; set; }
    NameValueMap OptionValues { get; }
    bool OptionsEnabled { get; set; }
    bool ShowQuickLaunch { get; set; }
    bool SuppressResolutionWarnings { get; set; }
    // Methods
    void SetHelpContext(string FileName, int Context);
    void SetHelpTopic(string FileName, string TopicName);
    void ShowOpen();
    void ShowSave();
}
```

6 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FileDialogEvents](../objects/FileDialogEvents.md).Parent

**Referenced types:** [FileDialogEvents](../objects/FileDialogEvents.md), [NameValueMap](../objects/NameValueMap.md)

