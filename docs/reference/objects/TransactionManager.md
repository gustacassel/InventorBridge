# TransactionManager

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransactionManager`

```csharp
interface TransactionManager
{
    // Properties
    object Application { get; }
    TransactionsEnumerator CommittedTransactions { get; }
    Transaction CurrentTransaction { get; }
    object Parent { get; }
    TransactionEvents TransactionEvents { get; }
    ObjectTypeEnum Type { get; }
    TransactionsEnumerator UndoneTransactions { get; }
    // Methods
    void ClearAllTransactions();
    void GoToCheckPoint(CheckPoint CheckPoint);
    void RedoTransaction();
    CheckPoint SetCheckPoint();
    Transaction StartTransaction(Document Document, string DisplayName);
    Transaction StartTransactionForDocumentOpen(string DisplayName);
    void UndoTransaction();
}
```

5 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).TransactionManager, [CheckPoint](../objects/CheckPoint.md).Parent, [InventorServer](../objects/InventorServer.md).TransactionManager, [Transaction](../objects/Transaction.md).Parent, [TransactionEvents](../objects/TransactionEvents.md).Parent

**Referenced types:** [CheckPoint](../objects/CheckPoint.md), [Document](../objects/Document.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Transaction](../objects/Transaction.md), [TransactionEvents](../objects/TransactionEvents.md), [TransactionsEnumerator](../objects/TransactionsEnumerator.md)

