# DSJoint

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.SimulationManager.DynamicSimulations.Item[…].DSJoints.Item[…]`

```csharp
interface DSJoint
{
    // Properties
    object Application { get; }
    DSJointDefinition Definition { get; set; }
    bool IsSuppressed { get; set; }
    DSJointTypeEnum JointType { get; }
    string Name { get; set; }
    DynamicSimulation Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [DSJointDefinition](../objects/DSJointDefinition.md).Parent, [DSJoints](../objects/DSJoints.md).Item

**Referenced types:** [DSJointDefinition](../objects/DSJointDefinition.md), [DSJointTypeEnum](../enums/DSJointTypeEnum.md), [DynamicSimulation](../objects/DynamicSimulation.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

