# TriadEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.CommandManager.CreateInteractionEvents(…).TriadEvents`

```csharp
interface TriadEvents
{
    // Properties
    Application Application { get; }
    TriadSegmentEnum DegreesOfFreedom { get; set; }
    bool Enabled { get; set; }
    Matrix GlobalTransform { get; set; }
    bool IsInRedefineMode { get; }
    bool MoveTriadOnly { get; set; }
    bool MoveTriadOnlyEnabled { get; set; }
    InteractionEvents Parent { get; }
    bool Repeat { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Reposition(TriadSegmentEnum TriadSegment, object AlignWith);
    // Events
    event OnActivate(NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnEndMove(TriadSegmentEnum SelectedTriadSegment, ShiftStateEnum ShiftKeys, Matrix CoordinateSystem, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnEndSequence(bool Cancelled, Matrix CoordinateSystem, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnEndSequence2(ref bool Cancelled, Matrix CoordinateSystem, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnMove(TriadSegmentEnum SelectedTriadSegment, ShiftStateEnum ShiftKeys, Matrix CoordinateSystem, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnMoveTriadOnlyToggle(bool MoveTriadOnly, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnMoveTriadOnlyToggle2(ref bool MoveTriadOnly, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnSegmentSelectionChange(TriadSegmentEnum SelectedTriadSegment, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnStartMove(TriadSegmentEnum SelectedTriadSegment, ShiftStateEnum ShiftKeys, Matrix CoordinateSystem, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnStartSequence(Matrix CoordinateSystem, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnTerminate(bool Cancelled, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnTerminate2(ref bool Cancelled, NameValueMap Context, out HandlingCodeEnum HandlingCode);
}
```

**Returned by:** [InteractionEvents](../objects/InteractionEvents.md).TriadEvents

**Referenced types:** [Application](../objects/Application.md), [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [InteractionEvents](../objects/InteractionEvents.md), [Matrix](../objects/Matrix.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ShiftStateEnum](../enums/ShiftStateEnum.md), [TriadSegmentEnum](../enums/TriadSegmentEnum.md)

