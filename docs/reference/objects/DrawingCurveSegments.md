# DrawingCurveSegments

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingViews.Item[…].AuxiliaryOrientationEdge.Segments`

```csharp
interface DrawingCurveSegments
{
    // Properties
    object Application { get; }
    int Count { get; }
    DrawingCurveSegment Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingCurve](../objects/DrawingCurve.md).Segments

**Referenced types:** [DrawingCurveSegment](../objects/DrawingCurveSegment.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

