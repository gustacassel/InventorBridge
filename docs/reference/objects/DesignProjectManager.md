# DesignProjectManager

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.DesignProjectManager`

```csharp
interface DesignProjectManager
{
    // Properties
    DesignProject ActiveDesignProject { get; }
    object Application { get; }
    DesignProjects DesignProjects { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ProjectOptionsButton AddOptionsButton(string ClientId, string DisplayName, string ToolTipText, object StandardIcon = Missing);
    bool IsFileInActiveProject(string FileName, out LocationTypeEnum ProjectPathType, out string ProjectPathName);
    string ResolveFile(string SourcePath, string DestinationFileName, object Options = Missing);
}
```

**Returned by:** [Application](../objects/Application.md).DesignProjectManager, [ApprenticeServer](../objects/ApprenticeServer.md).DesignProjectManager, [ApprenticeServerComponent](../objects/ApprenticeServerComponent.md).DesignProjectManager, [DesignProject](../objects/DesignProject.md).Parent, [InventorServer](../objects/InventorServer.md).DesignProjectManager

**Referenced types:** [DesignProject](../objects/DesignProject.md), [DesignProjects](../objects/DesignProjects.md), [LocationTypeEnum](../enums/LocationTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ProjectOptionsButton](../objects/ProjectOptionsButton.md)

