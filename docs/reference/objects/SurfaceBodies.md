# SurfaceBodies

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SurfaceBodies`

```csharp
interface SurfaceBodies
{
    // Properties
    int Count { get; }
    SurfaceBody Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AliasFreeformFeature](../objects/AliasFreeformFeature.md).SurfaceBodies, [AliasFreeformFeatureProxy](../objects/AliasFreeformFeatureProxy.md).SurfaceBodies, [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).SurfaceBodies, [BendFeature](../objects/BendFeature.md).SurfaceBodies, [BendFeatureProxy](../objects/BendFeatureProxy.md).SurfaceBodies, [BendPartFeature](../objects/BendPartFeature.md).SurfaceBodies, [BendPartFeatureProxy](../objects/BendPartFeatureProxy.md).SurfaceBodies, [BossFeature](../objects/BossFeature.md).SurfaceBodies, [BossFeatureProxy](../objects/BossFeatureProxy.md).SurfaceBodies, [BoundaryPatchFeature](../objects/BoundaryPatchFeature.md).SurfaceBodies, [BoundaryPatchFeatureProxy](../objects/BoundaryPatchFeatureProxy.md).SurfaceBodies, [ChamferFeature](../objects/ChamferFeature.md).SurfaceBodies, [ChamferFeatureProxy](../objects/ChamferFeatureProxy.md).SurfaceBodies, [CircularPatternFeature](../objects/CircularPatternFeature.md).SurfaceBodies, [CircularPatternFeatureProxy](../objects/CircularPatternFeatureProxy.md).SurfaceBodies, [ClientFeature](../objects/ClientFeature.md).SurfaceBodies, [ClientFeatureProxy](../objects/ClientFeatureProxy.md).SurfaceBodies, [CoilFeature](../objects/CoilFeature.md).SurfaceBodies, [CoilFeatureProxy](../objects/CoilFeatureProxy.md).SurfaceBodies, [CombineFeature](../objects/CombineFeature.md).SurfaceBodies, [CombineFeature](../objects/CombineFeature.md).ToolBodies, [CombineFeatureProxy](../objects/CombineFeatureProxy.md).SurfaceBodies, [CombineFeatureProxy](../objects/CombineFeatureProxy.md).ToolBodies, [ComponentDefinition](../objects/ComponentDefinition.md).SurfaceBodies, [ComponentOccurrence](../objects/ComponentOccurrence.md).SurfaceBodies, [ComponentOccurrenceProxy](../objects/ComponentOccurrenceProxy.md).SurfaceBodies, [ContourFlangeFeature](../objects/ContourFlangeFeature.md).SurfaceBodies, [ContourFlangeFeatureProxy](../objects/ContourFlangeFeatureProxy.md).SurfaceBodies, [ContourRollFeature](../objects/ContourRollFeature.md).SurfaceBodies, [ContourRollFeatureProxy](../objects/ContourRollFeatureProxy.md).SurfaceBodies, [CornerChamferFeature](../objects/CornerChamferFeature.md).SurfaceBodies, [CornerChamferFeatureProxy](../objects/CornerChamferFeatureProxy.md).SurfaceBodies, [CornerFeature](../objects/CornerFeature.md).SurfaceBodies, [CornerFeatureProxy](../objects/CornerFeatureProxy.md).SurfaceBodies, [CornerRoundFeature](../objects/CornerRoundFeature.md).SurfaceBodies, [CornerRoundFeatureProxy](../objects/CornerRoundFeatureProxy.md).SurfaceBodies, [CosmeticBendFeature](../objects/CosmeticBendFeature.md).SurfaceBodies, [CosmeticBendFeatureProxy](../objects/CosmeticBendFeatureProxy.md).SurfaceBodies, [CutFeature](../objects/CutFeature.md).SurfaceBodies, [CutFeatureProxy](../objects/CutFeatureProxy.md).SurfaceBodies and 112 more (see `members.tsv`)

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SurfaceBody](../objects/SurfaceBody.md)

