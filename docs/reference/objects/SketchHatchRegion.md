# SketchHatchRegion

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).BorderDefinitions.Item[…].Sketch.SketchHatchRegions.Item[…]`

```csharp
interface SketchHatchRegion
{
    // Properties
    double Angle { get; set; }
    object Application { get; }
    Color Color { get; set; }
    bool DoublePattern { get; set; }
    Layer Layer { get; set; }
    double LineWeight { get; set; }
    DrawingSketch Parent { get; }
    DrawingHatchPattern Pattern { get; set; }
    Profile Profile { get; }
    double Scale { get; set; }
    double Shift { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
}
```

**Returned by:** [SketchHatchRegions](../objects/SketchHatchRegions.md).Add, [SketchHatchRegions](../objects/SketchHatchRegions.md).Item

**Referenced types:** [Color](../objects/Color.md), [DrawingHatchPattern](../objects/DrawingHatchPattern.md), [DrawingSketch](../objects/DrawingSketch.md), [Layer](../objects/Layer.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Profile](../objects/Profile.md)

