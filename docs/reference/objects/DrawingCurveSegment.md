# DrawingCurveSegment

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingViews.Item[…].AuxiliaryOrientationEdge.Segments.Item[…]`

```csharp
interface DrawingCurveSegment
{
    // Properties
    object Application { get; }
    Point2d EndPoint { get; }
    object Geometry { get; }
    Curve2dTypeEnum GeometryType { get; }
    bool HiddenLine { get; }
    Layer Layer { get; set; }
    DrawingCurve Parent { get; }
    Point2d StartPoint { get; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
}
```

**Returned by:** [DrawingCurveSegments](../objects/DrawingCurveSegments.md).Item

**Referenced types:** [Curve2dTypeEnum](../enums/Curve2dTypeEnum.md), [DrawingCurve](../objects/DrawingCurve.md), [Layer](../objects/Layer.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md)

