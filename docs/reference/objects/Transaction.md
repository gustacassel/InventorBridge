# Transaction

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransactionManager.CurrentTransaction`

```csharp
interface Transaction
{
    // Properties
    object Application { get; }
    CheckPointsEnumerator CheckPoints { get; }
    TransactionsEnumerator ChildTransactions { get; }
    string DisplayName { get; }
    Document Document { get; }
    bool HasParentTransaction { get; }
    int Id { get; }
    bool MergeWithPrevious { get; set; }
    TransactionManager Parent { get; }
    Transaction ParentTransaction { get; }
    TransactionStateEnum State { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Abort();
    void End();
    void IdentifyForDocumentOpen(Document Document);
    void SuppressChangeNotifications(ref string[] SuppressedEvents, bool Suppressed); // since 2025
}
```

**Returned by:** [CheckPoint](../objects/CheckPoint.md).ContainingTransaction, [Transaction](../objects/Transaction.md).ParentTransaction, [TransactionManager](../objects/TransactionManager.md).CurrentTransaction, [TransactionManager](../objects/TransactionManager.md).StartTransaction, [TransactionManager](../objects/TransactionManager.md).StartTransactionForDocumentOpen, [TransactionsEnumerator](../objects/TransactionsEnumerator.md).Item

**Referenced types:** [CheckPointsEnumerator](../objects/CheckPointsEnumerator.md), [Document](../objects/Document.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [TransactionManager](../objects/TransactionManager.md), [TransactionStateEnum](../enums/TransactionStateEnum.md), [TransactionsEnumerator](../objects/TransactionsEnumerator.md)

