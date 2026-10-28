# MiniToolbarValueEditor

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [MiniToolbarControl](../objects/MiniToolbarControl.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.CommandManager.CreateMiniToolbar(…).Controls.Item[…] → (MiniToolbarValueEditor)`

```csharp
interface MiniToolbarValueEditor
{
    // Properties
    bool AllowMeasure { get; set; }
    bool AllowShowDimensions { get; set; }
    bool AllowToleranceEdit { get; set; }
    Application Application { get; }
    bool AutoHide { get; set; }
    bool CanValueBeEqualToMaximumValue { get; set; }
    bool CanValueBeEqualToMinimumValue { get; set; }
    MiniToolbarControlTypeEnum ControlType { get; }
    UnitsTypeEnum DefaultUnits { get; set; }
    string DisplayName { get; set; }
    bool Enabled { get; set; }
    string Expression { get; set; }
    int Index { get; }
    string InternalName { get; }
    bool IsExpressionValid { get; }
    IPictureDisp LargeIcon { get; set; }
    double MaximumValue { get; set; }
    double MinimumValue { get; set; }
    ModelValueTypeEnum ModelValueType { get; set; }
    object MostRecentValues { get; set; }
    MiniToolbar Parent { get; }
    int Precision { get; set; }
    IPictureDisp StandardIcon { get; set; }
    Tolerance Tolerance { get; }
    string ToolTipText { get; set; }
    ObjectTypeEnum Type { get; }
    ValueUnitsTypeEnum UnitsType { get; }
    double Value { get; set; }
    bool Visible { get; set; }
    int Width { get; set; }
    // Methods
    void Delete();
    void SetFocus();
    // Events
    event OnChange();
    event OnEnter();
    event OnExit();
}
```

**Returned by:** [MiniToolbarControls](../objects/MiniToolbarControls.md).AddValueEditor

**Referenced types:** [Application](../objects/Application.md), [IPictureDisp](../objects/IPictureDisp.md), [MiniToolbar](../objects/MiniToolbar.md), [MiniToolbarControlTypeEnum](../enums/MiniToolbarControlTypeEnum.md), [ModelValueTypeEnum](../enums/ModelValueTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Tolerance](../objects/Tolerance.md), [UnitsTypeEnum](../enums/UnitsTypeEnum.md), [ValueUnitsTypeEnum](../enums/ValueUnitsTypeEnum.md)

