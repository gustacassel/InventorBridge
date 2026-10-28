# SearchBoxEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.BrowserPanes.Item[…].SearchBox.SearchBoxEvents`

```csharp
interface SearchBoxEvents
{
    // Properties
    object Application { get; }
    SearchBox Parent { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnClearSearch(out HandlingCodeEnum HandlingCode);
    event OnEndSearch(NameValueMap SearchResult, out HandlingCodeEnum HandlingCode);
    event OnStartSearch(out HandlingCodeEnum HandlingCode);
    event OnStopSearch(NameValueMap SearchResult, out HandlingCodeEnum HandlingCode);
}
```

**Returned by:** [SearchBox](../objects/SearchBox.md).SearchBoxEvents

**Referenced types:** [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SearchBox](../objects/SearchBox.md)

