# IRxFileAccessEvents

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface IRxFileAccessEvents
{
    // Methods
    void OnFileDirty(string RelativeFileName, string LibraryName, ref byte[] CustomLogicalName, string FullFileName, Document DocumentObject, out HandlingCodeEnum HandlingCode);
    void OnFileResolution(string RelativeFileName, string LibraryName, ref byte[] CustomLogicalName, out string FullFileName, out HandlingCodeEnum HandlingCode);
}
```

**Referenced types:** [Document](../objects/Document.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md)

