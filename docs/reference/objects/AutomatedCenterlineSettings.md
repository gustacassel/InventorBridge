# AutomatedCenterlineSettings

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).DrawingSettings.AutomatedCenterlineSettings`

```csharp
interface AutomatedCenterlineSettings
{
    // Properties
    object Application { get; }
    bool ApplyToBends { get; set; }
    bool ApplyToCircularPatterns { get; set; }
    bool ApplyToCylinders { get; set; }
    bool ApplyToFillets { get; set; }
    bool ApplyToHoles { get; set; }
    bool ApplyToPunches { get; set; }
    bool ApplyToRectangularPatterns { get; set; }
    bool ApplyToRevolutions { get; set; }
    bool ApplyToSketches { get; set; }
    bool ApplyToWorkFeatures { get; set; }
    double ArcAngleThreshold { get; set; }
    double CircularEdgeMaximumThreshold { get; set; }
    double CircularEdgeMinimumThreshold { get; set; }
    double FilletRadiusMaximumThreshold { get; set; }
    double FilletRadiusMinimumThreshold { get; set; }
    bool ProjectionNormalAxis { get; set; }
    bool ProjectionParallelAxis { get; set; }
    int RadiusThresholdPrecision { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [DrawingSettings](../objects/DrawingSettings.md).AutomatedCenterlineSettings

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

