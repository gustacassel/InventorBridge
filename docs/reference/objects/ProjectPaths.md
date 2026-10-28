# ProjectPaths

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.DesignProjectManager.DesignProjects.Item[…].FrequentlyUsedPaths`

```csharp
interface ProjectPaths
{
    // Properties
    object Application { get; }
    int Count { get; }
    ProjectPath Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ProjectPath Add(string Name, string Path, int TargetIndex = 0);
    void AddFromFile(string ProjectFullFileName);
    void Clear();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DesignProject](../objects/DesignProject.md).FrequentlyUsedPaths, [DesignProject](../objects/DesignProject.md).LibraryPaths, [DesignProject](../objects/DesignProject.md).WorkgroupPaths

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ProjectPath](../objects/ProjectPath.md)

