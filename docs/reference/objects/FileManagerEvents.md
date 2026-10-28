# FileManagerEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.FileManager.FileManagerEvents`

```csharp
interface FileManagerEvents
{
    // Properties
    object Application { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnFileCopy(string SourceFullFileName, string DestinationFullFileName, bool Copy, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnFileDelete(string FullFileName, NameValueMap Context, out HandlingCodeEnum HandlingCode);
}
```

**Returned by:** [FileManager](../objects/FileManager.md).FileManagerEvents

**Referenced types:** [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

