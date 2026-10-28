# ClientOperationEvents

Inventor API object · versions: 2025, 2026, 2027 · [index](../index.md)

**How to get it:** `Application.ClientOperationEvents`

```csharp
interface ClientOperationEvents
{
    // Properties
    object Application { get; } // since 2025
    object Parent { get; } // since 2025
    ObjectTypeEnum Type { get; } // since 2025
    // Methods
    void FireOnClientOperation(string ClientId, string OperationName, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode); // since 2025
    // Events
    event OnClientOperation(string ClientId, string OperationName, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode); // since 2025
}
```

**Returned by:** [Application](../objects/Application.md).ClientOperationEvents, [InventorServer](../objects/InventorServer.md).ClientOperationEvents

**Referenced types:** [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

