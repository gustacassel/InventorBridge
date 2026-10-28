# SimulationManager

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.SimulationManager`

```csharp
interface SimulationManager
{
    // Properties
    object Application { get; }
    DynamicSimulations DynamicSimulations { get; }
    ComponentDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).SimulationManager, [DynamicSimulation](../objects/DynamicSimulation.md).Parent, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).SimulationManager

**Referenced types:** [ComponentDefinition](../objects/ComponentDefinition.md), [DynamicSimulations](../objects/DynamicSimulations.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

