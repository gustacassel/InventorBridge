# ControlDefinitions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.CommandManager.ControlDefinitions`

```csharp
interface ControlDefinitions
{
    // Properties
    Application Application { get; }
    int Count { get; }
    ControlDefinition Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    bool UseDefaultMultiCharAliases { get; set; }
    // Methods
    ButtonDefinition AddButtonDefinition(string DisplayName, string InternalName, CommandTypesEnum Classification, object ClientId = Missing, string DescriptionText = "", string ToolTipText = "", object StandardIcon = Missing, object LargeIcon = Missing, ButtonDisplayEnum ButtonDisplay = ButtonDisplayEnum.kDisplayTextInLearningMode);
    ComboBoxDefinition AddComboBoxDefinition(string DisplayName, string InternalName, CommandTypesEnum Classification, int DropDownWidth, object ClientId = Missing, string DescriptionText = "", string ToolTipText = "", object StandardIcon = Missing, object LargeIcon = Missing, ButtonDisplayEnum ButtonDisplay = ButtonDisplayEnum.kDisplayTextInLearningMode);
    MacroControlDefinition AddMacroControlDefinition(string MacroOrProgram);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [CommandManager](../objects/CommandManager.md).ControlDefinitions

**Referenced types:** [Application](../objects/Application.md), [ButtonDefinition](../objects/ButtonDefinition.md), [ButtonDisplayEnum](../enums/ButtonDisplayEnum.md), [ComboBoxDefinition](../objects/ComboBoxDefinition.md), [CommandTypesEnum](../enums/CommandTypesEnum.md), [ControlDefinition](../objects/ControlDefinition.md), [MacroControlDefinition](../objects/MacroControlDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

