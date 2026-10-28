# FileAccessEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.FileAccessEvents`

```csharp
interface FileAccessEvents
{
    // Properties
    object Application { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void FireOnFileResolution(string RelativeFileName, string LibraryName, out byte[] CustomLogicalName, EventTimingEnum BeforeOrAfter, NameValueMap Context, out string FullFileName, out HandlingCodeEnum HandlingCode);
    // Events
    event OnFileDirty(string RelativeFileName, string LibraryName, out byte[] CustomLogicalName, string FullFileName, Document DocumentObject, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnFileResolution(string RelativeFileName, string LibraryName, out byte[] CustomLogicalName, EventTimingEnum BeforeOrAfter, NameValueMap Context, out string FullFileName, out HandlingCodeEnum HandlingCode);
}
```

**Returned by:** [Application](../objects/Application.md).FileAccessEvents, [InventorServer](../objects/InventorServer.md).FileAccessEvents

**Referenced types:** [Document](../objects/Document.md), [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

