# CropViewAnnotationStyleSettings

Inventor API object · versions: 2025, 2026, 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.ViewAnnotationStyles.Item[…].CropViewAnnotationSettings`

```csharp
interface CropViewAnnotationStyleSettings
{
    // Properties
    object Application { get; } // since 2025
    CropViewBreakMarkLineTypeEnum CropBreakMarkLineType { get; set; } // since 2025
    double DistanceBetweenSymbols { get; set; } // since 2025
    object Parent { get; } // since 2025
    double SymbolSize { get; set; } // since 2025
    ObjectTypeEnum Type { get; } // since 2025
}
```

**Returned by:** [ViewAnnotationStyle](../objects/ViewAnnotationStyle.md).CropViewAnnotationSettings

**Referenced types:** [CropViewBreakMarkLineTypeEnum](../enums/CropViewBreakMarkLineTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

