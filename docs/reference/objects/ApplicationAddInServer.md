# ApplicationAddInServer

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface ApplicationAddInServer
{
    // Properties
    object Automation { get; }
    // Methods
    void Activate(ApplicationAddInSite AddInSiteObject, bool FirstTime);
    void Deactivate();
    void ExecuteCommand(int CommandID);
}
```

**Referenced types:** [ApplicationAddInSite](../objects/ApplicationAddInSite.md)

