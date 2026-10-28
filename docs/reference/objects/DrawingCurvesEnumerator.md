# DrawingCurvesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingViews.Item[…].DrawingCurves[…]`

```csharp
interface DrawingCurvesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    DrawingCurve Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DetailDrawingView](../objects/DetailDrawingView.md).DrawingCurves, [DrawingView](../objects/DrawingView.md).DrawingCurves, [SectionDrawingView](../objects/SectionDrawingView.md).DrawingCurves

**Referenced types:** [DrawingCurve](../objects/DrawingCurve.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

