# FeatureBasedOccurrencePatternProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [FeatureBasedOccurrencePattern](../objects/FeatureBasedOccurrencePattern.md) → [OccurrencePattern](../objects/OccurrencePattern.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.OccurrencePatterns.Item[…] → (FeatureBasedOccurrencePattern) → (FeatureBasedOccurrencePatternProxy)`

```csharp
interface FeatureBasedOccurrencePatternProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    object FeaturePattern { get; set; }
    HealthStatusEnum HealthStatus { get; }
    bool IsPatternElement { get; }
    string Name { get; set; }
    FeatureBasedOccurrencePattern NativeObject { get; }
    OccurrencePatternElements OccurrencePatternElements { get; }
    AssemblyComponentDefinition Parent { get; }
    ObjectCollection ParentComponents { get; set; }
    OccurrencePatternElement PatternElement { get; }
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

**Referenced types:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md), [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [FeatureBasedOccurrencePattern](../objects/FeatureBasedOccurrencePattern.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [OccurrencePatternElement](../objects/OccurrencePatternElement.md), [OccurrencePatternElements](../objects/OccurrencePatternElements.md), [OccurrencePatternSuppressionEnum](../enums/OccurrencePatternSuppressionEnum.md)

