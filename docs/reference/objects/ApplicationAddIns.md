# ApplicationAddIns

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ApplicationAddIns`

```csharp
interface ApplicationAddIns
{
    // Properties
    int Count { get; }
    ApplicationAddIn Item[int Index] { get; }
    ApplicationAddIn ItemById[string ClientId] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void UpdateAddInList();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).ApplicationAddIns, [ApprenticeServer](../objects/ApprenticeServer.md).ApplicationAddIns, [ApprenticeServerComponent](../objects/ApprenticeServerComponent.md).ApplicationAddIns, [InventorServer](../objects/InventorServer.md).ApplicationAddIns

**Referenced types:** [ApplicationAddIn](../objects/ApplicationAddIn.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

