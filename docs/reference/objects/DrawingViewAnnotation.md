# DrawingViewAnnotation

Inventor API object · versions: 2026, 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingViews.Item[…].ViewAnnotation`

```csharp
interface DrawingViewAnnotation
{
    // Properties
    object Application { get; } // since 2026
    AttributeSets AttributeSets { get; } // since 2026
    string FormattedText { get; set; } // since 2026
    DrawingView Parent { get; } // since 2026
    string SecondFormattedText { get; set; } // since 2026
    string SecondText { get; } // since 2026
    Point2d SecondTextPosition { get; set; } // since 2026
    ViewAnnotationStyle Style { get; set; } // since 2026
    string Text { get; } // since 2026
    Point2d TextPosition { get; set; } // since 2026
    ObjectTypeEnum Type { get; } // since 2026
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0); // since 2026
}
```

**Returned by:** [DetailDrawingView](../objects/DetailDrawingView.md).ViewAnnotation, [DrawingView](../objects/DrawingView.md).ViewAnnotation, [SectionDrawingView](../objects/SectionDrawingView.md).ViewAnnotation

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [DrawingView](../objects/DrawingView.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [ViewAnnotationStyle](../objects/ViewAnnotationStyle.md)

