# ClientResourceMap

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ClientResourceMaps.Item[…]`

```csharp
interface ClientResourceMap
{
    // Properties
    object Application { get; }
    string ClientId { get; }
    string Description { get; set; }
    int Id { get; }
    Application Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void SetBrowserIconData(NameValueMap IconData, string Theme, object AsDefault = Missing);
}
```

**Returned by:** [ClientResourceMaps](../objects/ClientResourceMaps.md).Add, [ClientResourceMaps](../objects/ClientResourceMaps.md).Item, [ClientResourceMaps](../objects/ClientResourceMaps.md).ItemById

**Referenced types:** [Application](../objects/Application.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

