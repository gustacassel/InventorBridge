# InventorVBAMembers

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.VBAProjects.Item[…].InventorVBAComponents.Item[…].InventorVBAMembers`

```csharp
interface InventorVBAMembers
{
    // Properties
    int Count { get; }
    InventorVBAMember Item[object Index] { get; }
    InventorVBAComponent Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [InventorVBAComponent](../objects/InventorVBAComponent.md).InventorVBAMembers

**Referenced types:** [InventorVBAComponent](../objects/InventorVBAComponent.md), [InventorVBAMember](../objects/InventorVBAMember.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

