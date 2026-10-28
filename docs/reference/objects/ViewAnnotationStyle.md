# ViewAnnotationStyle

Inventor API object · versions: 2025, 2026, 2027 · [index](../index.md)

**Inherits from:** [Style](../objects/Style.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.ViewAnnotationStyles.Item[…]`

```csharp
interface ViewAnnotationStyle
{
    // Properties
    object Application { get; } // since 2025
    string Comments { get; set; } // since 2025
    CropViewAnnotationStyleSettings CropViewAnnotationSettings { get; } // since 2025
    bool InUse { get; } // since 2025
    string InternalName { get; } // since 2025
    string Name { get; set; } // since 2025
    object Parent { get; } // since 2025
    StyleLocationEnum StyleLocation { get; } // since 2025
    StyleTypeEnum StyleType { get; } // since 2025
    ObjectTypeEnum Type { get; } // since 2025
    bool UpToDate { get; } // since 2025
    // Methods
    Style ConvertToLocal(); // since 2025
    Style Copy(string Name); // since 2025
    void Delete(); // since 2025
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0); // since 2025
    void SaveToGlobal(); // since 2025
    void UpdateFromGlobal(); // since 2025
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [CropOperation](../objects/CropOperation.md).Style, [DrawingViewAnnotation](../objects/DrawingViewAnnotation.md).Style, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).AuxiliaryViewLineStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).CropCutLineStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).DetailViewCalloutStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).SectionViewLineStyle, [ViewAnnotationStylesEnumerator](../objects/ViewAnnotationStylesEnumerator.md).Item

**Referenced types:** [CropViewAnnotationStyleSettings](../objects/CropViewAnnotationStyleSettings.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Style](../objects/Style.md), [StyleLocationEnum](../enums/StyleLocationEnum.md), [StyleTypeEnum](../enums/StyleTypeEnum.md)

