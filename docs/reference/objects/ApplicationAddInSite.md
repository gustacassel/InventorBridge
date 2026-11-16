# ApplicationAddInSite

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface ApplicationAddInSite
{
    // Properties
    Application Application { get; }
    InventorServer InventorServer { get; } // hidden in 2024, 2025, 2026: there, prefer the newer members
    ApplicationAddIn Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

8 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [Application](../objects/Application.md), [ApplicationAddIn](../objects/ApplicationAddIn.md), [InventorServer](../objects/InventorServer.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

