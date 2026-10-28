# PartOptions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.PartOptions`

```csharp
interface PartOptions
{
    // Properties
    object Application { get; }
    bool AutoConsumeWorkAndSurfaceFeatures { get; set; }
    bool AutoHideInLineWorkFeatures { get; set; }
    DesignViewTypeEnum DefaultDesignView { get; set; }
    bool DefaultDesignViewIsAssociative { get; set; }
    DimensionConstraintsRelaxationEnum DimensionConstraintsRelaxation { get; set; }
    bool DisplayExtendedName { get; set; }
    bool DisplayGripsOnSelection { get; set; }
    bool EditBaseSolidsUsingFusion { get; set; }
    bool Enable3DGrips { get; set; }
    bool EnableConstructionEnvironment { get; set; }
    GeometricConstraintsBreakageEnum GeometricConstraintsBreakage { get; set; }
    bool LinkFaceColorFromSource { get; set; }
    bool LinkSketchFormattingFromSource { get; set; }
    bool OpaqueConstructionSurfaces { get; set; }
    SketchCreationOnNewPartEnum SketchCreationOnNewPart { get; set; }
    ObjectTypeEnum Type { get; }
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).PartOptions, [InventorServer](../objects/InventorServer.md).PartOptions

**Referenced types:** [DesignViewTypeEnum](../enums/DesignViewTypeEnum.md), [DimensionConstraintsRelaxationEnum](../enums/DimensionConstraintsRelaxationEnum.md), [GeometricConstraintsBreakageEnum](../enums/GeometricConstraintsBreakageEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchCreationOnNewPartEnum](../enums/SketchCreationOnNewPartEnum.md)

