# MiniToolbarListItem

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.CommandManager.CreateMiniToolbar(…).Controls.Item[…] → (MiniToolbarComboBox).Item[…]`

```csharp
interface MiniToolbarListItem
{
    // Properties
    bool AllowDelete { get; set; }
    bool Enabled { get; set; }
    int Index { get; }
    string InternalName { get; }
    bool IsChecked { get; set; }
    bool IsSeperator { get; }
    IPictureDisp LargeIcon { get; set; }
    bool ShowCheckBox { get; set; }
    IPictureDisp StandardIcon { get; set; }
    string Text { get; set; }
    string ToolTipText { get; set; }
}
```

**Returned by:** [MiniToolbarComboBox](../objects/MiniToolbarComboBox.md).AddItem, [MiniToolbarComboBox](../objects/MiniToolbarComboBox.md).Item, [MiniToolbarComboBox](../objects/MiniToolbarComboBox.md).SelectedItem, [MiniToolbarDropdown](../objects/MiniToolbarDropdown.md).AddItem, [MiniToolbarDropdown](../objects/MiniToolbarDropdown.md).AddSeparator, [MiniToolbarDropdown](../objects/MiniToolbarDropdown.md).Item, [MiniToolbarDropdown](../objects/MiniToolbarDropdown.md).SelectedItem, [MiniToolbarTextBox](../objects/MiniToolbarTextBox.md).AddItem, [MiniToolbarTextBox](../objects/MiniToolbarTextBox.md).AddSeparator, [MiniToolbarTextBox](../objects/MiniToolbarTextBox.md).Item, [MiniToolbarTextBox](../objects/MiniToolbarTextBox.md).SelectedItem

**Referenced types:** [IPictureDisp](../objects/IPictureDisp.md)

