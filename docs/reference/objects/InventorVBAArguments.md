# InventorVBAArguments

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.VBAProjects.Item[…].InventorVBAComponents.Item[…].InventorVBAMembers.Item[…].Arguments`

```csharp
interface InventorVBAArguments
{
    // Properties
    int Count { get; }
    InventorVBAArgument Item[object Index] { get; }
    InventorVBAMember Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [InventorVBAMember](../objects/InventorVBAMember.md).Arguments

**Referenced types:** [InventorVBAArgument](../objects/InventorVBAArgument.md), [InventorVBAMember](../objects/InventorVBAMember.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

