# CropOperations

Inventor API object · versions: 2025, 2026, 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingViews.Item[…].CropOperations`

```csharp
interface CropOperations
{
    // Properties
    object Application { get; } // since 2025
    int Count { get; } // since 2025
    CropOperation Item[int Index] { get; } // since 2025
    ObjectTypeEnum Type { get; } // since 2025
    // Methods
    CropOperation Add(bool UseCircularBoundaryType, Point2d BoundaryCenterOrCornerOne, object BoundaryRadiusOrCornerTwo, bool DisplayCropCutLine = true, object Options = Missing); // since 2025
    CropOperation AddBySketch(DrawingSketch CropBoundarySketch, bool DisplayCropCutLine = true, object Reserved = Missing); // since 2025
}
```

**Returned by:** [DetailDrawingView](../objects/DetailDrawingView.md).CropOperations, [DrawingView](../objects/DrawingView.md).CropOperations, [SectionDrawingView](../objects/SectionDrawingView.md).CropOperations

**Referenced types:** [CropOperation](../objects/CropOperation.md), [DrawingSketch](../objects/DrawingSketch.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md)

