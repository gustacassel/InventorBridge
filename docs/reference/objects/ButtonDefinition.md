# ButtonDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ControlDefinition](../objects/ControlDefinition.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.CommandManager.ControlDefinitions.Item[…] → (ButtonDefinition)`

```csharp
interface ButtonDefinition
{
    // Properties
    Application Application { get; }
    bool BuiltIn { get; }
    CommandTypesEnum Classification { get; }
    string ClientId { get; }
    CommandNotificationTypeEnum CommandNotificationType { get; set; }
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
    bool Pressed { get; set; }
    ProgressiveToolTip ProgressiveToolTip { get; }
    IPictureDisp StandardIcon { get; set; }
    string ToolTipText { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void AutoAddToGUI();
    void Delete();
    void Execute();
    void Execute2(bool Synchronous);
    // Events
    event OnExecute(NameValueMap Context);
    event OnHelp(NameValueMap Context, out HandlingCodeEnum HandlingCode);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ControlDefinitions](../objects/ControlDefinitions.md).AddButtonDefinition

**Referenced types:** [Application](../objects/Application.md), [CommandManager](../objects/CommandManager.md), [CommandNotificationTypeEnum](../enums/CommandNotificationTypeEnum.md), [CommandTypesEnum](../enums/CommandTypesEnum.md), [ControlDefinitionTypeEnum](../enums/ControlDefinitionTypeEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [IPictureDisp](../objects/IPictureDisp.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ProgressiveToolTip](../objects/ProgressiveToolTip.md), [ShortcutTypeEnum](../enums/ShortcutTypeEnum.md)

