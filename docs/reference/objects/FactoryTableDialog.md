# FactoryTableDialog

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.CreateFactoryTableDialog(…)`

```csharp
interface FactoryTableDialog
{
    // Properties
    int ActiveTabIndex { get; set; }
    string[] CustomInput { get; }
    string DestinationFileName { get; set; }
    string DialogTitle { get; set; }
    string FullFileName { get; set; }
    bool IsCustomFactory { get; }
    int SelectedTableRow { get; }
    // Methods
    void Show();
}
```

**Returned by:** [Application](../objects/Application.md).CreateFactoryTableDialog

