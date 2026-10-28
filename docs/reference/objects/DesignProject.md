# DesignProject

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.DesignProjectManager.DesignProjects.Item[…]`

```csharp
interface DesignProject
{
    // Properties
    ProjectAssetLibrary ActiveAppearanceLibrary { get; }
    ProjectAssetLibrary ActiveMaterialLibrary { get; }
    ProjectAssetLibraries AppearanceLibraries { get; }
    object Application { get; }
    string ContentCenterPath { get; set; }
    bool ContentCenterPathOverridden { get; set; }
    DateTime CreationTime { get; set; }
    string DesignDataPath { get; set; }
    bool DesignDataPathOverridden { get; set; }
    ProjectPaths FrequentlyUsedPaths { get; }
    string FullFileName { get; }
    string IncludedProject { get; set; }
    ProjectPaths LibraryPaths { get; }
    ProjectAssetLibraries MaterialLibraries { get; }
    string Name { get; set; }
    int OldVersionsToKeep { get; set; }
    string Owner { get; set; }
    DesignProjectManager Parent { get; }
    string PresetsPath { get; set; }
    bool PresetsPathOverridden { get; set; }
    MultiUserModeEnum ProjectType { get; set; }
    string ReleaseId { get; set; }
    object Shortcuts { get; set; }
    StylesLibraryAccessEnum StylesLibraryAccess { get; set; }
    string TemplatesPath { get; set; }
    bool TemplatesPathOverridden { get; set; }
    ObjectTypeEnum Type { get; }
    bool UsingUniqueFileNames { get; set; }
    string VaultName { get; set; }
    string VaultPublishPath { get; set; }
    string VaultServer { get; set; }
    string VaultVirtualPath { get; set; }
    ProjectPaths WorkgroupPaths { get; }
    string WorkspacePath { get; set; }
    // Methods
    void Activate(bool SetAsDefaultProject = true);
    string GetCustomSection(string Name);
    string GetIncludedCustomSection(string Name);
    void Remove();
    void SetCustomSection(string Name, string CustomSection);
}
```

6 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DesignProjectManager](../objects/DesignProjectManager.md).ActiveDesignProject, [DesignProjects](../objects/DesignProjects.md).Add, [DesignProjects](../objects/DesignProjects.md).AddExisting, [DesignProjects](../objects/DesignProjects.md).Item, [DesignProjects](../objects/DesignProjects.md).ItemByName, [ProjectAssetLibrary](../objects/ProjectAssetLibrary.md).Parent, [ProjectPath](../objects/ProjectPath.md).Parent

**Referenced types:** [DesignProjectManager](../objects/DesignProjectManager.md), [MultiUserModeEnum](../enums/MultiUserModeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ProjectAssetLibraries](../objects/ProjectAssetLibraries.md), [ProjectAssetLibrary](../objects/ProjectAssetLibrary.md), [ProjectPaths](../objects/ProjectPaths.md), [StylesLibraryAccessEnum](../enums/StylesLibraryAccessEnum.md)

