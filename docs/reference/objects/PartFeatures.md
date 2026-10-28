# PartFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features`

```csharp
interface PartFeatures
{
    // Properties
    AliasFreeformFeatures AliasFreeformFeatures { get; }
    object Application { get; }
    BendPartFeatures BendPartFeatures { get; }
    BossFeatures BossFeatures { get; }
    BoundaryPatchFeatures BoundaryPatchFeatures { get; }
    ChamferFeatures ChamferFeatures { get; }
    CircularPatternFeatures CircularPatternFeatures { get; }
    ClientFeatures ClientFeatures { get; }
    CoilFeatures CoilFeatures { get; }
    CombineFeatures CombineFeatures { get; }
    int Count { get; }
    DecalFeatures DecalFeatures { get; }
    DeleteFaceFeatures DeleteFaceFeatures { get; }
    DirectEditFeatures DirectEditFeatures { get; }
    EmbossFeatures EmbossFeatures { get; }
    ExtendFeatures ExtendFeatures { get; }
    ExtrudeFeatures ExtrudeFeatures { get; }
    FaceDraftFeatures FaceDraftFeatures { get; }
    FilletFeatures FilletFeatures { get; }
    FinishFeatures FinishFeatures { get; }
    FreeformFeatures FreeformFeatures { get; }
    GrillFeatures GrillFeatures { get; }
    HoleFeatures HoleFeatures { get; }
    PartFeature Item[object Index] { get; }
    KnitFeatures KnitFeatures { get; }
    LipFeatures LipFeatures { get; }
    LoftFeatures LoftFeatures { get; }
    MarkFeatures MarkFeatures { get; }
    MirrorFeatures MirrorFeatures { get; }
    MoveFaceFeatures MoveFaceFeatures { get; }
    MoveFeatures MoveFeatures { get; }
    NonParametricBaseFeatures NonParametricBaseFeatures { get; }
    RectangularPatternFeatures RectangularPatternFeatures { get; }
    ReferenceFeatures ReferenceFeatures { get; }
    ReplaceFaceFeatures ReplaceFaceFeatures { get; }
    RestFeatures RestFeatures { get; }
    RevolveFeatures RevolveFeatures { get; }
    RibFeatures RibFeatures { get; }
    RuleFilletFeatures RuleFilletFeatures { get; }
    RuledSurfaceFeatures RuledSurfaceFeatures { get; }
    SculptFeatures SculptFeatures { get; }
    ShellFeatures ShellFeatures { get; }
    SimplifyFeatures SimplifyFeatures { get; } // since 2026
    SketchDrivenPatternFeatures SketchDrivenPatternFeatures { get; }
    SlotFeatures SlotFeatures { get; } // since 2027
    SnapFitFeatures SnapFitFeatures { get; }
    SplitFeatures SplitFeatures { get; }
    SweepFeatures SweepFeatures { get; }
    ThickenFeatures ThickenFeatures { get; }
    ThreadFeatures ThreadFeatures { get; }
    TrimFeatures TrimFeatures { get; }
    ObjectTypeEnum Type { get; }
    UnwrapFeatures UnwrapFeatures { get; }
    iFeatures iFeatures { get; }
    // Methods
    Path CreatePath(object SketchCurve);
    Path CreateSpecifiedPath(ObjectCollection SketchCurves);
}
```

5 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartComponentDefinition](../objects/PartComponentDefinition.md).Features, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).Features

**Referenced types:** [AliasFreeformFeatures](../objects/AliasFreeformFeatures.md), [BendPartFeatures](../objects/BendPartFeatures.md), [BossFeatures](../objects/BossFeatures.md), [BoundaryPatchFeatures](../objects/BoundaryPatchFeatures.md), [ChamferFeatures](../objects/ChamferFeatures.md), [CircularPatternFeatures](../objects/CircularPatternFeatures.md), [ClientFeatures](../objects/ClientFeatures.md), [CoilFeatures](../objects/CoilFeatures.md), [CombineFeatures](../objects/CombineFeatures.md), [DecalFeatures](../objects/DecalFeatures.md), [DeleteFaceFeatures](../objects/DeleteFaceFeatures.md), [DirectEditFeatures](../objects/DirectEditFeatures.md), [EmbossFeatures](../objects/EmbossFeatures.md), [ExtendFeatures](../objects/ExtendFeatures.md), [ExtrudeFeatures](../objects/ExtrudeFeatures.md), [FaceDraftFeatures](../objects/FaceDraftFeatures.md), [FilletFeatures](../objects/FilletFeatures.md), [FinishFeatures](../objects/FinishFeatures.md), [FreeformFeatures](../objects/FreeformFeatures.md), [GrillFeatures](../objects/GrillFeatures.md), [HoleFeatures](../objects/HoleFeatures.md), [KnitFeatures](../objects/KnitFeatures.md), [LipFeatures](../objects/LipFeatures.md), [LoftFeatures](../objects/LoftFeatures.md), [MarkFeatures](../objects/MarkFeatures.md), [MirrorFeatures](../objects/MirrorFeatures.md), [MoveFaceFeatures](../objects/MoveFaceFeatures.md), [MoveFeatures](../objects/MoveFeatures.md), [NonParametricBaseFeatures](../objects/NonParametricBaseFeatures.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeature](../objects/PartFeature.md), [Path](../objects/Path.md), [RectangularPatternFeatures](../objects/RectangularPatternFeatures.md), [ReferenceFeatures](../objects/ReferenceFeatures.md), [ReplaceFaceFeatures](../objects/ReplaceFaceFeatures.md), [RestFeatures](../objects/RestFeatures.md), [RevolveFeatures](../objects/RevolveFeatures.md), [RibFeatures](../objects/RibFeatures.md), [RuleFilletFeatures](../objects/RuleFilletFeatures.md), [RuledSurfaceFeatures](../objects/RuledSurfaceFeatures.md), [SculptFeatures](../objects/SculptFeatures.md), [ShellFeatures](../objects/ShellFeatures.md), [SimplifyFeatures](../objects/SimplifyFeatures.md), [SketchDrivenPatternFeatures](../objects/SketchDrivenPatternFeatures.md), [SlotFeatures](../objects/SlotFeatures.md), [SnapFitFeatures](../objects/SnapFitFeatures.md), [SplitFeatures](../objects/SplitFeatures.md), [SweepFeatures](../objects/SweepFeatures.md), [ThickenFeatures](../objects/ThickenFeatures.md), [ThreadFeatures](../objects/ThreadFeatures.md), [TrimFeatures](../objects/TrimFeatures.md), [UnwrapFeatures](../objects/UnwrapFeatures.md), [iFeatures](../objects/iFeatures.md)

