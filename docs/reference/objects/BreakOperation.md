# BreakOperation

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingViews.Item[…].BreakOperations.Item[…]`

```csharp
interface BreakOperation
{
    // Properties
    DrawingCurve AlignedCurve { get; } // since 2027
    ObjectsEnumerator AllAffectedViews { get; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    DrawingSketch BreakLineSketch { get; } // since 2026
    BreakStyleEnum BreakStyle { get; set; }
    int DisplayLevel { get; set; }
    Point2d EndPoint { get; set; }
    double Gap { get; set; }
    bool IsSourceBreakOperation { get; }
    Layer Layer { get; set; }
    Point2d MidPoint { get; set; }
    int NumberOfSymbols { get; set; }
    BreakOrientationEnum Orientation { get; }
    DrawingView Parent { get; }
    BreakOperation SourceBreakOperation { get; }
    Point2d StartPoint { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [BreakOperation](../objects/BreakOperation.md).SourceBreakOperation, [BreakOperations](../objects/BreakOperations.md).AddBySketch, [BreakOperations](../objects/BreakOperations.md).AddWithOptions, [BreakOperations](../objects/BreakOperations.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [BreakOrientationEnum](../enums/BreakOrientationEnum.md), [BreakStyleEnum](../enums/BreakStyleEnum.md), [DrawingCurve](../objects/DrawingCurve.md), [DrawingSketch](../objects/DrawingSketch.md), [DrawingView](../objects/DrawingView.md), [Layer](../objects/Layer.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [Point2d](../objects/Point2d.md)

