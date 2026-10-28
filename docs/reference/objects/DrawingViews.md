# DrawingViews

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingViews`

```csharp
interface DrawingViews
{
    // Properties
    int Count { get; }
    DrawingView Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    DrawingView AddAssociativeDraftView(Document Model, Point2d Position, double Scale = 1, string Name = "");
    DrawingView AddAuxiliaryView(DrawingView ParentView, DrawingCurve OrientationEdge, Point2d Position, DrawingViewStyleEnum ViewStyle, object Scale = Missing, bool ShowLabel = true, string Name = "");
    DrawingView AddBaseView(Document Model, Point2d Position, double Scale, ViewOrientationTypeEnum ViewOrientation, DrawingViewStyleEnum ViewStyle, string ModelViewName = "", object ArbitraryCamera = Missing, object AdditionalOptions = Missing);
    DetailDrawingView AddDetailView(DrawingView ParentView, Point2d Position, DrawingViewStyleEnum ViewStyle, bool CircularFence, Point2d FenceCenterOrCornerOne, object FenceRadiusOrCornerTwo, object AttachPoint = Missing, object Scale = Missing, bool ShowLabel = true, string Name = "", bool Reserved = true);
    DrawingView AddDraftView(double Scale = 1, string Name = "");
    DrawingView AddOverlayView(DrawingView ParentView, string PositionalRepresentation, string DesignViewRepresentation, bool DesignViewAssociative, DrawingViewStyleEnum ViewStyle, bool ShowLabel = true, string Name = "");
    DrawingView AddOverlayView2(DrawingView ParentView, string ModelState, string PositionalRepresentation, string DesignViewRepresentation, bool DesignViewAssociative, DrawingViewStyleEnum ViewStyle, bool ShowLabel = true, string Name = "");
    DrawingView AddProjectedView(DrawingView ParentView, Point2d Position, DrawingViewStyleEnum ViewStyle, object Scale = Missing);
    SectionDrawingView AddSectionView(DrawingView ParentView, DrawingSketch SectionLineSketch, Point2d Position, DrawingViewStyleEnum ViewStyle, object Scale = Missing, bool ShowLabel = true, string Name = "", bool Reserved = true, bool FullDepth = true, object SectionDepth = Missing);
    SectionDrawingView AddSectionView2(DrawingView ParentView, DrawingSketch SectionLineSketch, Point2d Position, DrawingViewStyleEnum ViewStyle, object Scale = Missing, bool ShowLabel = true, string Name = "", bool FullDepth = true, object SectionDepth = Missing, object MoreOptions = Missing); // since 2025
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sheet](../objects/Sheet.md).DrawingViews

**Referenced types:** [DetailDrawingView](../objects/DetailDrawingView.md), [Document](../objects/Document.md), [DrawingCurve](../objects/DrawingCurve.md), [DrawingSketch](../objects/DrawingSketch.md), [DrawingView](../objects/DrawingView.md), [DrawingViewStyleEnum](../enums/DrawingViewStyleEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [SectionDrawingView](../objects/SectionDrawingView.md), [ViewOrientationTypeEnum](../enums/ViewOrientationTypeEnum.md)

