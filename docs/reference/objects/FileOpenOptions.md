# FileOpenOptions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.FileOptions.FileOpenOptions`

```csharp
interface FileOpenOptions
{
    // Properties
    DesignViewTypeEnum DefaultDesignViewInAssembly { get; set; }
    DesignViewTypeEnum DefaultDesignViewInPart { get; set; }
    bool DefaultDesignViewIsAssociativeInAssembly { get; set; }
    bool DefaultDesignViewIsAssociativeInPart { get; set; }
    ModelStateTypeEnum DefaultModelStateInAssembly { get; set; }
    ModelStateTypeEnum DefaultModelStateInPart { get; set; }
    bool SkipAllUnresolvedFilesInAssembly { get; set; }
    bool SkipAllUnresolvedFilesInDrawing { get; set; }
    bool SkipAllUnresolvedFilesInPart { get; set; }
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FileOptions](../objects/FileOptions.md).FileOpenOptions

**Referenced types:** [DesignViewTypeEnum](../enums/DesignViewTypeEnum.md), [ModelStateTypeEnum](../enums/ModelStateTypeEnum.md)

