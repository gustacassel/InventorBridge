# GroundPlaneSettings

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).DisplaySettings.GroundPlaneSettings`

```csharp
interface GroundPlaneSettings
{
    // Properties
    object Application { get; }
    bool AutoResize { get; set; }
    Color Color { get; set; }
    bool DisplayGridLines { get; set; }
    UnitVector FrontDirection { get; }
    double HeightOffset { get; set; }
    double MinorGridLineSpacing { get; set; }
    int MinorLinesPerMajorGridLine { get; set; }
    double Opacity { get; set; }
    Plane Plane { get; }
    object Position { get; set; }
    double ReflectionBlur { get; set; }
    double ReflectionBlurFalloff { get; set; }
    double Reflectivity { get; set; }
    ObjectTypeEnum Type { get; }
    UnitVector UpDirection { get; }
    // Methods
    void GetSize(out Point PointOne, out Point PointTwo);
    void SetSize(Point PointOne, Point PointTwo);
}
```

**Returned by:** [DisplaySettings](../objects/DisplaySettings.md).GroundPlaneSettings

**Referenced types:** [Color](../objects/Color.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Plane](../objects/Plane.md), [Point](../objects/Point.md), [UnitVector](../objects/UnitVector.md)

