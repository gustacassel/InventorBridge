# ChangeManager

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ChangeManager`

```csharp
interface ChangeManager
{
    // Properties
    object Application { get; }
    int Count { get; }
    ChangeDefinitions Item[object Index] { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ChangeDefinitions Add(string ClientId);
    object GetObjectFromScriptKey(string ScriptKey);
    string GetScriptKeyFromObject(object Object);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).ChangeManager, [ChangeDefinition](../objects/ChangeDefinition.md).Parent, [InventorServer](../objects/InventorServer.md).ChangeManager

**Referenced types:** [ChangeDefinitions](../objects/ChangeDefinitions.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

