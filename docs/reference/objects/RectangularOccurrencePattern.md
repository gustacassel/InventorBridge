# RectangularOccurrencePattern

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [OccurrencePattern](../objects/OccurrencePattern.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.OccurrencePatterns.Item[…] → (RectangularOccurrencePattern)`

```csharp
interface RectangularOccurrencePattern
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    Parameter ColumnCount { get; }
    object ColumnEntity { get; set; }
    bool ColumnEntityNaturalDirection { get; set; }
    Parameter ColumnOffset { get; }
    HealthStatusEnum HealthStatus { get; }
    bool IsPatternElement { get; }
    string Name { get; set; }
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

**Returned by:** [OccurrencePatterns](../objects/OccurrencePatterns.md).AddRectangularPattern, [RectangularOccurrencePatternProxy](../objects/RectangularOccurrencePatternProxy.md).NativeObject

**Referenced types:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md), [AttributeSets](../objects/AttributeSets.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [OccurrencePatternElement](../objects/OccurrencePatternElement.md), [OccurrencePatternElements](../objects/OccurrencePatternElements.md), [OccurrencePatternSuppressionEnum](../enums/OccurrencePatternSuppressionEnum.md), [Parameter](../objects/Parameter.md)

