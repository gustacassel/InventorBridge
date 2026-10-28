# RevisionIndexDefaults

Inventor API object · versions: 2025, 2026, 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.RevisionTableStyles.Item[…].RevisionIndexDefaults`

```csharp
interface RevisionIndexDefaults
{
    // Properties
    object Application { get; } // since 2025
    bool AutoIndex { get; set; } // since 2025
    string IndexStartValue { get; set; } // since 2025
    object Parent { get; } // since 2025
    ObjectTypeEnum Type { get; } // since 2025
    bool UpdatePropertyOnRevisionNumberEdit { get; set; } // since 2025
    bool UseNumericIndex { get; set; } // since 2025
}
```

**Returned by:** [RevisionTableStyle](../objects/RevisionTableStyle.md).RevisionIndexDefaults

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

