# CheckPointsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransactionManager.CurrentTransaction.CheckPoints`

```csharp
interface CheckPointsEnumerator
{
    // Properties
    int Count { get; }
    CheckPoint Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Transaction](../objects/Transaction.md).CheckPoints

**Referenced types:** [CheckPoint](../objects/CheckPoint.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

