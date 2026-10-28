# DrawingSketches

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.Sketches`

```csharp
interface DrawingSketches
{
    // Properties
    object Application { get; }
    int Count { get; }
    DrawingSketch Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    DrawingSketch Add();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DetailDrawingView](../objects/DetailDrawingView.md).Sketches, [DrawingView](../objects/DrawingView.md).Sketches, [SectionDrawingView](../objects/SectionDrawingView.md).Sketches, [Sheet](../objects/Sheet.md).Sketches

**Referenced types:** [DrawingSketch](../objects/DrawingSketch.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

