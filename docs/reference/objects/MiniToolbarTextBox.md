# MiniToolbarTextBox

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [MiniToolbarControl](../objects/MiniToolbarControl.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.CommandManager.CreateMiniToolbar(…).Controls.Item[…] → (MiniToolbarTextBox)`

```csharp
interface MiniToolbarTextBox
{
    // Properties
    Application Application { get; }
    bool AutoHide { get; set; }
    Color BackgroundColor { get; set; }
    MiniToolbarControlTypeEnum ControlType { get; }
    int Count { get; }
    string DisplayName { get; set; }
    bool Enabled { get; set; }
    int Index { get; }
    string InternalName { get; }
    bool IsTextAcceptable { get; set; }
    MiniToolbarListItem Item[object Index] { get; }
    IPictureDisp LargeIcon { get; set; }
    MiniToolbar Parent { get; }
    int SelectedIndex { get; set; }
    MiniToolbarListItem SelectedItem { get; }
    int SelectionEndPosition { get; }
    int SelectionStartPosition { get; }
    bool ShowIcon { get; set; }
    IPictureDisp StandardIcon { get; set; }
    string Text { get; set; }
    Color TextColor { get; set; }
    string ToolTipText { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    MiniToolbarListItem AddItem(string Text, string ToolTipText, string InternalName = "", bool AllowDelete = false, object StandardIcon = Missing, object LargeIcon = Missing, int Index = 0);
    MiniToolbarListItem AddSeparator(string InternalName = "", int Index = 0);
    void Clear();
    void Delete();
    void RemoveItem(object Index);
    void SetFocus();
    // Events
    event OnChange();
    event OnEnter();
    event OnExit();
    event OnItemHoverEnd();
    event OnItemHoverStart();
    event OnItemRemove();
    event OnSelect();
}
```

**Referenced types:** [Application](../objects/Application.md), [Color](../objects/Color.md), [IPictureDisp](../objects/IPictureDisp.md), [MiniToolbar](../objects/MiniToolbar.md), [MiniToolbarControlTypeEnum](../enums/MiniToolbarControlTypeEnum.md), [MiniToolbarListItem](../objects/MiniToolbarListItem.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

