# ModelStateEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ModelStateEvents`

```csharp
interface ModelStateEvents
{
    // Properties
    object Application { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnActivateModelState(Document DocumentObject, ModelState ModelState, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnDeleteModelState(Document DocumentObject, object ModelState, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnNewModelState(Document DocumentObject, ModelState ModelState, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
}
```

**Returned by:** [Application](../objects/Application.md).ModelStateEvents, [InventorServer](../objects/InventorServer.md).ModelStateEvents

**Referenced types:** [Document](../objects/Document.md), [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [ModelState](../objects/ModelState.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

