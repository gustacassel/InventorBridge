# ProgressBar

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.CreateProgressBar(…)`

```csharp
interface ProgressBar
{
    // Properties
    object Application { get; }
    string Message { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Close();
    void UpdateProgress();
    // Events
    event OnCancel();
}
```

**Returned by:** [Application](../objects/Application.md).CreateProgressBar

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

