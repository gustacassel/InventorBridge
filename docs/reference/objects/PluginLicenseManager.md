# PluginLicenseManager

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface PluginLicenseManager
{
    // Properties
    object Application { get; }
    bool IsAuthorized { get; }
    string LicenseBehavior { get; }
    DateTime LicenseExpirationDate { get; }
    string LicenseExpirationState { get; }
    string LicenseSerialNumber { get; }
    string LicenseUsage { get; }
    PluginLicenseManagerEvents PluginLicenseEvents { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void DisplayAuthorizationInfo();
    void SetLicenseIdleMode(PluginLicenseIdleModeEnum Value);
}
```

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PluginLicenseIdleModeEnum](../enums/PluginLicenseIdleModeEnum.md), [PluginLicenseManagerEvents](../objects/PluginLicenseManagerEvents.md)

