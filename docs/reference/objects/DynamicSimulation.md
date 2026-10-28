# DynamicSimulation

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.SimulationManager.DynamicSimulations.Item[…]`

```csharp
interface DynamicSimulation
{
    // Properties
    object Application { get; }
    int CurrentTimeStep { get; set; }
    DSJoints DSJoints { get; }
    DSLoads DSLoads { get; }
    DSSettings DSSettings { get; }
    bool IsInSimulationMode { get; set; }
    int LastComputedTimeStep { get; }
    int NumberOfTimeSteps { get; set; }
    SimulationManager Parent { get; }
    int PlaybackSpeed { get; set; }
    double SimulationLength { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void ComputeSimulation(int EndStep = -1);
    void PlaySimulation(int StartStep = 1, int EndStep = -1);
}
```

**Returned by:** [DSJoint](../objects/DSJoint.md).Parent, [DynamicSimulations](../objects/DynamicSimulations.md).Item

**Referenced types:** [DSJoints](../objects/DSJoints.md), [DSLoads](../objects/DSLoads.md), [DSSettings](../objects/DSSettings.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SimulationManager](../objects/SimulationManager.md)

