# InterferenceResult

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.AnalyzeInterference(…).Item[…]`

```csharp
interface InterferenceResult
{
    // Properties
    Point Centroid { get; }
    SurfaceBody InterferenceBody { get; }
    ComponentOccurrence OccurrenceOne { get; }
    ComponentOccurrence OccurrenceTwo { get; }
    ObjectTypeEnum Type { get; }
    double Volume { get; }
}
```

**Returned by:** [InterferenceResults](../objects/InterferenceResults.md).Item

**Referenced types:** [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [SurfaceBody](../objects/SurfaceBody.md)

