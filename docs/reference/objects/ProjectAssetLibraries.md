# ProjectAssetLibraries

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.DesignProjectManager.DesignProjects.Item[…].AppearanceLibraries`

```csharp
interface ProjectAssetLibraries
{
    // Properties
    object Application { get; }
    int Count { get; }
    ProjectAssetLibrary Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ProjectAssetLibrary Add(string LibraryFilename);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DesignProject](../objects/DesignProject.md).AppearanceLibraries, [DesignProject](../objects/DesignProject.md).MaterialLibraries

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ProjectAssetLibrary](../objects/ProjectAssetLibrary.md)

