# DrawingViewEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingViews.Item[…].DrawingViewEvents`

```csharp
interface DrawingViewEvents
{
    // Properties
    object Application { get; }
    DrawingView Parent { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnViewUpdate(EventTimingEnum BeforeOrAfter, NameValueMap Context, CommandTypesEnum ReasonsForChange, out HandlingCodeEnum HandlingCode);
}
```

**Returned by:** [DetailDrawingView](../objects/DetailDrawingView.md).DrawingViewEvents, [DrawingView](../objects/DrawingView.md).DrawingViewEvents, [SectionDrawingView](../objects/SectionDrawingView.md).DrawingViewEvents

**Referenced types:** [CommandTypesEnum](../enums/CommandTypesEnum.md), [DrawingView](../objects/DrawingView.md), [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

