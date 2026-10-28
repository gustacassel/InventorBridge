# ClientResourceMaps

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ClientResourceMaps`

```csharp
interface ClientResourceMaps
{
    // Properties
    object Application { get; }
    int Count { get; }
    ClientResourceMap Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ClientResourceMap Add(string ClientId, int Id);
    ClientResourceMap ItemById(string ClientId, int Id);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).ClientResourceMaps, [InventorServer](../objects/InventorServer.md).ClientResourceMaps

**Referenced types:** [ClientResourceMap](../objects/ClientResourceMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

