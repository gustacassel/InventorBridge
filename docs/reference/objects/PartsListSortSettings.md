# PartsListSortSettings

Inventor API object · versions: 2025, 2026, 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.PartsListStyles.Item[…].SortSettings`

```csharp
interface PartsListSortSettings
{
    // Properties
    object Application { get; } // since 2025
    bool AutoSortOnUpdate { get; set; } // since 2025
    object Parent { get; } // since 2025
    bool PrimaryColumnAscending { get; set; } // since 2025
    string PrimaryColumnTitle { get; set; } // since 2025
    bool SecondaryColumnAscending { get; set; } // since 2025
    string SecondaryColumnTitle { get; set; } // since 2025
    bool SortNumerically { get; set; } // since 2025
    bool TertiaryColumnAscending { get; set; } // since 2025
    string TertiaryColumnTitle { get; set; } // since 2025
    ObjectTypeEnum Type { get; } // since 2025
}
```

**Returned by:** [PartsListStyle](../objects/PartsListStyle.md).SortSettings

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

