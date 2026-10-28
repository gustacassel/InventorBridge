# InventorVBAArgument

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.VBAProjects.Item[…].InventorVBAComponents.Item[…].InventorVBAMembers.Item[…].Arguments.Item[…]`

```csharp
interface InventorVBAArgument
{
    // Properties
    string ArgumentType { get; }
    string Name { get; }
    InventorVBAMember Parent { get; }
    ObjectTypeEnum Type { get; }
    object Value { get; set; }
}
```

**Returned by:** [InventorVBAArguments](../objects/InventorVBAArguments.md).Item

**Referenced types:** [InventorVBAMember](../objects/InventorVBAMember.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

