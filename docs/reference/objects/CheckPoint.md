# CheckPoint

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransactionManager.CurrentTransaction.CheckPoints.Item[…]`

```csharp
interface CheckPoint
{
    // Properties
    object Application { get; }
    Transaction ContainingTransaction { get; }
    string DisplayName { get; }
    int Id { get; }
    TransactionManager Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [CheckPointsEnumerator](../objects/CheckPointsEnumerator.md).Item, [TransactionManager](../objects/TransactionManager.md).SetCheckPoint

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Transaction](../objects/Transaction.md), [TransactionManager](../objects/TransactionManager.md)

