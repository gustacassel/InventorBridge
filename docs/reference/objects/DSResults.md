# DSResults

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.SimulationManager.DynamicSimulations.Item[…].DSJoints.Item[…].Definition.DegreesOfFreedom.Item[…].Results`

```csharp
interface DSResults
{
    // Properties
    object Application { get; }
    int Count { get; }
    DSResult Item[int Index] { get; }
    DSResult ItemByResultType[DSResultTypeEnum ResultType] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DSDegreeOfFreedom](../objects/DSDegreeOfFreedom.md).Results

**Referenced types:** [DSResult](../objects/DSResult.md), [DSResultTypeEnum](../enums/DSResultTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

