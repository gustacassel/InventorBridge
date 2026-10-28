# VisibleOccurrenceFinder

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.CreateVisibleOccurrenceFinder(…)`

```csharp
interface VisibleOccurrenceFinder
{
    // Properties
    object Application { get; }
    bool CompactResult { get; set; }
    ComponentOccurrencesEnumerator FoundOccurrences { get; }
    double PercentageVisible { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
}
```

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).CreateVisibleOccurrenceFinder, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).CreateVisibleOccurrenceFinder

**Referenced types:** [ComponentOccurrencesEnumerator](../objects/ComponentOccurrencesEnumerator.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

