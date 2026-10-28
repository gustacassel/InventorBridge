# MiniToolbarTextEditor

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface MiniToolbarTextEditor
{
    // Properties
    Application Application { get; }
    bool AutoHide { get; set; }
    MiniToolbarControlTypeEnum ControlType { get; }
    string DisplayName { get; set; }
    bool Enabled { get; set; }
    int Height { get; set; }
    int Index { get; }
    string InternalName { get; }
    IPictureDisp LargeIcon { get; set; }
    MiniToolbar Parent { get; }
    IPictureDisp StandardIcon { get; set; }
    string TextValue { get; set; }
    string ToolTipText { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    int Width { get; set; }
    // Methods
    string AppendLine(string Value);
    void Delete();
    void SetFocus();
    bool SetReadonly(bool Value);
    // Events
    event OnChange();
    event OnEnter();
    event OnExit();
}
```

**Referenced types:** [Application](../objects/Application.md), [IPictureDisp](../objects/IPictureDisp.md), [MiniToolbar](../objects/MiniToolbar.md), [MiniToolbarControlTypeEnum](../enums/MiniToolbarControlTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

