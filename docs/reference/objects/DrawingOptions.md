# DrawingOptions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.DrawingOptions`

```csharp
interface DrawingOptions
{
    // Properties
    object Application { get; }
    ArcDimensionTypeEnum ArcDimensionType { get; set; }
    bool CenterDimensionText { get; set; }
    CircleDimensionTypeEnum CircleDimensionType { get; set; }
    DefaultDrawingFileTypeEnum DefaultDrawingFileType { get; set; }
    DefaultLayerStyleEnum DefaultLayerStyle { get; set; }
    DefaultNonInventorDWGFileOpenBehaviorEnum DefaultNonInventorDWGFileOpenBehavior { get; set; }
    DefaultObjectStyleEnum DefaultObjectStyle { get; set; }
    bool DisplayLineWeights { get; set; }
    bool EditDimensionWhenCreated { get; set; }
    bool EnableBackgroundUpdates { get; set; }
    bool EnableOrdinateDimGeomSelection { get; set; }
    bool EnablePartModificationFromDrawing { get; set; }
    bool GetModelDimensions { get; set; }
    DWGFileVersionEnum InventorDWGFileVersion { get; set; }
    LineWeightTypeEnum LineWeightType { get; set; }
    LinearDimensionTypeEnum LinearDimensionType { get; set; }
    bool ShowUncutSectionViewPreview { get; set; }
    StandardPartsSectionBehaviorEnum StandardPartsSectionBehavior { get; set; }
    TitleBlockAlignmentEnum TitleBlockAlignment { get; set; }
    ObjectTypeEnum Type { get; }
    double UpperLimitForFirstRangeOfLineWeights { get; set; }
    double UpperLimitForSecondRangeOfLineWeights { get; set; }
    double UpperLimitForThirdRangeOfLineWeights { get; set; }
    ViewBlockInsertionPointEnum ViewBlockInsertionPoint { get; set; }
    ViewJustificationEnum ViewJustification { get; set; }
    ViewPreviewTypeEnum ViewPreview { get; set; }
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).DrawingOptions, [InventorServer](../objects/InventorServer.md).DrawingOptions

**Referenced types:** [ArcDimensionTypeEnum](../enums/ArcDimensionTypeEnum.md), [CircleDimensionTypeEnum](../enums/CircleDimensionTypeEnum.md), [DWGFileVersionEnum](../enums/DWGFileVersionEnum.md), [DefaultDrawingFileTypeEnum](../enums/DefaultDrawingFileTypeEnum.md), [DefaultLayerStyleEnum](../enums/DefaultLayerStyleEnum.md), [DefaultNonInventorDWGFileOpenBehaviorEnum](../enums/DefaultNonInventorDWGFileOpenBehaviorEnum.md), [DefaultObjectStyleEnum](../enums/DefaultObjectStyleEnum.md), [LineWeightTypeEnum](../enums/LineWeightTypeEnum.md), [LinearDimensionTypeEnum](../enums/LinearDimensionTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [StandardPartsSectionBehaviorEnum](../enums/StandardPartsSectionBehaviorEnum.md), [TitleBlockAlignmentEnum](../enums/TitleBlockAlignmentEnum.md), [ViewBlockInsertionPointEnum](../enums/ViewBlockInsertionPointEnum.md), [ViewJustificationEnum](../enums/ViewJustificationEnum.md), [ViewPreviewTypeEnum](../enums/ViewPreviewTypeEnum.md)

