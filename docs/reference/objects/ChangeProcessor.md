# ChangeProcessor

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ChangeManager.Item[…].Item[…].CreateChangeProcessor(…)`

```csharp
interface ChangeProcessor
{
    // Properties
    object Application { get; }
    CommandTypesEnum ChangeType { get; set; }
    bool DisplayMessages { get; set; }
    bool GlobalChangeProcess { get; set; }
    bool GlobalChangeProcessAborted { get; }
    bool MergeWithPrevious { get; set; }
    ButtonTypeEnum MessageDialogUserChoice { get; }
    ChangeDefinition Parent { get; }
    bool Transact { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Execute(Document Document);
    void SetAffectedDocuments(ref string[] FullDocumentNames, object ReasonsForChange = Missing);
    void SetMessageDialogOptions(bool AllowAccept, bool AllowEdit);
    void SuppressChangeNotifications(ref string[] SuppressedEvents, bool Suppressed); // since 2025
    // Events
    event OnExecute(Document Document, NameValueMap Context, out bool Succeeded);
    event OnReadFromScript(Document Document, string Inputs, NameValueMap Context);
    event OnTerminate();
    event OnWriteToScript(Document Document, NameValueMap Context, out string ResultInputs);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ChangeDefinition](../objects/ChangeDefinition.md).CreateChangeProcessor

**Referenced types:** [ButtonTypeEnum](../enums/ButtonTypeEnum.md), [ChangeDefinition](../objects/ChangeDefinition.md), [CommandTypesEnum](../enums/CommandTypesEnum.md), [Document](../objects/Document.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

