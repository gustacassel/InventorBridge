# DSJoints

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.SimulationManager.DynamicSimulations.Item[…].DSJoints`

```csharp
interface DSJoints
{
    // Properties
    object Application { get; }
    int Count { get; }
    DSJoint Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DynamicSimulation](../objects/DynamicSimulation.md).DSJoints

**Referenced types:** [DSJoint](../objects/DSJoint.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

