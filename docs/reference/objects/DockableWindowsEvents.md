# DockableWindowsEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.UserInterfaceManager.DockableWindows.Events`

```csharp
interface DockableWindowsEvents
{
    // Properties
    object Application { get; }
    DockableWindows Parent { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnHelp(DockableWindow DockableWindow, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnHide(DockableWindow DockableWindow, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnShow(DockableWindow DockableWindow, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
}
```

**Returned by:** [DockableWindows](../objects/DockableWindows.md).Events

**Referenced types:** [DockableWindow](../objects/DockableWindow.md), [DockableWindows](../objects/DockableWindows.md), [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

