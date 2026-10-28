# ClientNodeResources

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.BrowserPanes.ClientNodeResources`

```csharp
interface ClientNodeResources
{
    // Properties
    object Application { get; }
    int Count { get; }
    ClientNodeResource Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ClientNodeResource AddNodeResource(string ClientId, int Id, string IconName);
    ClientNodeResource ItemById(string ClientId, int Id);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BrowserPanes](../objects/BrowserPanes.md).ClientNodeResources

**Referenced types:** [ClientNodeResource](../objects/ClientNodeResource.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

