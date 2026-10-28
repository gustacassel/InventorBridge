# AssemblyOptions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.AssemblyOptions`

```csharp
interface AssemblyOptions
{
    // Properties
    object Application { get; }
    int AssemblyExpressMinimumUniqueDocument { get; set; }
    bool ConstraintAudioNotification { get; set; }
    bool DeferUpdate { get; set; }
    bool DeleteComponentPatternSources { get; set; }
    bool DisplayComponentNamesInConstraints { get; set; }
    bool EnableAssemblyExpress { get; set; }
    bool EnableConstraintRedundancyAnalysis { get; set; }
    bool EnableCrossPartEdgeLoopProjection { get; set; }
    bool EnableCrossPartSketchGeometryProjection { get; set; }
    bool FromToExtentsAdaptFeature { get; set; }
    bool FromToExtentsMatePlane { get; set; }
    bool OnlyActiveComponentIsOpaque { get; set; }
    bool PartFeaturesInitiallyAdaptive { get; set; }
    bool PlaceAndGroundFirstComponentAtOrigin { get; set; }
    bool SectionAllParts { get; set; }
    ObjectTypeEnum Type { get; }
    bool UseLastOccurrenceOrientationForPlacement { get; set; }
    ZoomTargetComponentWithiMateEnum ZoomTargetComponentWithiMate { get; set; }
}
```

8 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).AssemblyOptions, [InventorServer](../objects/InventorServer.md).AssemblyOptions

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ZoomTargetComponentWithiMateEnum](../enums/ZoomTargetComponentWithiMateEnum.md)

