# InventorVBAComponent

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.VBAProjects.Item[…].InventorVBAComponents.Item[…]`

```csharp
interface InventorVBAComponent
{
    // Properties
    InventorVBAMembers InventorVBAMembers { get; }
    string Name { get; set; }
    InventorVBAProject Parent { get; }
    ObjectTypeEnum Type { get; }
    object VBComponent { get; }
}
```

**Returned by:** [InventorVBAComponents](../objects/InventorVBAComponents.md).Add, [InventorVBAComponents](../objects/InventorVBAComponents.md).Item, [InventorVBAMember](../objects/InventorVBAMember.md).Parent, [InventorVBAMembers](../objects/InventorVBAMembers.md).Parent

**Referenced types:** [InventorVBAMembers](../objects/InventorVBAMembers.md), [InventorVBAProject](../objects/InventorVBAProject.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

