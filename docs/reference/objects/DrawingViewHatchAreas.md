# DrawingViewHatchAreas

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingViews.Item[…].HatchRegions.Item[…].HatchAreas`

```csharp
interface DrawingViewHatchAreas
{
    // Properties
    object Application { get; }
    int Count { get; }
    DrawingViewHatchArea Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingViewHatchRegion](../objects/DrawingViewHatchRegion.md).HatchAreas

**Referenced types:** [DrawingViewHatchArea](../objects/DrawingViewHatchArea.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

