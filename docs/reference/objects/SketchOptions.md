# SketchOptions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.SketchOptions`

```csharp
interface SketchOptions
{
    // Properties
    object Application { get; }
    bool AutoBendWithLineCreation { get; set; } // since 2026
    bool AutoProjectEdges { get; set; }
    bool AutoProjectPartOrigin { get; set; }
    bool AutoScaleSketchGeometriesOnInitialDimension { get; set; }
    bool AutomaticReferenceEdges { get; set; }
    double ConstraintToolbarScale { get; set; }
    bool DisplayAxes { get; set; }
    bool DisplayCoordinateSystemIndicator { get; set; }
    bool DisplayGridLines { get; set; }
    bool DisplayMinorGridLines { get; set; }
    HeadsUpDisplayOptions HeadsUpDisplayOptions { get; }
    bool ImageInsertionLINKOptionCheckedAsDefault { get; set; }
    bool ParallelViewOnSketchCreationInAssembly { get; set; }
    bool ParallelViewOnSketchCreationInPart { get; set; }
    bool PointAlignment { get; set; }
    bool ProjectObjectsAsConstructionGeometry { get; set; }
    SketchConstraintSettings SketchConstraintSettings { get; }
    int SketchOpacity { get; set; } // since 2026
    bool SnapToGrid { get; set; }
    int SplineDefaultTension { get; set; }
    SplineFitMethodEnum SplineFitMethod { get; set; }
    ObjectTypeEnum Type { get; }
}
```

6 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).SketchOptions, [HeadsUpDisplayOptions](../objects/HeadsUpDisplayOptions.md).Parent, [InventorServer](../objects/InventorServer.md).SketchOptions, [SketchConstraintSettings](../objects/SketchConstraintSettings.md).Parent

**Referenced types:** [HeadsUpDisplayOptions](../objects/HeadsUpDisplayOptions.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchConstraintSettings](../objects/SketchConstraintSettings.md), [SplineFitMethodEnum](../enums/SplineFitMethodEnum.md)

