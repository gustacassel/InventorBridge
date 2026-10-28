# ProgressiveToolTip

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.CommandManager.ControlDefinitions.Item[…].ProgressiveToolTip`

```csharp
interface ProgressiveToolTip
{
    // Properties
    Application Application { get; }
    string Description { get; set; }
    string ExpandedDescription { get; set; }
    object Image { get; set; }
    bool IsProgressive { get; set; }
    ControlDefinition Parent { get; }
    string Title { get; set; }
    ObjectTypeEnum Type { get; }
    string Video { get; set; }
}
```

**Returned by:** [ButtonDefinition](../objects/ButtonDefinition.md).ProgressiveToolTip, [ComboBoxDefinition](../objects/ComboBoxDefinition.md).ProgressiveToolTip, [ControlDefinition](../objects/ControlDefinition.md).ProgressiveToolTip, [MacroControlDefinition](../objects/MacroControlDefinition.md).ProgressiveToolTip

**Referenced types:** [Application](../objects/Application.md), [ControlDefinition](../objects/ControlDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

