# Box

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateBox(…)`

```csharp
interface Box
{
    // Properties
    Point MaxPoint { get; set; }
    Point MinPoint { get; set; }
    // Methods
    bool Contains(Point Point);
    Box Copy();
    void Expand(double Distance);
    void Extend(Point Point);
    void GetBoxData(out double[] MinPoint, out double[] MaxPoint);
    bool IsDisjoint(Box Box);
    void PutBoxData(out double[] MinPoint, out double[] MaxPoint);
}
```

**Returned by:** [AliasFreeformFeature](../objects/AliasFreeformFeature.md).RangeBox, [AliasFreeformFeatureProxy](../objects/AliasFreeformFeatureProxy.md).RangeBox, [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).PreciseRangeBox, [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).RangeBox, [BendFeature](../objects/BendFeature.md).RangeBox, [BendFeatureProxy](../objects/BendFeatureProxy.md).RangeBox, [BendPartFeature](../objects/BendPartFeature.md).RangeBox, [BendPartFeatureProxy](../objects/BendPartFeatureProxy.md).RangeBox, [BossFeature](../objects/BossFeature.md).RangeBox, [BossFeatureProxy](../objects/BossFeatureProxy.md).RangeBox, [BoundaryPatchFeature](../objects/BoundaryPatchFeature.md).RangeBox, [BoundaryPatchFeatureProxy](../objects/BoundaryPatchFeatureProxy.md).RangeBox, [Box](../objects/Box.md).Copy, [ChamferFeature](../objects/ChamferFeature.md).RangeBox, [ChamferFeatureProxy](../objects/ChamferFeatureProxy.md).RangeBox, [CircularPatternFeature](../objects/CircularPatternFeature.md).RangeBox, [CircularPatternFeatureProxy](../objects/CircularPatternFeatureProxy.md).RangeBox, [ClientFeature](../objects/ClientFeature.md).RangeBox, [ClientFeatureProxy](../objects/ClientFeatureProxy.md).RangeBox, [ClientGraphics](../objects/ClientGraphics.md).RangeBox, [CoilFeature](../objects/CoilFeature.md).RangeBox, [CoilFeatureProxy](../objects/CoilFeatureProxy.md).RangeBox, [CombineFeature](../objects/CombineFeature.md).RangeBox, [CombineFeatureProxy](../objects/CombineFeatureProxy.md).RangeBox, [ComponentDefinition](../objects/ComponentDefinition.md).PreciseRangeBox, [ComponentDefinition](../objects/ComponentDefinition.md).RangeBox, [ComponentGraphics](../objects/ComponentGraphics.md).RangeBox, [ComponentOccurrence](../objects/ComponentOccurrence.md).PreciseRangeBox, [ComponentOccurrence](../objects/ComponentOccurrence.md).RangeBox, [ComponentOccurrenceProxy](../objects/ComponentOccurrenceProxy.md).PreciseRangeBox, [ComponentOccurrenceProxy](../objects/ComponentOccurrenceProxy.md).RangeBox, [ContourFlangeFeature](../objects/ContourFlangeFeature.md).RangeBox, [ContourFlangeFeatureProxy](../objects/ContourFlangeFeatureProxy.md).RangeBox, [ContourRollFeature](../objects/ContourRollFeature.md).RangeBox, [ContourRollFeatureProxy](../objects/ContourRollFeatureProxy.md).RangeBox, [CornerChamferFeature](../objects/CornerChamferFeature.md).RangeBox, [CornerChamferFeatureProxy](../objects/CornerChamferFeatureProxy.md).RangeBox, [CornerFeature](../objects/CornerFeature.md).RangeBox, [CornerFeatureProxy](../objects/CornerFeatureProxy.md).RangeBox, [CornerRoundFeature](../objects/CornerRoundFeature.md).RangeBox and 179 more (see `members.tsv`)

**Referenced types:** [Point](../objects/Point.md)

