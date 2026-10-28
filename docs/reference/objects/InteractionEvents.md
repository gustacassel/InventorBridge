# InteractionEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.CommandManager.CreateInteractionEvents(…)`

```csharp
interface InteractionEvents
{
    // Properties
    bool AllowCommandAliases { get; set; }
    Application Application { get; }
    bool InteractionDisabled { get; set; }
    InteractionGraphics InteractionGraphics { get; }
    KeyboardEvents KeyboardEvents { get; }
    ManipulatorEvents ManipulatorEvents { get; }
    MeasureEvents MeasureEvents { get; }
    MouseEvents MouseEvents { get; }
    string Name { get; set; }
    CommandManager Parent { get; }
    SelectEvents SelectEvents { get; }
    string StatusBarText { get; set; }
    Document TargetDocument { get; }
    TriadEvents TriadEvents { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    MiniToolbar CreateMiniToolbar();
    void GetCursor(out CursorTypeEnum CursorType, out object Cursor, out CursorHotSpotEnum CursorHotSpot);
    void SetCursor(CursorTypeEnum CursorType, object Cursor = Missing, object CursorHotSpot = Missing);
    void Start();
    void Stop();
    // Events
    event OnActivate();
    event OnHelp(EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnResume();
    event OnSuspend();
    event OnTerminate();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [CommandManager](../objects/CommandManager.md).CreateInteractionEvents, [KeyboardEvents](../objects/KeyboardEvents.md).Parent, [ManipulatorEvents](../objects/ManipulatorEvents.md).Parent, [MeasureEvents](../objects/MeasureEvents.md).Parent, [MouseEvents](../objects/MouseEvents.md).Parent, [SelectEvents](../objects/SelectEvents.md).Parent, [TriadEvents](../objects/TriadEvents.md).Parent

**Referenced types:** [Application](../objects/Application.md), [CommandManager](../objects/CommandManager.md), [CursorHotSpotEnum](../enums/CursorHotSpotEnum.md), [CursorTypeEnum](../enums/CursorTypeEnum.md), [Document](../objects/Document.md), [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [InteractionGraphics](../objects/InteractionGraphics.md), [KeyboardEvents](../objects/KeyboardEvents.md), [ManipulatorEvents](../objects/ManipulatorEvents.md), [MeasureEvents](../objects/MeasureEvents.md), [MiniToolbar](../objects/MiniToolbar.md), [MouseEvents](../objects/MouseEvents.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SelectEvents](../objects/SelectEvents.md), [TriadEvents](../objects/TriadEvents.md)

