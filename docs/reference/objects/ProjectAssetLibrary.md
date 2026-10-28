# ProjectAssetLibrary

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.DesignProjectManager.DesignProjects.Item[…].AppearanceLibraries.Item[…]`

```csharp
interface ProjectAssetLibrary
{
    // Properties
    object Application { get; }
    string LibraryFilename { get; }
    string Name { get; }
    DesignProject Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Activate();
    void Delete();
}
```

**Returned by:** [DesignProject](../objects/DesignProject.md).ActiveAppearanceLibrary, [DesignProject](../objects/DesignProject.md).ActiveMaterialLibrary, [ProjectAssetLibraries](../objects/ProjectAssetLibraries.md).Add, [ProjectAssetLibraries](../objects/ProjectAssetLibraries.md).Item

**Referenced types:** [DesignProject](../objects/DesignProject.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

