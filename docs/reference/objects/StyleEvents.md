# StyleEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.StyleEvents`

```csharp
interface StyleEvents
{
    // Properties
    object Application { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnActivateStyle(Document DocumentObject, object Style, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnDelete(Document DocumentObject, object Style, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnMigrateStyleLibrary(string LibraryPath, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnNewStyle(Document DocumentObject, object Style, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnStyleChange(Document DocumentObject, object Style, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
}
```

**Returned by:** [Application](../objects/Application.md).StyleEvents, [InventorServer](../objects/InventorServer.md).StyleEvents

**Referenced types:** [Document](../objects/Document.md), [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

