# CircularOccurrencePatternProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [CircularOccurrencePattern](../objects/CircularOccurrencePattern.md) → [OccurrencePattern](../objects/OccurrencePattern.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.OccurrencePatterns.Item[…] → (CircularOccurrencePattern) → (CircularOccurrencePatternProxy)`

```csharp
interface CircularOccurrencePatternProxy
{
    // Properties
    Parameter AngleOffset { get; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    object AxisEntity { get; set; }
    bool AxisEntityNaturalDirection { get; set; }
    ComponentOccurrence ContainingOccurrence { get; }
    Parameter ElementCount { get; }
    HealthStatusEnum HealthStatus { get; }
    bool IsPatternElement { get; }
    bool LockRotation { get; set; }
    string Name { get; set; }
    CircularOccurrencePattern NativeObject { get; }
    OccurrencePatternElements OccurrencePatternElements { get; }
    AssemblyComponentDefinition Parent { get; }
    ObjectCollection ParentComponents { get; set; }
    OccurrencePatternElement PatternElement { get; }
    object PatternRadiusPoint { get; set; }
    PatternPositioningMethodEnum PositioningMethod { get; set; }
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

**Referenced types:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md), [AttributeSets](../objects/AttributeSets.md), [CircularOccurrencePattern](../objects/CircularOccurrencePattern.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [OccurrencePatternElement](../objects/OccurrencePatternElement.md), [OccurrencePatternElements](../objects/OccurrencePatternElements.md), [OccurrencePatternSuppressionEnum](../enums/OccurrencePatternSuppressionEnum.md), [Parameter](../objects/Parameter.md), [PatternPositioningMethodEnum](../enums/PatternPositioningMethodEnum.md)

