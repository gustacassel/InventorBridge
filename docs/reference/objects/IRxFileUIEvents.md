# IRxFileUIEvents

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface IRxFileUIEvents
{
    // Methods
    void OnFileInsertDialog(ref string[] FileTypes, Document DocumentObject, int ParentHWND, out string FileName, out string RelativeFileName, out string LibraryName, out byte[] CustomLogicalName, out HandlingCodeEnum HandlingCode);
    void OnFileInsertNewDialog(string TemplateDir, ref string[] FileTypes, Document DocumentObject, int ParentHWND, out string TemplateFileName, out string FileName, out string RelativeFileName, out string LibraryName, out byte[] CustomLogicalName, out HandlingCodeEnum HandlingCode);
    void OnFileNewDialog(string TemplateDir, int ParentHWND, out string TemplateFileName, out HandlingCodeEnum HandlingCode);
    void OnFileOpenDialog(ref string[] FileTypes, int ParentHWND, out string FileName, out HandlingCodeEnum HandlingCode);
    void OnFileSaveAsDialog(ref string[] FileTypes, bool SaveCopyAs, int ParentHWND, out string FileName, out HandlingCodeEnum HandlingCode);
}
```

**Referenced types:** [Document](../objects/Document.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md)

