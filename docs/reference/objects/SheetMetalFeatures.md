# SheetMetalFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [PartFeatures](../objects/PartFeatures.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features → (SheetMetalFeatures)`

```csharp
interface SheetMetalFeatures
{
    // Properties
    AliasFreeformFeatures AliasFreeformFeatures { get; }
    object Application { get; }
    BendFeatures BendFeatures { get; }
    BendPartFeatures BendPartFeatures { get; }
    BossFeatures BossFeatures { get; }
    BoundaryPatchFeatures BoundaryPatchFeatures { get; }
    ChamferFeatures ChamferFeatures { get; }
    CircularPatternFeatures CircularPatternFeatures { get; }
    ClientFeatures ClientFeatures { get; }
    CoilFeatures CoilFeatures { get; }
    CombineFeatures CombineFeatures { get; }
    ContourFlangeFeatures ContourFlangeFeatures { get; }
    ContourRollFeatures ContourRollFeatures { get; }
    CornerChamferFeatures CornerChamferFeatures { get; }
    CornerFeatures CornerFeatures { get; }
    CornerRoundFeatures CornerRoundFeatures { get; }
    int Count { get; }
    CutFeatures CutFeatures { get; }
    DecalFeatures DecalFeatures { get; }
    DeleteFaceFeatures DeleteFaceFeatures { get; }
    DirectEditFeatures DirectEditFeatures { get; }
    EmbossFeatures EmbossFeatures { get; }
    ExtendFeatures ExtendFeatures { get; }
    ExtrudeFeatures ExtrudeFeatures { get; }
    FaceDraftFeatures FaceDraftFeatures { get; }
    FaceFeatures FaceFeatures { get; }
    FilletFeatures FilletFeatures { get; }
    FinishFeatures FinishFeatures { get; }
    FlangeFeatures FlangeFeatures { get; }
    FoldFeatures FoldFeatures { get; }
    FreeformFeatures FreeformFeatures { get; }
    GrillFeatures GrillFeatures { get; }
    HemFeatures HemFeatures { get; }
    HoleFeatures HoleFeatures { get; }
    PartFeature Item[object Index] { get; }
    KnitFeatures KnitFeatures { get; }
    LipFeatures LipFeatures { get; }
    LoftFeatures LoftFeatures { get; }
    LoftedFlangeFeatures LoftedFlangeFeatures { get; }
    MarkFeatures MarkFeatures { get; }
    MirrorFeatures MirrorFeatures { get; }
    MoveFaceFeatures MoveFaceFeatures { get; }
    MoveFeatures MoveFeatures { get; }
    NonParametricBaseFeatures NonParametricBaseFeatures { get; }
    PunchToolFeatures PunchToolFeatures { get; }
    RectangularPatternFeatures RectangularPatternFeatures { get; }
    ReferenceFeatures ReferenceFeatures { get; }
    RefoldFeatures RefoldFeatures { get; }
    ReplaceFaceFeatures ReplaceFaceFeatures { get; }
    RestFeatures RestFeatures { get; }
    RevolveFeatures RevolveFeatures { get; }
    RibFeatures RibFeatures { get; }
    RipFeatures RipFeatures { get; }
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
    UnfoldFeatures UnfoldFeatures { get; }
    UnwrapFeatures UnwrapFeatures { get; }
    iFeatures iFeatures { get; }
    // Methods
    Path CreatePath(object SketchCurve);
    Path CreateSpecifiedPath(ObjectCollection SketchCurves);
}
```

