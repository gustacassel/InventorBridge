# ControlDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.CommandManager.ControlDefinitions.Item[…]`

```csharp
interface ControlDefinition
{
    // Properties
    Application Application { get; }
    bool BuiltIn { get; }
    CommandTypesEnum Classification { get; }
    string ClientId { get; }
    string DefaultShortcut { get; set; }
    ShortcutTypeEnum DefaultShortcutType { get; }
    ControlDefinitionTypeEnum DefinitionType { get; }
    string DescriptionText { get; set; }
    string DisplayName { get; }
    bool Enabled { get; set; }
    string InternalName { get; }
    string IntroducedInVersion { get; set; }
    bool IsShortcutOverridden { get; }
    IPictureDisp LargeIcon { get; set; }
    string LastUpdatedVersion { get; set; }
    string OverrideShortcut { get; set; }
    ShortcutTypeEnum OverrideShortcutType { get; }
    CommandManager Parent { get; }
    ProgressiveToolTip ProgressiveToolTip { get; }
    IPictureDisp StandardIcon { get; set; }
    string ToolTipText { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void AutoAddToGUI();
    void Delete();
    void Execute();
    void Execute2(bool Synchronous);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ButtonDefinitionHandler](../objects/ButtonDefinitionHandler.md).ControlDefinition, [CommandControl](../objects/CommandControl.md).ControlDefinition, [CommandControl](../objects/CommandControl.md).DisplayedControl, [ControlDefinitionEvents](../objects/ControlDefinitionEvents.md).Parent, [ControlDefinitions](../objects/ControlDefinitions.md).Item, [DisabledCommandList](../objects/DisabledCommandList.md).Item, [DockableWindow](../objects/DockableWindow.md).VisibilityControl, [ProgressiveToolTip](../objects/ProgressiveToolTip.md).Parent

**Referenced types:** [Application](../objects/Application.md), [CommandManager](../objects/CommandManager.md), [CommandTypesEnum](../enums/CommandTypesEnum.md), [ControlDefinitionTypeEnum](../enums/ControlDefinitionTypeEnum.md), [IPictureDisp](../objects/IPictureDisp.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ProgressiveToolTip](../objects/ProgressiveToolTip.md), [ShortcutTypeEnum](../enums/ShortcutTypeEnum.md)

