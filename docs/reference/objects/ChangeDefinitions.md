# ChangeDefinitions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ChangeManager.Item[…]`

```csharp
interface ChangeDefinitions
{
    // Properties
    object Application { get; }
    string ClientId { get; }
    int Count { get; }
    ChangeDefinition Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ChangeDefinition Add(string InternalName, string CommandName);
    void Delete();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ChangeManager](../objects/ChangeManager.md).Add, [ChangeManager](../objects/ChangeManager.md).Item

**Referenced types:** [ChangeDefinition](../objects/ChangeDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

