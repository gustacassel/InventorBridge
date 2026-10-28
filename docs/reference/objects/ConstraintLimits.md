# ConstraintLimits

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.iMateDefinitions.Item[…] → (FlushiMateDefinition).ConstraintLimits`

```csharp
interface ConstraintLimits
{
    // Properties
    object Application { get; }
    Parameter Maximum { get; }
    bool MaximumEnabled { get; set; }
    Parameter Minimum { get; }
    bool MinimumEnabled { get; set; }
    object Parent { get; }
    bool RestingPositionEnabled { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [AngleConstraint](../objects/AngleConstraint.md).ConstraintLimits, [AngleConstraintProxy](../objects/AngleConstraintProxy.md).ConstraintLimits, [FlushConstraint](../objects/FlushConstraint.md).ConstraintLimits, [FlushConstraintProxy](../objects/FlushConstraintProxy.md).ConstraintLimits, [FlushiMateDefinition](../objects/FlushiMateDefinition.md).ConstraintLimits, [FlushiMateDefinitionProxy](../objects/FlushiMateDefinitionProxy.md).ConstraintLimits, [InsertConstraint](../objects/InsertConstraint.md).ConstraintLimits, [InsertConstraintProxy](../objects/InsertConstraintProxy.md).ConstraintLimits, [InsertiMateDefinition](../objects/InsertiMateDefinition.md).ConstraintLimits, [InsertiMateDefinitionProxy](../objects/InsertiMateDefinitionProxy.md).ConstraintLimits, [MateConstraint](../objects/MateConstraint.md).ConstraintLimits, [MateConstraintProxy](../objects/MateConstraintProxy.md).ConstraintLimits, [MateiMateDefinition](../objects/MateiMateDefinition.md).ConstraintLimits, [MateiMateDefinitionProxy](../objects/MateiMateDefinitionProxy.md).ConstraintLimits, [TangentConstraint](../objects/TangentConstraint.md).ConstraintLimits, [TangentConstraintProxy](../objects/TangentConstraintProxy.md).ConstraintLimits, [TangentiMateDefinition](../objects/TangentiMateDefinition.md).ConstraintLimits, [TangentiMateDefinitionProxy](../objects/TangentiMateDefinitionProxy.md).ConstraintLimits

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md)

