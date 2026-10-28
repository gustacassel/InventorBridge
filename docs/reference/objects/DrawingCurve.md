# DrawingCurve

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingViews.Item[…].AuxiliaryOrientationEdge`

```csharp
interface DrawingCurve
{
    // Properties
    object Application { get; }
    Point2d CenterPoint { get; }
    Color Color { get; set; }
    CurveTypeEnum CurveType { get; }
    DrawingEdgeTypeEnum EdgeType { get; }
    Point2d EndPoint { get; }
    Curve2dEvaluator Evaluator2D { get; }
    CurveEvaluator Evaluator3D { get; }
    LineTypeEnum LineType { get; set; }
    double LineWeight { get; set; }
    Point2d MidPoint { get; }
    object ModelGeometry { get; }
    DrawingView Parent { get; }
    Curve2dTypeEnum ProjectedCurveType { get; }
    DrawingCurveSegments Segments { get; }
    Point2d StartPoint { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BendNote](../objects/BendNote.md).BendEdge, [BreakOperation](../objects/BreakOperation.md).AlignedCurve, [DetailDrawingView](../objects/DetailDrawingView.md).AuxiliaryOrientationEdge, [DrawingCurveSegment](../objects/DrawingCurveSegment.md).Parent, [DrawingCurvesEnumerator](../objects/DrawingCurvesEnumerator.md).Item, [DrawingView](../objects/DrawingView.md).AuxiliaryOrientationEdge, [SectionDrawingView](../objects/SectionDrawingView.md).AuxiliaryOrientationEdge

**Referenced types:** [Color](../objects/Color.md), [Curve2dEvaluator](../objects/Curve2dEvaluator.md), [Curve2dTypeEnum](../enums/Curve2dTypeEnum.md), [CurveEvaluator](../objects/CurveEvaluator.md), [CurveTypeEnum](../enums/CurveTypeEnum.md), [DrawingCurveSegments](../objects/DrawingCurveSegments.md), [DrawingEdgeTypeEnum](../enums/DrawingEdgeTypeEnum.md), [DrawingView](../objects/DrawingView.md), [LineTypeEnum](../enums/LineTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md)

