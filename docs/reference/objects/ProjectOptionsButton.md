# ProjectOptionsButton

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.DesignProjectManager.AddOptionsButton(…)`

```csharp
interface ProjectOptionsButton
{
    // Properties
    Application Application { get; }
    string DisplayName { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void FireOnClick(NameValueMap Context);
    // Events
    event OnClick(NameValueMap Context);
}
```

**Returned by:** [DesignProjectManager](../objects/DesignProjectManager.md).AddOptionsButton

**Referenced types:** [Application](../objects/Application.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

