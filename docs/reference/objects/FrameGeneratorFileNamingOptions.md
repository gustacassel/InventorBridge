# FrameGeneratorFileNamingOptions

Inventor API object · versions: 2026, 2027 · [index](../index.md)

**How to get it:** `Application.FileOptions.FileNamingDefaultsOptions.FrameGeneratorFileNamingOptions`

```csharp
interface FrameGeneratorFileNamingOptions
{
    // Properties
    string EndCapDisplayName { get; set; } // since 2026
    string EndCapFileName { get; set; } // since 2026
    BOMStructureEnum FrameAssemblyBOMStructure { get; set; } // since 2026
    string FrameAssemblyDisplayName { get; set; } // since 2026
    string FrameAssemblyFileName { get; set; } // since 2026
    string FrameAssemblyLocation { get; set; } // since 2026
    string FrameMemberDisplayName { get; set; } // since 2026
    string FrameMemberFileName { get; set; } // since 2026
    bool IsDefaultEndCapDisplayName { get; set; } // since 2026
    bool IsDefaultEndCapFileName { get; set; } // since 2026
    bool IsDefaultFrameAssemblyDisplayName { get; set; } // since 2026
    bool IsDefaultFrameAssemblyFileName { get; set; } // since 2026
    bool IsDefaultFrameAssemblyLocation { get; set; } // since 2026
    bool IsDefaultFrameMemberDisplayName { get; set; } // since 2026
    bool IsDefaultFrameMemberFileName { get; set; } // since 2026
    bool IsDefaultSkeletonPartDisplayName { get; set; } // since 2026
    bool IsDefaultSkeletonPartFileName { get; set; } // since 2026
    bool OverwriteCurrentFileForSizeChange { get; set; } // since 2026
    string SkeletonPartDisplayName { get; set; } // since 2026
    string SkeletonPartFileName { get; set; } // since 2026
    ObjectTypeEnum Type { get; } // since 2026
    bool UseAssemblyUnits { get; set; } // since 2026
    bool UseFileNameAsDisplayName { get; set; } // since 2026
}
```

**Returned by:** [FileNamingDefaultsOptions](../objects/FileNamingDefaultsOptions.md).FrameGeneratorFileNamingOptions

**Referenced types:** [BOMStructureEnum](../enums/BOMStructureEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