5 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AliasFreeformFeatures](../objects/AliasFreeformFeatures.md), [BendFeatures](../objects/BendFeatures.md), [BendPartFeatures](../objects/BendPartFeatures.md), [BossFeatures](../objects/BossFeatures.md), [BoundaryPatchFeatures](../objects/BoundaryPatchFeatures.md), [ChamferFeatures](../objects/ChamferFeatures.md), [CircularPatternFeatures](../objects/CircularPatternFeatures.md), [ClientFeatures](../objects/ClientFeatures.md), [CoilFeatures](../objects/CoilFeatures.md), [CombineFeatures](../objects/CombineFeatures.md), [ContourFlangeFeatures](../objects/ContourFlangeFeatures.md), [ContourRollFeatures](../objects/ContourRollFeatures.md), [CornerChamferFeatures](../objects/CornerChamferFeatures.md), [CornerFeatures](../objects/CornerFeatures.md), [CornerRoundFeatures](../objects/CornerRoundFeatures.md), [CutFeatures](../objects/CutFeatures.md), [DecalFeatures](../objects/DecalFeatures.md), [DeleteFaceFeatures](../objects/DeleteFaceFeatures.md), [DirectEditFeatures](../objects/DirectEditFeatures.md), [EmbossFeatures](../objects/EmbossFeatures.md), [ExtendFeatures](../objects/ExtendFeatures.md), [ExtrudeFeatures](../objects/ExtrudeFeatures.md), [FaceDraftFeatures](../objects/FaceDraftFeatures.md), [FaceFeatures](../objects/FaceFeatures.md), [FilletFeatures](../objects/FilletFeatures.md), [FinishFeatures](../objects/FinishFeatures.md), [FlangeFeatures](../objects/FlangeFeatures.md), [FoldFeatures](../objects/FoldFeatures.md), [FreeformFeatures](../objects/FreeformFeatures.md), [GrillFeatures](../objects/GrillFeatures.md), [HemFeatures](../objects/HemFeatures.md), [HoleFeatures](../objects/HoleFeatures.md), [KnitFeatures](../objects/KnitFeatures.md), [LipFeatures](../objects/LipFeatures.md), [LoftFeatures](../objects/LoftFeatures.md), [LoftedFlangeFeatures](../objects/LoftedFlangeFeatures.md), [MarkFeatures](../objects/MarkFeatures.md), [MirrorFeatures](../objects/MirrorFeatures.md), [MoveFaceFeatures](../objects/MoveFaceFeatures.md), [MoveFeatures](../objects/MoveFeatures.md), [NonParametricBaseFeatures](../objects/NonParametricBaseFeatures.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeature](../objects/PartFeature.md), [Path](../objects/Path.md), [PunchToolFeatures](../objects/PunchToolFeatures.md), [RectangularPatternFeatures](../objects/RectangularPatternFeatures.md), [ReferenceFeatures](../objects/ReferenceFeatures.md), [RefoldFeatures](../objects/RefoldFeatures.md), [ReplaceFaceFeatures](../objects/ReplaceFaceFeatures.md), [RestFeatures](../objects/RestFeatures.md), [RevolveFeatures](../objects/RevolveFeatures.md), [RibFeatures](../objects/RibFeatures.md), [RipFeatures](../objects/RipFeatures.md), [RuleFilletFeatures](../objects/RuleFilletFeatures.md), [RuledSurfaceFeatures](../objects/RuledSurfaceFeatures.md), [SculptFeatures](../objects/SculptFeatures.md), [ShellFeatures](../objects/ShellFeatures.md), [SimplifyFeatures](../objects/SimplifyFeatures.md), [SketchDrivenPatternFeatures](../objects/SketchDrivenPatternFeatures.md), [SlotFeatures](../objects/SlotFeatures.md), [SnapFitFeatures](../objects/SnapFitFeatures.md), [SplitFeatures](../objects/SplitFeatures.md), [SweepFeatures](../objects/SweepFeatures.md), [ThickenFeatures](../objects/ThickenFeatures.md), [ThreadFeatures](../objects/ThreadFeatures.md), [TrimFeatures](../objects/TrimFeatures.md), [UnfoldFeatures](../objects/UnfoldFeatures.md), [UnwrapFeatures](../objects/UnwrapFeatures.md), [iFeatures](../objects/iFeatures.md)

