# MiniToolbarButton

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [MiniToolbarControl](../objects/MiniToolbarControl.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.CommandManager.CreateMiniToolbar(…).Controls.Item[…] → (MiniToolbarButton)`

```csharp
interface MiniToolbarButton
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
    bool Pressed { get; set; }
    IPictureDisp StandardIcon { get; set; }
    string ToolTipText { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void Delete();
    // Events
    event OnClick();
}
```

**Returned by:** [MiniToolbarControls](../objects/MiniToolbarControls.md).AddButton

**Referenced types:** [Application](../objects/Application.md), [IPictureDisp](../objects/IPictureDisp.md), [MiniToolbar](../objects/MiniToolbar.md), [MiniToolbarControlTypeEnum](../enums/MiniToolbarControlTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

