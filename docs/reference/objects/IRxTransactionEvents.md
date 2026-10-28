# IRxTransactionEvents

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface IRxTransactionEvents
{
    // Methods
    void OnAbort(Transaction TransactionObject, EventTimingEnum BeforeOrAfter);
    void OnCommit(Transaction TransactionObject, EventTimingEnum BeforeOrAfter, out HandlingCodeEnum HandlingCode);
    void OnDelete(Transaction TransactionObject, EventTimingEnum BeforeOrAfter);
    void OnRedo(Transaction TransactionObject, EventTimingEnum BeforeOrAfter, out HandlingCodeEnum HandlingCode);
    void OnUndo(Transaction TransactionObject, EventTimingEnum BeforeOrAfter, out HandlingCodeEnum HandlingCode);
}
```

**Referenced types:** [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [Transaction](../objects/Transaction.md)

