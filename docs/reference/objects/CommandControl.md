# CommandControl

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.UserInterfaceManager.FileBrowserControls.Item[…]`

```csharp
interface CommandControl
{
    // Properties
    Application Application { get; }
    CommandControls ChildControls { get; }
    ControlDefinition ControlDefinition { get; }
    ControlTypeEnum ControlType { get; }
    string DisplayName { get; }
    ControlDefinition DisplayedControl { get; set; }
    string InternalName { get; }
    string KeyTip { get; set; }
    object Parent { get; }
    bool ShowText { get; set; }
    ObjectTypeEnum Type { get; }
    bool UseLargeIcon { get; set; }
    bool Visible { get; set; }
    // Methods
    void Delete();
}
```

**Returned by:** [CommandControls](../objects/CommandControls.md).AddButton, [CommandControls](../objects/CommandControls.md).AddButtonPopup, [CommandControls](../objects/CommandControls.md).AddComboBox, [CommandControls](../objects/CommandControls.md).AddCopy, [CommandControls](../objects/CommandControls.md).AddGallery, [CommandControls](../objects/CommandControls.md).AddMacro, [CommandControls](../objects/CommandControls.md).AddPopup, [CommandControls](../objects/CommandControls.md).AddSeparator, [CommandControls](../objects/CommandControls.md).AddSplitButton, [CommandControls](../objects/CommandControls.md).AddSplitButtonMRU, [CommandControls](../objects/CommandControls.md).AddTogglePopup, [CommandControls](../objects/CommandControls.md).Item, [CommandControlsEnumerator](../objects/CommandControlsEnumerator.md).Item

**Referenced types:** [Application](../objects/Application.md), [CommandControls](../objects/CommandControls.md), [ControlDefinition](../objects/ControlDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

