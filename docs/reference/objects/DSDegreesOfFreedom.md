# DSDegreesOfFreedom

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.SimulationManager.DynamicSimulations.Item[…].DSJoints.Item[…].Definition.DegreesOfFreedom`

```csharp
interface DSDegreesOfFreedom
{
    // Properties
    object Application { get; }
    int Count { get; }
    DSDegreeOfFreedom Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DSJointDefinition](../objects/DSJointDefinition.md).DegreesOfFreedom

**Referenced types:** [DSDegreeOfFreedom](../objects/DSDegreeOfFreedom.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

