# InventorVBAComponents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.VBAProjects.Item[…].InventorVBAComponents`

```csharp
interface InventorVBAComponents
{
    // Properties
    int Count { get; }
    InventorVBAComponent Item[object Index] { get; }
    InventorVBAProject Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    InventorVBAComponent Add(string Name);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [InventorVBAProject](../objects/InventorVBAProject.md).InventorVBAComponents

**Referenced types:** [InventorVBAComponent](../objects/InventorVBAComponent.md), [InventorVBAProject](../objects/InventorVBAProject.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

