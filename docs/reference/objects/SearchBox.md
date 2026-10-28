# SearchBox

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.BrowserPanes.Item[…].SearchBox`

```csharp
interface SearchBox
{
    // Properties
    object Application { get; }
    bool Enabled { get; set; }
    BrowserPane Parent { get; }
    SearchBoxEvents SearchBoxEvents { get; }
    SearchBoxFilterEnum SearchFilter { get; }
    string SearchText { get; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void Search(string SearchText, object SearchOptions = Missing);
}
```

**Returned by:** [BrowserPane](../objects/BrowserPane.md).SearchBox, [SearchBoxEvents](../objects/SearchBoxEvents.md).Parent

**Referenced types:** [BrowserPane](../objects/BrowserPane.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SearchBoxEvents](../objects/SearchBoxEvents.md), [SearchBoxFilterEnum](../enums/SearchBoxFilterEnum.md)

