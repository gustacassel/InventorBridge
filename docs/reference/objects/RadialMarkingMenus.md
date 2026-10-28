# RadialMarkingMenus

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.UserInterfaceManager.ParallelEnvironments.Item[…].RadialMarkingMenus`

```csharp
interface RadialMarkingMenus
{
    // Properties
    Application Application { get; }
    int Count { get; }
    RadialMarkingMenu Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    RadialMarkingMenu Add(string Name, string InternalName, string ClientId);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Environment](../objects/Environment.md).RadialMarkingMenus

**Referenced types:** [Application](../objects/Application.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RadialMarkingMenu](../objects/RadialMarkingMenu.md)

