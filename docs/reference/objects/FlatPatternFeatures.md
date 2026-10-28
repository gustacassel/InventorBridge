# FlatPatternFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition → (SheetMetalComponentDefinition).FlatPattern.Features`

```csharp
interface FlatPatternFeatures
{
    // Properties
    object Application { get; }
    ChamferFeatures ChamferFeatures { get; }
    CircularPatternFeatures CircularPatternFeatures { get; }
    ClientFeatures ClientFeatures { get; }
    CornerChamferFeatures CornerChamferFeatures { get; }
    CornerRoundFeatures CornerRoundFeatures { get; }
    CosmeticBendFeatures CosmeticBendFeatures { get; }
    int Count { get; }
    CutFeatures CutFeatures { get; }
    EmbossFeatures EmbossFeatures { get; }
    ExtrudeFeatures ExtrudeFeatures { get; }
    FilletFeatures FilletFeatures { get; }
    HoleFeatures HoleFeatures { get; }
    PartFeature Item[object Index] { get; }
    MarkFeatures MarkFeatures { get; }
    MirrorFeatures MirrorFeatures { get; }
    PunchToolFeatures PunchToolFeatures { get; }
    RectangularPatternFeatures RectangularPatternFeatures { get; }
    RevolveFeatures RevolveFeatures { get; }
    SketchDrivenPatternFeatures SketchDrivenPatternFeatures { get; }
    SlotFeatures SlotFeatures { get; } // since 2027
    SweepFeatures SweepFeatures { get; }
    ObjectTypeEnum Type { get; }
    iFeatures iFeatures { get; }
    // Methods
    Path CreatePath(object SketchCurve);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FlatPattern](../objects/FlatPattern.md).Features

**Referenced types:** [ChamferFeatures](../objects/ChamferFeatures.md), [CircularPatternFeatures](../objects/CircularPatternFeatures.md), [ClientFeatures](../objects/ClientFeatures.md), [CornerChamferFeatures](../objects/CornerChamferFeatures.md), [CornerRoundFeatures](../objects/CornerRoundFeatures.md), [CosmeticBendFeatures](../objects/CosmeticBendFeatures.md), [CutFeatures](../objects/CutFeatures.md), [EmbossFeatures](../objects/EmbossFeatures.md), [ExtrudeFeatures](../objects/ExtrudeFeatures.md), [FilletFeatures](../objects/FilletFeatures.md), [HoleFeatures](../objects/HoleFeatures.md), [MarkFeatures](../objects/MarkFeatures.md), [MirrorFeatures](../objects/MirrorFeatures.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeature](../objects/PartFeature.md), [Path](../objects/Path.md), [PunchToolFeatures](../objects/PunchToolFeatures.md), [RectangularPatternFeatures](../objects/RectangularPatternFeatures.md), [RevolveFeatures](../objects/RevolveFeatures.md), [SketchDrivenPatternFeatures](../objects/SketchDrivenPatternFeatures.md), [SlotFeatures](../objects/SlotFeatures.md), [SweepFeatures](../objects/SweepFeatures.md), [iFeatures](../objects/iFeatures.md)

