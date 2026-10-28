# Environments

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.UserInterfaceManager.Environments`

```csharp
interface Environments
{
    // Properties
    Application Application { get; }
    int Count { get; }
    Environment Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    Environment Add(string DisplayName, string InternalName, object ClientId = Missing, object StandardIcon = Missing, object LargeIcon = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [UserInterfaceManager](../objects/UserInterfaceManager.md).Environments

**Referenced types:** [Application](../objects/Application.md), [Environment](../objects/Environment.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

