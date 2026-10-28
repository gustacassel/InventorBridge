# Features

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.Features`

```csharp
interface Features
{
    // Properties
    object Application { get; }
    ChamferFeatures ChamferFeatures { get; }
    CircularPatternFeatures CircularPatternFeatures { get; }
    ClientFeatures ClientFeatures { get; }
    int Count { get; }
    ExtrudeFeatures ExtrudeFeatures { get; }
    FilletFeatures FilletFeatures { get; }
    FinishFeatures FinishFeatures { get; }
    HoleFeatures HoleFeatures { get; }
    PartFeature Item[object Index] { get; }
    MirrorFeatures MirrorFeatures { get; }
    MoveFaceFeatures MoveFaceFeatures { get; }
    RectangularPatternFeatures RectangularPatternFeatures { get; }
    RevolveFeatures RevolveFeatures { get; }
    SketchDrivenPatternFeatures SketchDrivenPatternFeatures { get; }
    SlotFeatures SlotFeatures { get; } // since 2027
    SweepFeatures SweepFeatures { get; }
    ThreadFeatures ThreadFeatures { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    Path CreatePath(object SketchCurve);
    Path CreateSpecifiedPath(ObjectCollection SketchCurves);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).Features, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).Features

**Referenced types:** [ChamferFeatures](../objects/ChamferFeatures.md), [CircularPatternFeatures](../objects/CircularPatternFeatures.md), [ClientFeatures](../objects/ClientFeatures.md), [ExtrudeFeatures](../objects/ExtrudeFeatures.md), [FilletFeatures](../objects/FilletFeatures.md), [FinishFeatures](../objects/FinishFeatures.md), [HoleFeatures](../objects/HoleFeatures.md), [MirrorFeatures](../objects/MirrorFeatures.md), [MoveFaceFeatures](../objects/MoveFaceFeatures.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeature](../objects/PartFeature.md), [Path](../objects/Path.md), [RectangularPatternFeatures](../objects/RectangularPatternFeatures.md), [RevolveFeatures](../objects/RevolveFeatures.md), [SketchDrivenPatternFeatures](../objects/SketchDrivenPatternFeatures.md), [SlotFeatures](../objects/SlotFeatures.md), [SweepFeatures](../objects/SweepFeatures.md), [ThreadFeatures](../objects/ThreadFeatures.md)

