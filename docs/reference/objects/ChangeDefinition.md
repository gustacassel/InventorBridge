# ChangeDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ChangeManager.Item[…].Item[…]`

```csharp
interface ChangeDefinition
{
    // Properties
    object Application { get; }
    CommandTypesEnum ChangeType { get; set; }
    string ClientId { get; }
    string CommandName { get; }
    string InternalName { get; }
    ChangeManager Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ChangeProcessor CreateChangeProcessor();
    void Delete();
    // Events
    event OnReplay(NameValueMap Context, out ChangeProcessor ResultProcessor);
}
```

**Returned by:** [ChangeDefinitions](../objects/ChangeDefinitions.md).Add, [ChangeDefinitions](../objects/ChangeDefinitions.md).Item, [ChangeProcessor](../objects/ChangeProcessor.md).Parent

**Referenced types:** [ChangeManager](../objects/ChangeManager.md), [ChangeProcessor](../objects/ChangeProcessor.md), [CommandTypesEnum](../enums/CommandTypesEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

