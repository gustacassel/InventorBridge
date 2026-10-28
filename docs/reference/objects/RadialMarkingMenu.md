# RadialMarkingMenu

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.UserInterfaceManager.ParallelEnvironments.Item[…].RadialMarkingMenus.Item[…]`

```csharp
interface RadialMarkingMenu
{
    // Properties
    Application Application { get; }
    bool BuiltIn { get; }
    string ClientId { get; }
    object EastControl { get; set; }
    string InternalName { get; }
    string Name { get; set; }
    object NorthControl { get; set; }
    object NortheastControl { get; set; }
    object NorthwestControl { get; set; }
    object SouthControl { get; set; }
    object SoutheastControl { get; set; }
    object SouthwestControl { get; set; }
    ObjectTypeEnum Type { get; }
    object WestControl { get; set; }
    // Methods
    void Clear();
    RadialMarkingMenu CreateRadialSubMenu(string Name);
    void Delete();
}
```

**Returned by:** [Environment](../objects/Environment.md).GetRadialMarkingMenu, [RadialMarkingMenu](../objects/RadialMarkingMenu.md).CreateRadialSubMenu, [RadialMarkingMenus](../objects/RadialMarkingMenus.md).Add, [RadialMarkingMenus](../objects/RadialMarkingMenus.md).Item

**Referenced types:** [Application](../objects/Application.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

