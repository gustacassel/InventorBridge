# WebBrowserDialogEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.WebBrowserDialogs.Item[…].WebBrowserDialogEvents`

```csharp
interface WebBrowserDialogEvents
{
    // Properties
    object Application { get; }
    WebBrowserDialog Parent { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnClose(EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnHelp(NameValueMap Context, out HandlingCodeEnum HandlingCode);
}
```

**Returned by:** [WebBrowserDialog](../objects/WebBrowserDialog.md).WebBrowserDialogEvents

**Referenced types:** [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [WebBrowserDialog](../objects/WebBrowserDialog.md)

