# ApplicationAddIn

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ApplicationAddIns.Item[…]`

```csharp
interface ApplicationAddIn
{
    // Properties
    bool Activated { get; }
    ApplicationAddInTypeEnum AddInType { get; }
    object Application { get; }
    object Automation { get; }
    string ClassIdString { get; }
    string ClientId { get; }
    int DataVersion { get; set; }
    string Description { get; }
    string DisplayName { get; }
    bool Hidden { get; set; }
    AddInLicenseStatusEnum LicenseStatus { get; }
    bool LoadAutomatically { get; set; }
    AddInLoadBehaviorEnum LoadBehavior { get; }
    string Location { get; }
    object Parent { get; }
    string ProgId { get; }
    string ShortDisplayName { get; }
    ObjectTypeEnum Type { get; }
    int UserInterfaceVersion { get; }
    bool UserUnloadable { get; set; }
    // Methods
    void Activate();
    void Deactivate();
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ApplicationAddInSite](../objects/ApplicationAddInSite.md).Parent, [ApplicationAddIns](../objects/ApplicationAddIns.md).Item, [ApplicationAddIns](../objects/ApplicationAddIns.md).ItemById

**Referenced types:** [AddInLicenseStatusEnum](../enums/AddInLicenseStatusEnum.md), [AddInLoadBehaviorEnum](../enums/AddInLoadBehaviorEnum.md), [ApplicationAddInTypeEnum](../enums/ApplicationAddInTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

