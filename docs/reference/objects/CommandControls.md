# CommandControls

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.UserInterfaceManager.FileBrowserControls`

```csharp
interface CommandControls
{
    // Properties
    Application Application { get; }
    int Count { get; }
    CommandControl Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    CommandControl AddButton(ButtonDefinition ButtonDefinition, bool UseLargeIcon = false, bool ShowText = true, string TargetControlInternalName = "", bool InsertBeforeTargetControl = false);
    CommandControl AddButtonPopup(ObjectCollection ButtonDefinitions, bool UseLargeIcon = false, bool ShowText = true, string TargetControlInternalName = "", bool InsertBeforeTargetControl = false);
    CommandControl AddComboBox(ComboBoxDefinition ComboBoxDefinition, string TargetControlInternalName = "", bool InsertBeforeTargetControl = false);
    CommandControl AddCopy(CommandControl CommandControl, string TargetControlInternalName = "", bool InsertBeforeTargetControl = false);
    CommandControl AddGallery(ObjectCollection ButtonDefinitions, bool DisplayAsComboBox = false, int Width = 200, string TargetControlInternalName = "", bool InsertBeforeTargetControl = false);
    CommandControl AddMacro(MacroControlDefinition MacroControlDefinition, bool UseLargeIcon = false, bool ShowText = true, string TargetControlInternalName = "", bool InsertBeforeTargetControl = false);
    CommandControl AddPopup(ButtonDefinition DisplayedControl, ObjectCollection ButtonDefinitions, bool UseLargeIcon = false, bool ShowText = true, string TargetControlInternalName = "", bool InsertBeforeTargetControl = false);
    CommandControl AddSeparator(string TargetControlInternalName = "", bool InsertBeforeTargetControl = false);
    CommandControl AddSplitButton(ButtonDefinition DisplayedControl, ObjectCollection ButtonDefinitions, bool UseLargeIcon = false, bool ShowText = true, string TargetControlInternalName = "", bool InsertBeforeTargetControl = false);
    CommandControl AddSplitButtonMRU(ObjectCollection ButtonDefinitions, bool UseLargeIcon = false, bool ShowText = true, string TargetControlInternalName = "", bool InsertBeforeTargetControl = false);
    CommandControl AddTogglePopup(ButtonDefinition DisplayedControl, ObjectCollection ButtonDefinitions, bool UseLargeIcon = false, bool ShowText = true, string TargetControlInternalName = "", bool InsertBeforeTargetControl = false);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [CommandControl](../objects/CommandControl.md).ChildControls, [Ribbon](../objects/Ribbon.md).QuickAccessControls, [RibbonPanel](../objects/RibbonPanel.md).CommandControls, [RibbonPanel](../objects/RibbonPanel.md).SlideoutControls, [UserInterfaceManager](../objects/UserInterfaceManager.md).FileBrowserControls, [UserInterfaceManager](../objects/UserInterfaceManager.md).HelpControls

**Referenced types:** [Application](../objects/Application.md), [ButtonDefinition](../objects/ButtonDefinition.md), [ComboBoxDefinition](../objects/ComboBoxDefinition.md), [CommandControl](../objects/CommandControl.md), [MacroControlDefinition](../objects/MacroControlDefinition.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

