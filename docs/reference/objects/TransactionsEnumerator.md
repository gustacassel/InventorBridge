# TransactionsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransactionManager.CommittedTransactions`

```csharp
interface TransactionsEnumerator
{
    // Properties
    int Count { get; }
    Transaction Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Transaction](../objects/Transaction.md).ChildTransactions, [TransactionManager](../objects/TransactionManager.md).CommittedTransactions, [TransactionManager](../objects/TransactionManager.md).UndoneTransactions

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Transaction](../objects/Transaction.md)

