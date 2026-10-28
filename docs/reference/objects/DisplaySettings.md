# DisplaySettings

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).DisplaySettings`

```csharp
interface DisplaySettings
{
    // Properties
    object Application { get; }
    bool AreTexturesOn { get; set; }
    bool DepthDimming { get; set; }
    bool DisplaySilhouettes { get; set; }
    Color EdgeColor { get; set; }
    GroundPlaneSettings GroundPlaneSettings { get; }
    int HiddenLineDimmingPercent { get; set; }
    DisplayModeEnum NewWindowDisplayMode { get; set; }
    ProjectionTypeEnum NewWindowProjectionType { get; set; }
    bool NewWindowShowAmbientShadows { get; set; }
    bool NewWindowShowGroundPlane { get; set; }
    bool NewWindowShowGroundReflections { get; set; }
    bool NewWindowShowGroundShadows { get; set; }
    bool NewWindowShowObjectShadows { get; set; }
    object Parent { get; }
    RayTracingQualityEnum RayTracingQuality { get; set; }
    bool SolidLinesForHiddenEdges { get; set; }
    ObjectTypeEnum Type { get; }
    bool UseRayTracingForRealisticDisplay { get; set; }
}
```

**Returned by:** [AssemblyDocument](../objects/AssemblyDocument.md).DisplaySettings, [PartDocument](../objects/PartDocument.md).DisplaySettings, [PresentationDocument](../objects/PresentationDocument.md).DisplaySettings

**Referenced types:** [Color](../objects/Color.md), [DisplayModeEnum](../enums/DisplayModeEnum.md), [GroundPlaneSettings](../objects/GroundPlaneSettings.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ProjectionTypeEnum](../enums/ProjectionTypeEnum.md), [RayTracingQualityEnum](../enums/RayTracingQualityEnum.md)

