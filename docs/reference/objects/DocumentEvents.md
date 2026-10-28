# DocumentEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.DocumentEvents`

```csharp
interface DocumentEvents
{
    // Properties
    object Application { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnActivate(EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnChange(CommandTypesEnum ReasonsForChange, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnChangeSelectSet(EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnClose(EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnDeactivate(EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnDelete(object Entity, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnSave(EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
}
```

**Returned by:** [AssemblyDocument](../objects/AssemblyDocument.md).DocumentEvents, [Document](../objects/Document.md).DocumentEvents, [DrawingDocument](../objects/DrawingDocument.md).DocumentEvents, [PartDocument](../objects/PartDocument.md).DocumentEvents, [PresentationDocument](../objects/PresentationDocument.md).DocumentEvents

**Referenced types:** [CommandTypesEnum](../enums/CommandTypesEnum.md), [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

