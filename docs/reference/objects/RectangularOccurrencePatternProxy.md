# RectangularOccurrencePatternProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [RectangularOccurrencePattern](../objects/RectangularOccurrencePattern.md) → [OccurrencePattern](../objects/OccurrencePattern.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.OccurrencePatterns.Item[…] → (RectangularOccurrencePattern) → (RectangularOccurrencePatternProxy)`

```csharp
interface RectangularOccurrencePatternProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    Parameter ColumnCount { get; }
    object ColumnEntity { get; set; }
    bool ColumnEntityNaturalDirection { get; set; }
    Parameter ColumnOffset { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    HealthStatusEnum HealthStatus { get; }
    bool IsPatternElement { get; }
    string Name { get; set; }
    RectangularOccurrencePattern NativeObject { get; }
    OccurrencePatternElement OccurrencePatternElement[int Row, int Column] { get; }
    OccurrencePatternElements OccurrencePatternElements { get; }
    AssemblyComponentDefinition Parent { get; }
    ObjectCollection ParentComponents { get; set; }
    OccurrencePatternElement PatternElement { get; }
    Parameter RowCount { get; }
    object RowEntity { get; set; }
    bool RowEntityNaturalDirection { get; set; }
    Parameter RowOffset { get; }
    OccurrencePatternSuppressionEnum Suppressed { get; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void Suppress(bool SkipDocumentSave = false);
    void Unsuppress();
}
```

**Referenced types:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md), [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [OccurrencePatternElement](../objects/OccurrencePatternElement.md), [OccurrencePatternElements](../objects/OccurrencePatternElements.md), [OccurrencePatternSuppressionEnum](../enums/OccurrencePatternSuppressionEnum.md), [Parameter](../objects/Parameter.md), [RectangularOccurrencePattern](../objects/RectangularOccurrencePattern.md)

