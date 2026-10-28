# ManipulatorEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.CommandManager.CreateInteractionEvents(…).ManipulatorEvents`

```csharp
interface ManipulatorEvents
{
    // Properties
    Application Application { get; }
    bool Enabled { get; set; }
    InteractionEvents Parent { get; }
    ManipulatorElementEnum SelectedElement { get; set; }
    Matrix Transform { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void ApplyDrag(ManipulatorElementEnum ManipulatorElement, object DragValue);
    void SetAppearance(ManipulatorElementEnum VisibleElements, ManipulatorElementEnum EnabledElements);
    Point2d SuggestedMiniToolbarPosition(int MiniToolbarHeight, int MiniToolbarWidth);
    // Events
    event OnDrag(ManipulatorElementEnum SelectedManipulatorElement, object DragValue, Matrix ManipulatorTransform, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnEndDrag(ManipulatorElementEnum SelectedManipulatorElement, object DragValue, Matrix ManipulatorTransform, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnManipulatorElementSelectionChange(ManipulatorElementEnum SelectedManipulatorElement, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnStartDrag(ManipulatorElementEnum SelectedManipulatorElement, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [InteractionEvents](../objects/InteractionEvents.md).ManipulatorEvents

**Referenced types:** [Application](../objects/Application.md), [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [InteractionEvents](../objects/InteractionEvents.md), [ManipulatorElementEnum](../enums/ManipulatorElementEnum.md), [Matrix](../objects/Matrix.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md)

