# CommandCategories

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.CommandManager.CommandCategories`

```csharp
interface CommandCategories
{
    // Properties
    Application Application { get; }
    int Count { get; }
    CommandCategory Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    CommandCategory Add(string DisplayName, string InternalName, object ClientId = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [CommandManager](../objects/CommandManager.md).CommandCategories

**Referenced types:** [Application](../objects/Application.md), [CommandCategory](../objects/CommandCategory.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

