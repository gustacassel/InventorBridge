# FileUIEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.FileUIEvents`

```csharp
interface FileUIEvents
{
    // Properties
    Application Application { get; }
    Application Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void PopulateFileMetadata(ObjectCollection FileMetadataObjects, string Formulae, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    // Events
    event OnFileInsertDialog(ref string[] FileTypes, Document DocumentObject, int ParentHWND, out string FileName, out string RelativeFileName, out string LibraryName, out byte[] CustomLogicalName, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnFileInsertNewDialog(string TemplateDir, ref string[] FileTypes, Document DocumentObject, int ParentHWND, out string TemplateFileName, out string FileName, out string RelativeFileName, out string LibraryName, out byte[] CustomLogicalName, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnFileNew(DocumentTypeEnum DocumentType, out string TemplateFileName, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnFileNewDialog(string TemplateDir, int ParentHWND, out string TemplateFileName, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnFileOpenDialog(ref string[] FileTypes, int ParentHWND, out string FileName, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnFileOpenFromMRU(out string FullFileName, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnFileSaveAsDialog(ref string[] FileTypes, bool SaveCopyAs, int ParentHWND, out string FileName, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnPopulateFileMetadata(ObjectsEnumerator FileMetadataObjects, string Formulae, NameValueMap Context, out HandlingCodeEnum HandlingCode);
}
```

**Returned by:** [Application](../objects/Application.md).FileUIEvents

**Referenced types:** [Application](../objects/Application.md), [Document](../objects/Document.md), [DocumentTypeEnum](../enums/DocumentTypeEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md)

