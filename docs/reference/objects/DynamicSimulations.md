# DynamicSimulations

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.SimulationManager.DynamicSimulations`

```csharp
interface DynamicSimulations
{
    // Properties
    object Application { get; }
    int Count { get; }
    DynamicSimulation Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SimulationManager](../objects/SimulationManager.md).DynamicSimulations

**Referenced types:** [DynamicSimulation](../objects/DynamicSimulation.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

