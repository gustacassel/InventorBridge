# IRxApplicationEvents

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface IRxApplicationEvents
{
    // Methods
    void OnActivateDocument(Document DocumentObject);
    void OnActivateView(View ViewObject);
    void OnCloseDocument(Document DocumentObject, EventTimingEnum BeforeOrAfter);
    void OnCloseView(View ViewObject);
    void OnDeactivateDocument(Document DocumentObject);
    void OnDeactivateView(View ViewObject);
    void OnNewDocument(Document DocumentObject);
    void OnNewView(View ViewObject);
    void OnOpenDocument(Document DocumentObject);
    void OnQuit();
    void OnSaveDocument(Document DocumentObject, EventTimingEnum BeforeOrAfter);
}
```

**Referenced types:** [Document](../objects/Document.md), [EventTimingEnum](../enums/EventTimingEnum.md), [View](../objects/View.md)

