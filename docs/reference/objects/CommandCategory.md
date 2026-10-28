# CommandCategory

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.CommandManager.CommandCategories.Item[…]`

```csharp
interface CommandCategory
{
    // Properties
    Application Application { get; }
    bool BuiltIn { get; }
    string ClientId { get; }
    int Count { get; }
    string DisplayName { get; }
    string InternalName { get; }
    object Item[int Index] { get; }
    object ItemByName[string Name] { get; }
    CommandManager Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Add(object Command);
    void Delete();
    void Remove(int Index);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [CommandCategories](../objects/CommandCategories.md).Add, [CommandCategories](../objects/CommandCategories.md).Item

**Referenced types:** [Application](../objects/Application.md), [CommandManager](../objects/CommandManager.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

