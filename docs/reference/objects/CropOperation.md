# CropOperation

Inventor API object · versions: 2025, 2026, 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingViews.Item[…].CropOperations.Item[…]`

```csharp
interface CropOperation
{
    // Properties
    object Application { get; } // since 2025
    AttributeSets AttributeSets { get; } // since 2025
    DrawingSketch CropBoundarySketch { get; } // since 2025
    bool DisplayCropCutLine { get; set; } // since 2025
    DrawingView Parent { get; } // since 2025
    ViewAnnotationStyle Style { get; set; } // since 2025
    ObjectTypeEnum Type { get; } // since 2025
    // Methods
    void Delete(); // since 2025
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0); // since 2025
}
```

**Returned by:** [CropOperations](../objects/CropOperations.md).Add, [CropOperations](../objects/CropOperations.md).AddBySketch, [CropOperations](../objects/CropOperations.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [DrawingSketch](../objects/DrawingSketch.md), [DrawingView](../objects/DrawingView.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ViewAnnotationStyle](../objects/ViewAnnotationStyle.md)

