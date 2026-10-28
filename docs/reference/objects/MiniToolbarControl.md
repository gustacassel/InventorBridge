# MiniToolbarControl

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.CommandManager.CreateMiniToolbar(…).Controls.Item[…]`

```csharp
interface MiniToolbarControl
{
    // Properties
    Application Application { get; }
    bool AutoHide { get; set; }
    MiniToolbarControlTypeEnum ControlType { get; }
    string DisplayName { get; set; }
    bool Enabled { get; set; }
    int Index { get; }
    string InternalName { get; }
    IPictureDisp LargeIcon { get; set; }
    MiniToolbar Parent { get; }
    IPictureDisp StandardIcon { get; set; }
    string ToolTipText { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void Delete();
}
```

**Returned by:** [MiniToolbarControls](../objects/MiniToolbarControls.md).AddLabel, [MiniToolbarControls](../objects/MiniToolbarControls.md).AddNewLine, [MiniToolbarControls](../objects/MiniToolbarControls.md).AddSeparator, [MiniToolbarControls](../objects/MiniToolbarControls.md).Item

**Referenced types:** [Application](../objects/Application.md), [IPictureDisp](../objects/IPictureDisp.md), [MiniToolbar](../objects/MiniToolbar.md), [MiniToolbarControlTypeEnum](../enums/MiniToolbarControlTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

