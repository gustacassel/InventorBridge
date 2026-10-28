# Ribbon

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.UserInterfaceManager.Ribbons.Item[…]`

```csharp
interface Ribbon
{
    // Properties
    bool Active { get; }
    Application Application { get; }
    string InternalName { get; }
    UserInterfaceManager Parent { get; }
    CommandControls QuickAccessControls { get; }
    RibbonTabs RibbonTabs { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [Environment](../objects/Environment.md).Ribbon, [RibbonTab](../objects/RibbonTab.md).Parent, [Ribbons](../objects/Ribbons.md).Item

**Referenced types:** [Application](../objects/Application.md), [CommandControls](../objects/CommandControls.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RibbonTabs](../objects/RibbonTabs.md), [UserInterfaceManager](../objects/UserInterfaceManager.md)

