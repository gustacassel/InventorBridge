# WebBrowserDialogs

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.WebBrowserDialogs`

```csharp
interface WebBrowserDialogs
{
    // Properties
    int Count { get; }
    WebBrowserDialog Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    WebBrowserDialog Add(object InternalName = Missing, bool Modal = false);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).WebBrowserDialogs

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [WebBrowserDialog](../objects/WebBrowserDialog.md)

