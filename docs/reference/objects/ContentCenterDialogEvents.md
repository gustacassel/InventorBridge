# ContentCenterDialogEvents

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface ContentCenterDialogEvents
{
    // Events
    event OnSelect(NameValueMap Context, NameValueMap Options, out string ResultXML);
    event OnSelectionCommit(NameValueMap Context, NameValueMap Options, out string ResultXML);
    event OnTerminate(bool Cancelled, NameValueMap Context);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [NameValueMap](../objects/NameValueMap.md)

