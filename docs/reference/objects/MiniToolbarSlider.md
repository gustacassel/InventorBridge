# MiniToolbarSlider

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [MiniToolbarControl](../objects/MiniToolbarControl.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.CommandManager.CreateMiniToolbar(…).Controls.Item[…] → (MiniToolbarSlider)`

```csharp
interface MiniToolbarSlider
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
    double Maximum { get; set; }
    double Minimum { get; set; }
    int NumberOfTicks { get; set; }
    MiniToolbar Parent { get; }
    IPictureDisp StandardIcon { get; set; }
    int StepsBetweenTicks { get; set; }
    string ToolTipText { get; set; }
    ObjectTypeEnum Type { get; }
    double Value { get; set; }
    ValueTypeEnum ValueType { get; set; }
    bool Visible { get; set; }
    int Width { get; set; }
    // Methods
    void Delete();
    // Events
    event OnValueChange();
}
```

**Returned by:** [MiniToolbarControls](../objects/MiniToolbarControls.md).AddSlider

**Referenced types:** [Application](../objects/Application.md), [IPictureDisp](../objects/IPictureDisp.md), [MiniToolbar](../objects/MiniToolbar.md), [MiniToolbarControlTypeEnum](../enums/MiniToolbarControlTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ValueTypeEnum](../enums/ValueTypeEnum.md)

