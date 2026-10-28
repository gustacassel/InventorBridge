# EnvironmentManager

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).EnvironmentManager`

```csharp
interface EnvironmentManager
{
    // Properties
    Application Application { get; }
    Environment BaseEnvironment { get; }
    Environment EditObjectEnvironment { get; }
    Environment OverrideEnvironment { get; set; }
    Document Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetCurrentEnvironment(out Environment Environment, out string EditTargetId);
    void SetCurrentEnvironment(Environment Environment, string EditObjectId = "");
}
```

**Returned by:** [AssemblyDocument](../objects/AssemblyDocument.md).EnvironmentManager, [DrawingDocument](../objects/DrawingDocument.md).EnvironmentManager, [PartDocument](../objects/PartDocument.md).EnvironmentManager, [PresentationDocument](../objects/PresentationDocument.md).EnvironmentManager

**Referenced types:** [Application](../objects/Application.md), [Document](../objects/Document.md), [Environment](../objects/Environment.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

