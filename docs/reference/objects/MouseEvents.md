# MouseEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.CommandManager.CreateInteractionEvents(…).MouseEvents`

```csharp
interface MouseEvents
{
    // Properties
    Application Application { get; }
    bool MouseMoveEnabled { get; set; }
    InteractionEvents Parent { get; }
    bool PointInferenceEnabled { get; set; }
    PointInferenceEnumerator PointInferences { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnMouseClick(MouseButtonEnum Button, ShiftStateEnum ShiftKeys, Point ModelPosition, Point2d ViewPosition, View View);
    event OnMouseDoubleClick(MouseButtonEnum Button, ShiftStateEnum ShiftKeys, Point ModelPosition, Point2d ViewPosition, View View);
    event OnMouseDown(MouseButtonEnum Button, ShiftStateEnum ShiftKeys, Point ModelPosition, Point2d ViewPosition, View View);
    event OnMouseLeave(MouseButtonEnum Button, ShiftStateEnum ShiftKeys, View View);
    event OnMouseMove(MouseButtonEnum Button, ShiftStateEnum ShiftKeys, Point ModelPosition, Point2d ViewPosition, View View);
    event OnMouseUp(MouseButtonEnum Button, ShiftStateEnum ShiftKeys, Point ModelPosition, Point2d ViewPosition, View View);
}
```

**Returned by:** [InteractionEvents](../objects/InteractionEvents.md).MouseEvents

**Referenced types:** [Application](../objects/Application.md), [InteractionEvents](../objects/InteractionEvents.md), [MouseButtonEnum](../enums/MouseButtonEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [Point2d](../objects/Point2d.md), [PointInferenceEnumerator](../objects/PointInferenceEnumerator.md), [ShiftStateEnum](../enums/ShiftStateEnum.md), [View](../objects/View.md)

