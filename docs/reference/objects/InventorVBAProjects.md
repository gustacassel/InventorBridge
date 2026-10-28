# InventorVBAProjects

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.VBAProjects`

```csharp
interface InventorVBAProjects
{
    // Properties
    int Count { get; }
    InventorVBAProject Item[int Index] { get; }
    Application Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    InventorVBAProject Add();
    void Open(string FullFileName);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).VBAProjects, [InventorServer](../objects/InventorServer.md).VBAProjects

**Referenced types:** [Application](../objects/Application.md), [InventorVBAProject](../objects/InventorVBAProject.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

