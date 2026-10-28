# InterferenceResults

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.AnalyzeInterference(…)`

```csharp
interface InterferenceResults
{
    // Properties
    int Count { get; }
    InterferenceResult Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).AnalyzeInterference, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).AnalyzeInterference

**Referenced types:** [InterferenceResult](../objects/InterferenceResult.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

