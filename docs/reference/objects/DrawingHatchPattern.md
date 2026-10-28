# DrawingHatchPattern

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).DrawingHatchPatternsManager.Item[…]`

```csharp
interface DrawingHatchPattern
{
    // Properties
    object Application { get; }
    string Description { get; }
    string Name { get; }
    bool Offered { get; set; }
    DrawingHatchPatternsManager Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [DrawingHatchPatternsManager](../objects/DrawingHatchPatternsManager.md).Item, [DrawingViewHatchRegion](../objects/DrawingViewHatchRegion.md).Pattern, [SketchHatchRegion](../objects/SketchHatchRegion.md).Pattern

**Referenced types:** [DrawingHatchPatternsManager](../objects/DrawingHatchPatternsManager.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

