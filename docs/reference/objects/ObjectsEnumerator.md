# ObjectsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.ReferencedOLEFileDescriptors2[…]`

```csharp
interface ObjectsEnumerator
{
    // Properties
    int Count { get; }
    object Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).AppearanceOverridesObjects, [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).FindUsingPoint, [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).FindUsingVector, [AssemblyDocument](../objects/AssemblyDocument.md).ReferencedOLEFileDescriptors2, [BreakOperation](../objects/BreakOperation.md).AllAffectedViews, [BreakOutOperation](../objects/BreakOutOperation.md).AllAffectedViews, [Centerline](../objects/Centerline.md).FitPoints, [Centermark](../objects/Centermark.md).Centerlines, [ComponentDefinition](../objects/ComponentDefinition.md).FindUsingPoint, [ComponentDefinition](../objects/ComponentDefinition.md).FindUsingVector, [DerivedAliasComponent](../objects/DerivedAliasComponent.md).ResultFeatures, [DerivedAliasComponentProxy](../objects/DerivedAliasComponentProxy.md).ResultFeatures, [DerivedPartComponent](../objects/DerivedPartComponent.md).WorkFeatures, [DerivedPartComponentProxy](../objects/DerivedPartComponentProxy.md).WorkFeatures, [DetailDrawingView](../objects/DetailDrawingView.md).SetAutomatedCenterlineSettings, [Document](../objects/Document.md).ReferencedOLEFileDescriptors2, [DrawingDocument](../objects/DrawingDocument.md).ReferencedOLEFileDescriptors2, [DrawingSketch](../objects/DrawingSketch.md).MoveSketchObjects, [DrawingSketch](../objects/DrawingSketch.md).RotateSketchObjects, [DrawingSketch](../objects/DrawingSketch.md).SetAutomatedCenterlineSettings, [DrawingView](../objects/DrawingView.md).SetAutomatedCenterlineSettings, [FeaturePatternElement](../objects/FeaturePatternElement.md).ResultFeatures, [FeaturePatternElementProxy](../objects/FeaturePatternElementProxy.md).ResultFeatures, [FlatPattern](../objects/FlatPattern.md).FindUsingPoint, [FlatPattern](../objects/FlatPattern.md).FindUsingVector, [HoleTapInfo](../objects/HoleTapInfo.md).ThreadBasePoints, [Line](../objects/Line.md).IntersectWithCurve, [Line](../objects/Line.md).IntersectWithSurface, [Line2d](../objects/Line2d.md).IntersectWithCurve, [LineSegment](../objects/LineSegment.md).IntersectWithCurve, [LineSegment](../objects/LineSegment.md).IntersectWithSurface, [LineSegment2d](../objects/LineSegment2d.md).IntersectWithCurve, [MirrorFeature](../objects/MirrorFeature.md).ResultFeatures, [MirrorFeatureProxy](../objects/MirrorFeatureProxy.md).ResultFeatures, [OccurrencePatternElement](../objects/OccurrencePatternElement.md).Components, [OccurrencePatternElementProxy](../objects/OccurrencePatternElementProxy.md).Components, [PartComponentDefinition](../objects/PartComponentDefinition.md).AppearanceOverridesObjects, [PartComponentDefinition](../objects/PartComponentDefinition.md).FindUsingPoint, [PartComponentDefinition](../objects/PartComponentDefinition.md).FindUsingVector, [PartDocument](../objects/PartDocument.md).ReferencedOLEFileDescriptors2 and 42 more (see `members.tsv`)

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

