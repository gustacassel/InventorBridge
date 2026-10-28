# BreakOutOperations

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingViews.Item[…].BreakOutOperations`

```csharp
interface BreakOutOperations
{
    // Properties
    object Application { get; }
    int Count { get; }
    BreakOutOperation Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    BreakOutOperation Add(Profile Profile, object DepthSource, double DepthValue = 0, bool SectionAllParts = false);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DetailDrawingView](../objects/DetailDrawingView.md).BreakOutOperations, [DrawingView](../objects/DrawingView.md).BreakOutOperations, [SectionDrawingView](../objects/SectionDrawingView.md).BreakOutOperations

**Referenced types:** [BreakOutOperation](../objects/BreakOutOperation.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Profile](../objects/Profile.md)

