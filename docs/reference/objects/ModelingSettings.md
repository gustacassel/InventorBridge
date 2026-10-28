# ModelingSettings

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ModelingSettings`

```csharp
interface ModelingSettings
{
    // Properties
    bool AdaptivelyUsedInAssembly { get; set; }
    bool AdvancedFeatureValidation { get; set; }
    bool AllowSectioningThruPart { get; set; }
    object Application { get; }
    bool AutoFindErrorsAfterManualRepair { get; set; }
    bool CompactModelHistory { get; set; }
    double InitialDrawingViewHeight { get; set; }
    double InitialDrawingViewWidth { get; set; }
    InteractiveContactAnalysisEnum InteractiveContactAnalysis { get; set; }
    InteractiveContactSurfacesEnum InteractiveContactSurfaces { get; set; }
    bool MaintainEnhancedGraphicsDetail { get; set; }
    Document Parent { get; }
    bool ShowConstraintStateInBrowser { get; set; }
    string Snap3DAngle { get; set; }
    string Snap3DDistance { get; set; }
    string SolidBodyNamePrefix { get; set; }
    string SurfaceBodyNamePrefix { get; set; }
    ModelDiameterFromThreadEnum TappedHoleDiameter { get; set; }
    ObjectTypeEnum Type { get; }
    bool UpdateLegacyHoles { get; set; }
    UserCoordinateSystemSettings UserCoordinateSystemSettings { get; }
}
```

**Returned by:** [AssemblyDocument](../objects/AssemblyDocument.md).ModelingSettings, [PartDocument](../objects/PartDocument.md).ModelingSettings

**Referenced types:** [Document](../objects/Document.md), [InteractiveContactAnalysisEnum](../enums/InteractiveContactAnalysisEnum.md), [InteractiveContactSurfacesEnum](../enums/InteractiveContactSurfacesEnum.md), [ModelDiameterFromThreadEnum](../enums/ModelDiameterFromThreadEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [UserCoordinateSystemSettings](../objects/UserCoordinateSystemSettings.md)

