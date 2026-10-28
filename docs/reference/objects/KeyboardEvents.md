# KeyboardEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.CommandManager.CreateInteractionEvents(…).KeyboardEvents`

```csharp
interface KeyboardEvents
{
    // Properties
    Application Application { get; }
    InteractionEvents Parent { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnKeyDown(int Key, ShiftStateEnum ShiftKeys);
    event OnKeyPress(int KeyASCII);
    event OnKeyUp(int Key, ShiftStateEnum ShiftKeys);
}
```

**Returned by:** [InteractionEvents](../objects/InteractionEvents.md).KeyboardEvents

**Referenced types:** [Application](../objects/Application.md), [InteractionEvents](../objects/InteractionEvents.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ShiftStateEnum](../enums/ShiftStateEnum.md)

