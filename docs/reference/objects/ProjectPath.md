# ProjectPath

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.DesignProjectManager.DesignProjects.Item[…].FrequentlyUsedPaths.Item[…]`

```csharp
interface ProjectPath
{
    // Properties
    object Application { get; }
    string Name { get; set; }
    DesignProject Parent { get; }
    string Path { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
}
```

**Returned by:** [ProjectPaths](../objects/ProjectPaths.md).Add, [ProjectPaths](../objects/ProjectPaths.md).Item

**Referenced types:** [DesignProject](../objects/DesignProject.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

