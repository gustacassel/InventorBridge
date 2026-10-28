# MiniToolbarDropdown

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [MiniToolbarControl](../objects/MiniToolbarControl.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.CommandManager.CreateMiniToolbar(…).Controls.Item[…] → (MiniToolbarDropdown)`

```csharp
interface MiniToolbarDropdown
{
    // Properties
    Application Application { get; }
    bool AutoHide { get; set; }
    MiniToolbarControlTypeEnum ControlType { get; }
    int Count { get; }
    string DisplayName { get; set; }
    bool Enabled { get; set; }
    bool HasMRUBehavior { get; set; }
    int Index { get; }
    string InternalName { get; }
    bool IsSplitButton { get; }
    MiniToolbarListItem Item[object Index] { get; }
    IPictureDisp LargeIcon { get; set; }
    MiniToolbar Parent { get; }
    bool Pressed { get; set; }
    int SelectedIndex { get; set; }
    MiniToolbarListItem SelectedItem { get; }
    bool ShowIcon { get; set; }
    bool ShowText { get; set; }
    IPictureDisp StandardIcon { get; set; }
    string ToolTipText { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    MiniToolbarListItem AddItem(string Text, string ToolTipText, string InternalName = "", bool AllowDelete = false, bool ShowCheckBox = false, object StandardIcon = Missing, object LargeIcon = Missing, int Index = 0);
    MiniToolbarListItem AddSeparator(string InternalName = "", int Index = 0);
    void Clear();
    void Delete();
    void RemoveItem(object Index);
    // Events
    event OnItemHoverEnd(MiniToolbarListItem ListItem);
    event OnItemHoverStart(MiniToolbarListItem ListItem);
    event OnItemRemove(MiniToolbarListItem ListItem);
    event OnPreMenuDisplay();
    event OnSelect(MiniToolbarListItem ListItem);
}
```

**Returned by:** [MiniToolbarControls](../objects/MiniToolbarControls.md).AddDropdown

**Referenced types:** [Application](../objects/Application.md), [IPictureDisp](../objects/IPictureDisp.md), [MiniToolbar](../objects/MiniToolbar.md), [MiniToolbarControlTypeEnum](../enums/MiniToolbarControlTypeEnum.md), [MiniToolbarListItem](../objects/MiniToolbarListItem.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

