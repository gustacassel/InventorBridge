# DisplayOptions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.DisplayOptions`

```csharp
interface DisplayOptions
{
    // Properties
    object Application { get; }
    bool AreTexturesOn { get; set; }
    bool AutoUpdateReferringDocuments { get; set; }
    OrbitTypeEnum DefaultOrbitType { get; set; }
    bool DepthDimming { get; set; }
    DisplayQualityEnum DisplayQuality { get; set; }
    bool DisplaySilhouettes { get; set; }
    Color EdgeColor { get; set; }
    bool EnableSmoothSketchLines { get; set; } // since 2025
    int HiddenLineDimmingPercent { get; set; }
    Color InactiveComponentsEdgeColor { get; set; }
    bool InactiveComponentsEdgeDisplay { get; set; }
    bool InactiveComponentsEdgeDisplayFollowVisibility { get; set; } // since 2025
    int InactiveComponentsShadeOpacity { get; set; }
    bool InactiveComponentsShaded { get; set; }
    double MinimumFrameRate { get; set; }
    DisplayModeEnum NewWindowDisplayMode { get; set; }
    ProjectionTypeEnum NewWindowProjectionType { get; set; }
    bool NewWindowShowAmbientShadows { get; set; }
    bool NewWindowShowGroundPlane { get; set; }
    bool NewWindowShowGroundReflections { get; set; }
    bool NewWindowShowGroundShadows { get; set; }
    bool NewWindowShowObjectShadows { get; set; }
    RayTracingQualityEnum RayTracingQuality { get; set; }
    bool ReverseZoomDirection { get; set; }
    bool Show3DIndicator { get; set; }
    bool ShowXYZAxisLabels { get; set; }
    bool SolidLinesForHiddenEdges { get; set; }
    Color TransparentComponentsEdgeColor { get; set; } // since 2025
    bool TransparentComponentsEdgeDisplay { get; set; } // since 2025
    bool TransparentComponentsEdgeDisplayFollowVisibility { get; set; } // since 2025
    int TransparentComponentsShadeOpacity { get; set; } // since 2025
    bool TransparentComponentsShaded { get; set; } // since 2025
    ObjectTypeEnum Type { get; }
    bool UseDocumentDisplaySettings { get; set; }
    bool UseNearestModelPointForOrbit { get; set; }
    bool UseRayTracingForRealisticDisplay { get; set; }
    double ViewTransitionTime { get; set; }
    bool ZoomToCursor { get; set; }
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).DisplayOptions, [ApprenticeServer](../objects/ApprenticeServer.md).DisplayOptions, [ApprenticeServerComponent](../objects/ApprenticeServerComponent.md).DisplayOptions, [InventorServer](../objects/InventorServer.md).DisplayOptions

**Referenced types:** [Color](../objects/Color.md), [DisplayModeEnum](../enums/DisplayModeEnum.md), [DisplayQualityEnum](../enums/DisplayQualityEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [OrbitTypeEnum](../enums/OrbitTypeEnum.md), [ProjectionTypeEnum](../enums/ProjectionTypeEnum.md), [RayTracingQualityEnum](../enums/RayTracingQualityEnum.md)

