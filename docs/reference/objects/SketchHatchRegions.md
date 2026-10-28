# SketchHatchRegions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).BorderDefinitions.Item[…].Sketch.SketchHatchRegions`

```csharp
interface SketchHatchRegions
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchHatchRegion Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchHatchRegion Add(Profile Profile, object DrawingHatchPattern = Missing, object Angle = Missing, object Scale = Missing, object Shift = Missing, object LineWeight = Missing, object DoublePattern = Missing, object Color = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingSketch](../objects/DrawingSketch.md).SketchHatchRegions

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Profile](../objects/Profile.md), [SketchHatchRegion](../objects/SketchHatchRegion.md)

