# DSSettings

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.SimulationManager.DynamicSimulations.Item[…].DSSettings`

```csharp
interface DSSettings
{
    // Properties
    object Application { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [DynamicSimulation](../objects/DynamicSimulation.md).DSSettings

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

