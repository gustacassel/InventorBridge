# SketchFillRegions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).BorderDefinitions.Item[…].Sketch.SketchFillRegions`

```csharp
interface SketchFillRegions
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchFillRegion Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchFillRegion Add(Profile Profile, object Color = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingSketch](../objects/DrawingSketch.md).SketchFillRegions

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Profile](../objects/Profile.md), [SketchFillRegion](../objects/SketchFillRegion.md)

