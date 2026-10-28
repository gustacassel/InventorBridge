# DSDegreeOfFreedom

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.SimulationManager.DynamicSimulations.Item[…].DSJoints.Item[…].Definition.DegreesOfFreedom.Item[…]`

```csharp
interface DSDegreeOfFreedom
{
    // Properties
    object Application { get; }
    DSDegreeOfFreedomTypeEnum DegreeOfFreedomType { get; }
    DSDOFImposedMotionTypeEnum ImposedMotionType { get; set; }
    DSValue ImposedMotionValue { get; }
    double InitialPosition { get; set; }
    double InitialVelocity { get; set; }
    bool IsLoadEnabled { get; set; }
    bool IsMaxBoundsEnabled { get; set; }
    bool IsMinBoundsEnabled { get; set; }
    bool IsPositionLocked { get; set; }
    bool IsVelocityComputed { get; set; }
    DSValue LoadDamping { get; }
    DSValue LoadDryFrictionCoefficient { get; }
    DSValue LoadDryFrictionRadius { get; }
    DSValue LoadForce { get; }
    DSValue LoadSpringElasticStiffness { get; }
    DSValue LoadSpringFreePosition { get; }
    DSValue MaxBoundsDamping { get; }
    DSValue MaxBoundsStiffness { get; }
    DSValue MaxBoundsValue { get; }
    DSValue MinBoundsDamping { get; }
    DSValue MinBoundsStiffness { get; }
    DSValue MinBoundsValue { get; }
    DSJointDefinition Parent { get; }
    DSResults Results { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [DSDegreesOfFreedom](../objects/DSDegreesOfFreedom.md).Item, [DSResult](../objects/DSResult.md).Parent

**Referenced types:** [DSDOFImposedMotionTypeEnum](../enums/DSDOFImposedMotionTypeEnum.md), [DSDegreeOfFreedomTypeEnum](../enums/DSDegreeOfFreedomTypeEnum.md), [DSJointDefinition](../objects/DSJointDefinition.md), [DSResults](../objects/DSResults.md), [DSValue](../objects/DSValue.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

