# ModelFeatureControlFrameDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelFeatureControlFrames.Item[…].Definition`

```csharp
interface ModelFeatureControlFrameDefinition
{
    // Properties
    AnnotationPlane AnnotationPlane { get; set; }
    AnnotationPlaneDefinition AnnotationPlaneDefinition { get; set; }
    object Application { get; }
    ArrowheadTypeEnum ArrowheadType { get; set; }
    ModelFeatureControlFrameRows FeatureControlFrameRows { get; }
    GeometryIntent Intent { get; set; }
    Point LandingPosition { get; set; }
    ModelLeader Leader { get; }
    bool MergeSymbolOverridden { get; set; }
    string Notes { get; set; }
    bool OverrideMergeSymbol { get; set; }
    ModelFeatureControlFrame Parent { get; }
    FeatureControlFrameProfileTypeEnum ProfileType { get; set; }
    double Rotation { get; }
    Point TextPosition { get; set; }
    string TopNotes { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    ModelFeatureControlFrameDefinition Copy();
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelFeatureControlFrame](../objects/ModelFeatureControlFrame.md).Definition, [ModelFeatureControlFrameDefinition](../objects/ModelFeatureControlFrameDefinition.md).Copy, [ModelFeatureControlFrameProxy](../objects/ModelFeatureControlFrameProxy.md).Definition, [ModelFeatureControlFrameRow](../objects/ModelFeatureControlFrameRow.md).Parent, [ModelFeatureControlFrames](../objects/ModelFeatureControlFrames.md).CreateDefinition, [ModelGeneralNotes](../objects/ModelGeneralNotes.md).CreateEmbeddedFeatureControlFrameDefinition

**Referenced types:** [AnnotationPlane](../objects/AnnotationPlane.md), [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md), [ArrowheadTypeEnum](../enums/ArrowheadTypeEnum.md), [FeatureControlFrameProfileTypeEnum](../enums/FeatureControlFrameProfileTypeEnum.md), [GeometryIntent](../objects/GeometryIntent.md), [ModelFeatureControlFrame](../objects/ModelFeatureControlFrame.md), [ModelFeatureControlFrameRows](../objects/ModelFeatureControlFrameRows.md), [ModelLeader](../objects/ModelLeader.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

