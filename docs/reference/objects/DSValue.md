# DSValue

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.SimulationManager.DynamicSimulations.Item[…].DSLoads.Item[…].Definition.Magnitude`

```csharp
interface DSValue
{
    // Properties
    object Application { get; }
    double ConstantValue { get; set; }
    DSValueGraph Graph { get; }
    bool IsConstantValue { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [DSDegreeOfFreedom](../objects/DSDegreeOfFreedom.md).ImposedMotionValue, [DSDegreeOfFreedom](../objects/DSDegreeOfFreedom.md).LoadDamping, [DSDegreeOfFreedom](../objects/DSDegreeOfFreedom.md).LoadDryFrictionCoefficient, [DSDegreeOfFreedom](../objects/DSDegreeOfFreedom.md).LoadDryFrictionRadius, [DSDegreeOfFreedom](../objects/DSDegreeOfFreedom.md).LoadForce, [DSDegreeOfFreedom](../objects/DSDegreeOfFreedom.md).LoadSpringElasticStiffness, [DSDegreeOfFreedom](../objects/DSDegreeOfFreedom.md).LoadSpringFreePosition, [DSDegreeOfFreedom](../objects/DSDegreeOfFreedom.md).MaxBoundsDamping, [DSDegreeOfFreedom](../objects/DSDegreeOfFreedom.md).MaxBoundsStiffness, [DSDegreeOfFreedom](../objects/DSDegreeOfFreedom.md).MaxBoundsValue, [DSDegreeOfFreedom](../objects/DSDegreeOfFreedom.md).MinBoundsDamping, [DSDegreeOfFreedom](../objects/DSDegreeOfFreedom.md).MinBoundsStiffness, [DSDegreeOfFreedom](../objects/DSDegreeOfFreedom.md).MinBoundsValue, [DSLoadDefinition](../objects/DSLoadDefinition.md).Magnitude, [DSLoadDefinition](../objects/DSLoadDefinition.md).VectorXComponent, [DSLoadDefinition](../objects/DSLoadDefinition.md).VectorYComponent, [DSLoadDefinition](../objects/DSLoadDefinition.md).VectorZComponent

**Referenced types:** [DSValueGraph](../objects/DSValueGraph.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

