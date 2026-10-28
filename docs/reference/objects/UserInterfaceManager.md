# UserInterfaceManager

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.UserInterfaceManager`

```csharp
interface UserInterfaceManager
{
    // Properties
    Environment ActiveEnvironment { get; }
    Application Application { get; }
    BalloonTips BalloonTips { get; }
    bool CapacityMeterEnabled { get; set; }
    DockableWindows DockableWindows { get; }
    Environments Environments { get; }
    bool ExpertMode { get; set; }
    CommandControls FileBrowserControls { get; }
    CommandControls HelpControls { get; }
    OverflowMenuBehaviorEnum OverflowMenuBehavior { get; set; }
    EnvironmentList ParallelEnvironments { get; }
    Application Parent { get; }
    bool PinMiniToolbarPosition { get; }
    RibbonAppearanceEnum RibbonAppearance { get; set; }
    RibbonDockingStateEnum RibbonDockingState { get; set; }
    RibbonStateEnum RibbonState { get; set; }
    Ribbons Ribbons { get; }
    bool ShowBrowser { get; set; }
    bool ShowCleanScreen { get; set; }
    bool ShowDocumentTabs { get; set; }
    bool ShowMarkingMenu { get; set; }
    bool ShowNavigationBar { get; set; }
    bool ShowQuickAccessControlsBelowRibbon { get; set; }
    bool ShowStatusBar { get; set; }
    bool ShowSteeringWheel { get; set; }
    bool ShowViewCube { get; set; }
    ObjectTypeEnum Type { get; }
    bool UserInteractionDisabled { get; set; }
    UserInterfaceEvents UserInterfaceEvents { get; }
    // Methods
    CommandControlsEnumerator AllReferencedControls(ControlDefinition Definition);
    void DoEvents();
    string GetCommandPaths(string CommandInternalName, object Environment = Missing);
    void ResetRibbonInterface();
}
```

9 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).UserInterfaceManager, [BalloonTip](../objects/BalloonTip.md).Parent, [DockableWindow](../objects/DockableWindow.md).Parent, [Ribbon](../objects/Ribbon.md).Parent, [UserInterfaceEvents](../objects/UserInterfaceEvents.md).Parent

**Referenced types:** [Application](../objects/Application.md), [BalloonTips](../objects/BalloonTips.md), [CommandControls](../objects/CommandControls.md), [CommandControlsEnumerator](../objects/CommandControlsEnumerator.md), [ControlDefinition](../objects/ControlDefinition.md), [DockableWindows](../objects/DockableWindows.md), [Environment](../objects/Environment.md), [EnvironmentList](../objects/EnvironmentList.md), [Environments](../objects/Environments.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [OverflowMenuBehaviorEnum](../enums/OverflowMenuBehaviorEnum.md), [RibbonAppearanceEnum](../enums/RibbonAppearanceEnum.md), [RibbonDockingStateEnum](../enums/RibbonDockingStateEnum.md), [RibbonStateEnum](../enums/RibbonStateEnum.md), [Ribbons](../objects/Ribbons.md), [UserInterfaceEvents](../objects/UserInterfaceEvents.md)

