# MiniToolbarControls

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.CommandManager.CreateMiniToolbar(…).Controls`

```csharp
interface MiniToolbarControls
{
    // Properties
    Application Application { get; }
    int Count { get; }
    MiniToolbarControl Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    MiniToolbarButton AddButton(string InternalName, string DisplayName, string ToolTipText, object StandardIcon = Missing, object LargeIcon = Missing);
    MiniToolbarCheckBox AddCheckBox(string InternalName, string DisplayName, string ToolTipText, bool Checked, object StandardIcon = Missing, object LargeIcon = Missing);
    MiniToolbarComboBox AddComboBox(string InternalName, bool ShowIcon = false, bool ShowText = true, int Width = 0);
    MiniToolbarDropdown AddDropdown(string InternalName, bool ShowIcon = true, bool ShowText = false, bool HasMRUBehavior = true, bool IsSplitButton = false);
    MiniToolbarControl AddLabel(string InternalName, string Text, string ToolTipText, object StandardIcon = Missing, object LargeIcon = Missing);
    MiniToolbarControl AddNewLine();
    MiniToolbarControl AddSeparator();
    MiniToolbarSlider AddSlider(string InternalName, string DisplayName, string ToolTipText, ValueTypeEnum ValueType, double Maximum, double Minimum, int NumberOfTicks, int StepsBetweenTicks, int Width);
    MiniToolbarValueEditor AddValueEditor(string InternalName, string ToolTipText, ValueUnitsTypeEnum UnitsType, string Expression, string DisplayName = "", int Width = 0, object StandardIcon = Missing, object LargeIcon = Missing);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [MiniToolbar](../objects/MiniToolbar.md).Controls

**Referenced types:** [Application](../objects/Application.md), [MiniToolbarButton](../objects/MiniToolbarButton.md), [MiniToolbarCheckBox](../objects/MiniToolbarCheckBox.md), [MiniToolbarComboBox](../objects/MiniToolbarComboBox.md), [MiniToolbarControl](../objects/MiniToolbarControl.md), [MiniToolbarDropdown](../objects/MiniToolbarDropdown.md), [MiniToolbarSlider](../objects/MiniToolbarSlider.md), [MiniToolbarValueEditor](../objects/MiniToolbarValueEditor.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ValueTypeEnum](../enums/ValueTypeEnum.md), [ValueUnitsTypeEnum](../enums/ValueUnitsTypeEnum.md)

