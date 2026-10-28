# ComboBoxDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ControlDefinition](../objects/ControlDefinition.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.CommandManager.ControlDefinitions.Item[…] → (ComboBoxDefinition)`

```csharp
interface ComboBoxDefinition
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
    int DropDownWidth { get; set; }
    bool Enabled { get; set; }
    string InternalName { get; }
    string IntroducedInVersion { get; set; }
    bool IsShortcutOverridden { get; }
    IPictureDisp LargeIcon { get; set; }
    string LastUpdatedVersion { get; set; }
    int ListCount { get; }
    int ListIndex { get; set; }
    string ListItem[int Index] { get; set; }
    string OverrideShortcut { get; set; }
    ShortcutTypeEnum OverrideShortcutType { get; }
    CommandManager Parent { get; }
    ProgressiveToolTip ProgressiveToolTip { get; }
    IPictureDisp StandardIcon { get; set; }
    string Text { get; }
    string ToolTipText { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void AddItem(string Item, int Index = 0);
    void AutoAddToGUI();
    void Clear();
    void Delete();
    void Execute();
    void Execute2(bool Synchronous);
    void RemoveItem(int Index);
    // Events
    event OnHelp(NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnSelect(NameValueMap Context);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ControlDefinitions](../objects/ControlDefinitions.md).AddComboBoxDefinition

**Referenced types:** [Application](../objects/Application.md), [CommandManager](../objects/CommandManager.md), [CommandTypesEnum](../enums/CommandTypesEnum.md), [ControlDefinitionTypeEnum](../enums/ControlDefinitionTypeEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [IPictureDisp](../objects/IPictureDisp.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ProgressiveToolTip](../objects/ProgressiveToolTip.md), [ShortcutTypeEnum](../enums/ShortcutTypeEnum.md)

