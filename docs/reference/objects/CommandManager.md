# CommandManager

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.CommandManager`

```csharp
interface CommandManager
{
    // Properties
    string ActiveCommand { get; }
    CommandCategories CommandCategories { get; }
    ControlDefinitions ControlDefinitions { get; }
    Application Parent { get; }
    bool SelectionActive { get; }
    ObjectTypeEnum Type { get; }
    UserInputEvents UserInputEvents { get; }
    // Methods
    void ClearPrivateEvents();
    DragContext CreateDragContext();
    InteractionEvents CreateInteractionEvents();
    MiniToolbar CreateMiniToolbar();
    void DoPreSelect(object Entity);
    void DoSelect(object Entity);
    void DoStopPreSelect(object Entity);
    void DoUnSelect(object Entity);
    void PeekPrivateEvent(out PrivateEventTypeEnum DataType, out object Data);
    object Pick(SelectionFilterEnum Filter, string PromptText);
    void PostPrivateEvent(PrivateEventTypeEnum DataType, object Data);
    int PromptMessage(string Prompt, int Buttons, object Title = Missing, object DefaultAnswer = Missing, object Restrictions = Missing, object PromptStrings = Missing);
    void StartExecutable(string ExecutableName, string Parameters);
    void StopActiveCommand();
}
```

6 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).CommandManager, [ButtonDefinition](../objects/ButtonDefinition.md).Parent, [ComboBoxDefinition](../objects/ComboBoxDefinition.md).Parent, [CommandCategory](../objects/CommandCategory.md).Parent, [ControlDefinition](../objects/ControlDefinition.md).Parent, [InteractionEvents](../objects/InteractionEvents.md).Parent, [MacroControlDefinition](../objects/MacroControlDefinition.md).Parent, [UserInputEvents](../objects/UserInputEvents.md).Parent

**Referenced types:** [Application](../objects/Application.md), [CommandCategories](../objects/CommandCategories.md), [ControlDefinitions](../objects/ControlDefinitions.md), [DragContext](../objects/DragContext.md), [InteractionEvents](../objects/InteractionEvents.md), [MiniToolbar](../objects/MiniToolbar.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PrivateEventTypeEnum](../enums/PrivateEventTypeEnum.md), [SelectionFilterEnum](../enums/SelectionFilterEnum.md), [UserInputEvents](../objects/UserInputEvents.md)

