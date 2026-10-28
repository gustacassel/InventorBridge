# Environment

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.UserInterfaceManager.ParallelEnvironments.Item[…]`

```csharp
interface Environment
{
    // Properties
    object AdditionalVisibleRibbonTabs { get; set; }
    Application Application { get; }
    bool BuiltIn { get; }
    string ClientId { get; }
    string DefaultRibbonTab { get; set; }
    DisabledCommandList DisabledCommandList { get; }
    CommandTypesEnum DisabledCommandTypes { get; set; }
    string DisplayName { get; set; }
    string ExitDisplayName { get; set; }
    bool InheritAllRibbonTabs { get; set; }
    string InternalName { get; }
    IPictureDisp LargeIcon { get; set; }
    Application Parent { get; }
    bool PreserveWhenSwitchModelState { get; set; }
    RadialMarkingMenus RadialMarkingMenus { get; }
    Ribbon Ribbon { get; }
    IPictureDisp StandardIcon { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    RadialMarkingMenu GetRadialMarkingMenu(object ObjectType = Missing);
}
```

5 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [EnvironmentList](../objects/EnvironmentList.md).Item, [EnvironmentManager](../objects/EnvironmentManager.md).BaseEnvironment, [EnvironmentManager](../objects/EnvironmentManager.md).EditObjectEnvironment, [EnvironmentManager](../objects/EnvironmentManager.md).OverrideEnvironment, [Environments](../objects/Environments.md).Add, [Environments](../objects/Environments.md).Item, [PanelBar](../objects/PanelBar.md).Parent, [UserInterfaceManager](../objects/UserInterfaceManager.md).ActiveEnvironment

**Referenced types:** [Application](../objects/Application.md), [CommandTypesEnum](../enums/CommandTypesEnum.md), [DisabledCommandList](../objects/DisabledCommandList.md), [IPictureDisp](../objects/IPictureDisp.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RadialMarkingMenu](../objects/RadialMarkingMenu.md), [RadialMarkingMenus](../objects/RadialMarkingMenus.md), [Ribbon](../objects/Ribbon.md)

