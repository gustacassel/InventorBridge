# MiniToolbar

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.CommandManager.CreateMiniToolbar(…)`

```csharp
interface MiniToolbar
{
    // Properties
    Application Application { get; }
    MiniToolbarControls Controls { get; }
    bool EnableApply { get; set; }
    bool EnableOK { get; set; }
    int HWND { get; }
    int Height { get; }
    object Parent { get; }
    Point2d Position { get; set; }
    bool ShowApply { get; set; }
    bool ShowCancel { get; set; }
    bool ShowHandle { get; set; }
    bool ShowOK { get; set; }
    bool ShowOptionBox { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    int Width { get; }
    // Methods
    void Delete();
    // Events
    event OnApply();
    event OnCancel();
    event OnEndMove(NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnHide(EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnMove(NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnOK();
    event OnShow(EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnStartMove(NameValueMap Context, out HandlingCodeEnum HandlingCode);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [CommandManager](../objects/CommandManager.md).CreateMiniToolbar, [InteractionEvents](../objects/InteractionEvents.md).CreateMiniToolbar, [MiniToolbarButton](../objects/MiniToolbarButton.md).Parent, [MiniToolbarCheckBox](../objects/MiniToolbarCheckBox.md).Parent, [MiniToolbarComboBox](../objects/MiniToolbarComboBox.md).Parent, [MiniToolbarControl](../objects/MiniToolbarControl.md).Parent, [MiniToolbarDropdown](../objects/MiniToolbarDropdown.md).Parent, [MiniToolbarSlider](../objects/MiniToolbarSlider.md).Parent, [MiniToolbarTextBox](../objects/MiniToolbarTextBox.md).Parent, [MiniToolbarTextEditor](../objects/MiniToolbarTextEditor.md).Parent, [MiniToolbarValueEditor](../objects/MiniToolbarValueEditor.md).Parent

**Referenced types:** [Application](../objects/Application.md), [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [MiniToolbarControls](../objects/MiniToolbarControls.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md)

