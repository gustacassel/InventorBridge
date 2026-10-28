# InventorVBAMember

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.VBAProjects.Item[…].InventorVBAComponents.Item[…].InventorVBAMembers.Item[…]`

```csharp
interface InventorVBAMember
{
    // Properties
    InventorVBAArguments Arguments { get; }
    MemberTypeEnum MemberType { get; }
    string Name { get; }
    InventorVBAComponent Parent { get; }
    ObjectTypeEnum Type { get; }
    object VBMember { get; }
    // Methods
    void Execute(ref object FunctionReturnValue = Missing);
}
```

**Returned by:** [InventorVBAArgument](../objects/InventorVBAArgument.md).Parent, [InventorVBAArguments](../objects/InventorVBAArguments.md).Parent, [InventorVBAMembers](../objects/InventorVBAMembers.md).Item

**Referenced types:** [InventorVBAArguments](../objects/InventorVBAArguments.md), [InventorVBAComponent](../objects/InventorVBAComponent.md), [MemberTypeEnum](../enums/MemberTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

