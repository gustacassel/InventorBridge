# IRxDocumentEvents

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface IRxDocumentEvents
{
    // Methods
    void OnActivate();
    void OnActivateView(View ViewObject);
    void OnClose(EventTimingEnum BeforeOrAfter);
    void OnCloseView(View ViewObject);
    void OnDeactivate();
    void OnDeactivateView(View ViewObject);
    void OnNewView(View ViewObject);
    void OnSave(EventTimingEnum BeforeOrAfter);
}
```

**Referenced types:** [EventTimingEnum](../enums/EventTimingEnum.md), [View](../objects/View.md)

