# FaceDraftDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.FaceDraftFeatures.Item[…].Definition`

```csharp
interface FaceDraftDefinition
{
    // Properties
    bool AbsoluteDraftAngle { get; set; }
    object Application { get; }
    bool AutomaticBlending { get; set; }
    bool CutMaterial { get; set; }
    FaceDraftDefinitionTypeEnum DefinitionType { get; }
    object DraftAngle { get; set; }
    DraftAngleConstraintTypeEnum DraftAngleConstraintType { get; set; }
    object DraftAngleTwo { get; set; }
    EdgeCollection FixedEdges { get; set; }
    FaceCollection InputFaces { get; set; }
    FaceDraftFeature Parent { get; }
    object PullDirection { get; }
    bool PullDirectionReversed { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    FaceDraftDefinition Copy();
    void SetFixedEdge(FaceCollection InputFaces, EdgeCollection FixedEdges, object PullDirection, object DraftAngle, bool PullDirectionReversed = false, bool AbsoluteDraftAngle = true);
    void SetFixedPlane(FaceCollection InputFaces, object FixedPlane, object DraftAngle, DraftAngleConstraintTypeEnum DraftAngleConstraintType = DraftAngleConstraintTypeEnum.kOneWayDraftAngle, object DraftAngleTwo = Missing, bool AbsoluteDraftAngle = true);
    void SetPartingTool(FaceCollection InputFaces, object PartingTool, object PullDirection, object DraftAngle, bool CutMaterial = true, object FixedEdges = Missing, DraftAngleConstraintTypeEnum DraftAngleConstraintType = DraftAngleConstraintTypeEnum.kSymmetricDraftAngles, object DraftAngleTwo = Missing, bool PullDirectionReversed = false, bool AbsoluteDraftAngle = true);
}
```

**Returned by:** [FaceDraftDefinition](../objects/FaceDraftDefinition.md).Copy, [FaceDraftFeature](../objects/FaceDraftFeature.md).Definition, [FaceDraftFeatureProxy](../objects/FaceDraftFeatureProxy.md).Definition, [FaceDraftFeatures](../objects/FaceDraftFeatures.md).CreateFaceDraftDefinition

**Referenced types:** [DraftAngleConstraintTypeEnum](../enums/DraftAngleConstraintTypeEnum.md), [EdgeCollection](../objects/EdgeCollection.md), [FaceCollection](../objects/FaceCollection.md), [FaceDraftDefinitionTypeEnum](../enums/FaceDraftDefinitionTypeEnum.md), [FaceDraftFeature](../objects/FaceDraftFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

