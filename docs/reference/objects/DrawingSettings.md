# DrawingSettings

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).DrawingSettings`

```csharp
interface DrawingSettings
{
    // Properties
    bool AlwaysUseBitmapsForShadedViews { get; set; }
    object Application { get; }
    bool ApplySpecularEffect { get; set; }
    AutomatedCenterlineSettings AutomatedCenterlineSettings { get; }
    BitmapResolutionTypeEnum BitmapResolution { get; set; }
    bool CrossHatchClipping { get; set; }
    string CustomPropertySourceFile { get; set; }
    bool DeferUpdates { get; set; }
    DimensionTextAlignmentEnum DimensionTextAlignment { get; set; }
    bool HighlightInvalidAnnotations { get; set; }
    Color InvalidFeatureBasedAnnotationsColor { get; set; }
    OfflineImageFidelityEnum OfflineImageFidelity { get; set; }
    DrawingDocument Parent { get; }
    bool PreserveOrphanedAnnotations { get; set; }
    string ReflectionEnvironmentFilePath { get; set; }
    bool ReflectionEnvironmentUseApplicationOptions { get; set; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingDocument](../objects/DrawingDocument.md).DrawingSettings

**Referenced types:** [AutomatedCenterlineSettings](../objects/AutomatedCenterlineSettings.md), [BitmapResolutionTypeEnum](../enums/BitmapResolutionTypeEnum.md), [Color](../objects/Color.md), [DimensionTextAlignmentEnum](../enums/DimensionTextAlignmentEnum.md), [DrawingDocument](../objects/DrawingDocument.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [OfflineImageFidelityEnum](../enums/OfflineImageFidelityEnum.md)

