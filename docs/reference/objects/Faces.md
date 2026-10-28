# Faces

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SurfaceBodies.Item[…].Faces`

```csharp
interface Faces
{
    // Properties
    int Count { get; }
    Face Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ASideDefinition](../objects/ASideDefinition.md).Faces, [AliasFreeformFeature](../objects/AliasFreeformFeature.md).Faces, [AliasFreeformFeatureProxy](../objects/AliasFreeformFeatureProxy.md).Faces, [Bend](../objects/Bend.md).BackFaces, [Bend](../objects/Bend.md).FrontFaces, [BendFeature](../objects/BendFeature.md).Faces, [BendFeatureProxy](../objects/BendFeatureProxy.md).Faces, [BendPartFeature](../objects/BendPartFeature.md).Faces, [BendPartFeatureProxy](../objects/BendPartFeatureProxy.md).Faces, [BossFeature](../objects/BossFeature.md).Faces, [BossFeatureProxy](../objects/BossFeatureProxy.md).Faces, [BoundaryPatchFeature](../objects/BoundaryPatchFeature.md).Faces, [BoundaryPatchFeatureProxy](../objects/BoundaryPatchFeatureProxy.md).Faces, [ChamferFeature](../objects/ChamferFeature.md).Faces, [ChamferFeatureProxy](../objects/ChamferFeatureProxy.md).Faces, [CircularPatternFeature](../objects/CircularPatternFeature.md).Faces, [CircularPatternFeatureProxy](../objects/CircularPatternFeatureProxy.md).Faces, [ClientFeature](../objects/ClientFeature.md).Faces, [ClientFeatureProxy](../objects/ClientFeatureProxy.md).Faces, [CoilFeature](../objects/CoilFeature.md).Faces, [CoilFeatureProxy](../objects/CoilFeatureProxy.md).Faces, [CombineFeature](../objects/CombineFeature.md).Faces, [CombineFeatureProxy](../objects/CombineFeatureProxy.md).Faces, [ContourFlangeFeature](../objects/ContourFlangeFeature.md).Faces, [ContourFlangeFeatureProxy](../objects/ContourFlangeFeatureProxy.md).Faces, [ContourRollFeature](../objects/ContourRollFeature.md).Faces, [ContourRollFeatureProxy](../objects/ContourRollFeatureProxy.md).Faces, [CornerChamferFeature](../objects/CornerChamferFeature.md).Faces, [CornerChamferFeatureProxy](../objects/CornerChamferFeatureProxy.md).Faces, [CornerFeature](../objects/CornerFeature.md).Faces, [CornerFeatureProxy](../objects/CornerFeatureProxy.md).Faces, [CornerRoundFeature](../objects/CornerRoundFeature.md).Faces, [CornerRoundFeatureProxy](../objects/CornerRoundFeatureProxy.md).Faces, [CosmeticBendFeature](../objects/CosmeticBendFeature.md).Faces, [CosmeticBendFeatureProxy](../objects/CosmeticBendFeatureProxy.md).Faces, [CutFeature](../objects/CutFeature.md).Faces, [CutFeatureProxy](../objects/CutFeatureProxy.md).Faces, [DecalFeature](../objects/DecalFeature.md).Faces, [DecalFeatureProxy](../objects/DecalFeatureProxy.md).Faces, [DeleteFaceFeature](../objects/DeleteFaceFeature.md).Faces and 152 more (see `members.tsv`)

**Referenced types:** [Face](../objects/Face.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

