# DocumentInterest

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.DocumentInterests.Item[…]`

```csharp
interface DocumentInterest
{
    // Properties
    object Application { get; }
    string ClientData { get; set; }
    string ClientId { get; }
    int DataVersion { get; set; }
    DocumentInterestTypeEnum InterestType { get; set; }
    string Name { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
}
```

**Returned by:** [DocumentInterests](../objects/DocumentInterests.md).Add, [DocumentInterests](../objects/DocumentInterests.md).Item

**Referenced types:** [DocumentInterestTypeEnum](../enums/DocumentInterestTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

