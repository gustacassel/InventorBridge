# TransactionEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransactionManager.TransactionEvents`

```csharp
interface TransactionEvents
{
    // Properties
    object Application { get; }
    TransactionManager Parent { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnAbort(Transaction TransactionObject, NameValueMap Context, EventTimingEnum BeforeOrAfter);
    event OnCommit(Transaction TransactionObject, NameValueMap Context, EventTimingEnum BeforeOrAfter, out HandlingCodeEnum HandlingCode);
    event OnDelete(Transaction TransactionObject, NameValueMap Context, EventTimingEnum BeforeOrAfter);
    event OnRedo(Transaction TransactionObject, NameValueMap Context, EventTimingEnum BeforeOrAfter, out HandlingCodeEnum HandlingCode);
    event OnUndo(Transaction TransactionObject, NameValueMap Context, EventTimingEnum BeforeOrAfter, out HandlingCodeEnum HandlingCode);
}
```

**Returned by:** [TransactionManager](../objects/TransactionManager.md).TransactionEvents

**Referenced types:** [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Transaction](../objects/Transaction.md), [TransactionManager](../objects/TransactionManager.md)

