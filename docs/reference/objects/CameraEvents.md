# CameraEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.CameraEvents`

```csharp
interface CameraEvents
{
    // Properties
    object Application { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnCameraChange(View View, EventTimingEnum BeforeOrAfter, NameValueMap Context);
}
```

**Returned by:** [Application](../objects/Application.md).CameraEvents

**Referenced types:** [EventTimingEnum](../enums/EventTimingEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [View](../objects/View.md)

