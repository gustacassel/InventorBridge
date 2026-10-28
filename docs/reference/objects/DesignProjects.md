# DesignProjects

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.DesignProjectManager.DesignProjects`

```csharp
interface DesignProjects
{
    // Properties
    object Application { get; }
    int Count { get; }
    DesignProject Item[int Index] { get; }
    DesignProject ItemByName[string NameOrFileName] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    DesignProject Add(MultiUserModeEnum ProjectType, string Name, string ProjectPath);
    DesignProject AddExisting(string FullFileName);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DesignProjectManager](../objects/DesignProjectManager.md).DesignProjects

**Referenced types:** [DesignProject](../objects/DesignProject.md), [MultiUserModeEnum](../enums/MultiUserModeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

