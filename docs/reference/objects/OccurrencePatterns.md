# OccurrencePatterns

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.OccurrencePatterns`

```csharp
interface OccurrencePatterns
{
    // Properties
    object Application { get; }
    int Count { get; }
    OccurrencePattern Item[object Index] { get; }
    AssemblyComponentDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    CircularOccurrencePattern AddCircularPattern(ObjectCollection ParentComponents, object AxisEntity, bool AxisEntityNaturalDirection, object AngleOffset, object Count);
    FeatureBasedOccurrencePattern AddFeatureBasedPattern(ObjectCollection ParentComponents, PartFeature FeaturePattern);
    RectangularOccurrencePattern AddRectangularPattern(ObjectCollection ParentComponents, object ColumnEntity, bool ColumnEntityNaturalDirection, object ColumnOffset, object ColumnCount, object RowEntity = Missing, bool RowEntityNaturalDirection = true, object RowOffset = Missing, object RowCount = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).OccurrencePatterns, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).OccurrencePatterns

**Referenced types:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md), [CircularOccurrencePattern](../objects/CircularOccurrencePattern.md), [FeatureBasedOccurrencePattern](../objects/FeatureBasedOccurrencePattern.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [OccurrencePattern](../objects/OccurrencePattern.md), [PartFeature](../objects/PartFeature.md), [RectangularOccurrencePattern](../objects/RectangularOccurrencePattern.md)

